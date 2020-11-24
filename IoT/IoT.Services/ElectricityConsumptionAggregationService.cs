/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.DTO;
using Common.Entities;
using Common.Services;
using Common.Services.Infrastructure;
using Common.Utils.Extensions;
using IoT.DTO;
using IoT.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace IoT.Services
{
    public class ElectricityConsumptionAggregationService : BaseService, IElectricityConsumptionAggregationService
    {
        protected readonly IElectricityConsumptionAggregatedRepository electricityConsumptionAggregatedRepository;

        public ElectricityConsumptionAggregationService(ICurrentContextProvider contextProvider, IElectricityConsumptionAggregatedRepository electricityConsumptionAggregatedRepository)
            : base(contextProvider)
        {
            this.electricityConsumptionAggregatedRepository = electricityConsumptionAggregatedRepository;
        }

        public async Task<IEnumerable<ElectricityConsumptionByYearDTO>> GetDataForTable(int countOfYears = 3)
        {
            var aggregatedData = await electricityConsumptionAggregatedRepository.GetTableData(countOfYears, Session);

            var keys = new List<int>(aggregatedData.Keys);
            foreach (var key in keys)
            {
                aggregatedData[key] = aggregatedData[key].ExtendWithEmptyData(Enumerable.Range(1, 12)).ToList();
            }

            var electricityConsumptionByYears = aggregatedData.Select(x => new ElectricityConsumptionByYearDTO
            {
                Year = x.Key,
                Currency = "USD",
                UnitOfMeasure = "kWh",
                Data = x.Value.Select(z => new ElectricityConsumptionDTO
                {
                    ConsumedValue = (int)z.Sum,
                    Month = DateTimeFormatInfo.InvariantInfo.GetAbbreviatedMonthName(z.Group),
                    SpentMoneyValue = z.Count, // use count to store sum of spent money
                    Trend = 0
                })
            });

            var list = electricityConsumptionByYears.ToList();

            for (var i = 0; i < list.Count; i++)
            {
                var year = list.ElementAt(i);

                var newDataList = new List<ElectricityConsumptionDTO>();

                var previousValue = 0;
                for (var j = 0; j < year.Data.Count(); j++)
                {
                    var element = year.Data.ElementAt(j);
                    var currentValue = element.ConsumedValue;
                    var trend = previousValue != 0 ? (double)(currentValue - previousValue) / previousValue * 100 : 0;
                    previousValue = currentValue;
                    newDataList.Add(new ElectricityConsumptionDTO() { ConsumedValue = element.ConsumedValue, Month = element.Month, SpentMoneyValue = element.SpentMoneyValue, Trend = Math.Round(trend) });
                }

                year.Data = newDataList;
            }

            return list;
        }

        public async Task<ElectricityConsumptionChartDTO> GetDataForChart(string aggregation)
        {
            var dataForChart = new ElectricityConsumptionChartDTO();
            var spentValue = 0;

            Enum.TryParse(aggregation, true, out PeriodFilterEnum period);

            switch (period)
            {
                case PeriodFilterEnum.Year:
                    {
                        var data = await electricityConsumptionAggregatedRepository.GetYearlyChartData(Session);
                        data = data.ExtendWithEmptyData(Enumerable.Range(1, 12));

                        dataForChart = new ElectricityConsumptionChartDTO
                        {
                            ChartLabel = "kWh",
                            AxisXLabels = data.Select(x => DateTimeFormatInfo.InvariantInfo.GetAbbreviatedMonthName(x.Group)).ToList(),
                            Lines = new List<ChartDataDTO<int>>
                            {
                                new ChartDataDTO<int>{
                                    Values = data.Select(x => (int)x.Sum).ToList(),
                                    Type = null
                                }
                            }
                        };

                        spentValue = data.Sum(x => x.Count); // use count to store sum of spent money

                        break;
                    }
                case PeriodFilterEnum.Month:
                    {
                        var data = await electricityConsumptionAggregatedRepository.GetMonthlyChartData(Session);
                        data = data.ExtendWithEmptyData(Enumerable.Range(1, DateTime.DaysInMonth(DateTime.Today.AddMonths(-1).Year, DateTime.Today.AddMonths(-1).Month)));

                        var labels = data.Where(x => x.Group == 1 || x.Group % 5 == 0);
                        var newValues = new List<int>();

                        var threshold = 3;
                        var acc = 0;
                        for (var i = 0; i < data.Count(); i++)
                        {
                            if (i < threshold)
                            {
                                acc += (int)data.ElementAt(i).Sum;
                            }
                            else
                            {
                                newValues.Add(acc);
                                acc = (int)data.ElementAt(i).Sum;
                                threshold += 5;
                            }
                        }

                        if (acc != 0)
                        {
                            newValues.Add(acc);
                        }

                        dataForChart = new ElectricityConsumptionChartDTO
                        {
                            ChartLabel = "kWh",
                            AxisXLabels = labels.Select(x => x.Group.ToString()).ToList(),
                            Lines = new List<ChartDataDTO<int>>
                            {
                                new ChartDataDTO<int>{
                                    Values = newValues,
                                    Type = null
                                }
                            }
                        };

                        spentValue = data.Sum(x => x.Count); // use count to store sum of spent money

                        break;
                    }

                case PeriodFilterEnum.Week:
                    {
                        var data = await electricityConsumptionAggregatedRepository.GetWeekChartData(Session);

                        var today = DateTime.Today;
                        var startOfPreviousWeek = today.WeekBefore().StartOfWeek();
                        var endOfPreviousWeek = today.WeekBefore().EndOfWeek();
                        var dates = Enumerable.Range(0, 1 + endOfPreviousWeek.Subtract(startOfPreviousWeek).Days).Select(offset => startOfPreviousWeek.AddDays(offset)).ToArray();

                        foreach (var r in data)
                        {
                            r.Group = (int)dates.Single(x => x.Day == r.Group).DayOfWeek;
                        }

                        data = data.ExtendWithEmptyData(dates.Select(x => (int)x.DayOfWeek));

                        dataForChart = new ElectricityConsumptionChartDTO
                        {
                            AxisXLabels = data.Select(x => DateTimeFormatInfo.InvariantInfo.GetAbbreviatedDayName((DayOfWeek)x.Group)).ToList(),
                            ChartLabel = "kWh",
                            Lines = new List<ChartDataDTO<int>>
                            {
                                new ChartDataDTO<int>{
                                    Values = data.Select(x => (int)x.Sum).ToList(),
                                    Type = null
                                }
                            }
                        };

                        spentValue = data.Sum(x => x.Count); // use count to store sum of spent money

                        break;
                    }
            }

            dataForChart.SummaryInfo = new ElectricityConsumptionSummaryDTO
            {
                ConsumedValue = new MeasuredValue<int>(dataForChart.Lines.Sum(x => x.Values.Sum(z => z)), "kWh"),
                SpentValue = new MeasuredValue<int>(spentValue, "USD")
            };

            return dataForChart;
        }

        public async Task<SolarEnergyStatisticDTO> GetSolarEnergyStatistic()
        {
            var solarStatistic = await electricityConsumptionAggregatedRepository.GetSolarEnergyStatistic(Session);
            if (solarStatistic != null)
                return new SolarEnergyStatisticDTO
                {
                    SolarValue = solarStatistic.SolarValue,
                    TotalValue = solarStatistic.TotalValue,
                    UnitOfMeasure = "kWh"
                };

            return null;
        }
    }
}
