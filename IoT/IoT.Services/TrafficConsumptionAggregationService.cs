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
using IoT.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace IoT.Services
{
    public class TrafficConsumptionAggregationService : BaseService, ITrafficConsumptionAggregationService
    {
        protected readonly ITrafficConsumptionAggregatedRepository trafficConsumptionAggregatedRepository;

        public TrafficConsumptionAggregationService(ICurrentContextProvider contextProvider, ITrafficConsumptionAggregatedRepository trafficConsumptionAggregatedRepository)
            : base(contextProvider)
        {
            this.trafficConsumptionAggregatedRepository = trafficConsumptionAggregatedRepository;
        }

        public async Task<BaseChartDTO<int>> GetDataForChart(string aggregation)
        {
            var dataForChart = new BaseChartDTO<int>();

            Enum.TryParse(aggregation, true, out PeriodFilterEnum period);

            switch (period)
            {
                case PeriodFilterEnum.Year:
                    {
                        var data = await trafficConsumptionAggregatedRepository.GetDataForYear(Session);
                        data = data.ExtendWithEmptyData(Enumerable.Range(1, 12));

                        dataForChart = new BaseChartDTO<int>
                        {
                            ChartLabel = "MB",
                            AxisXLabels = data.Select(x => DateTimeFormatInfo.InvariantInfo.GetAbbreviatedMonthName(x.Group)).ToList(),
                            Lines = new List<ChartDataDTO<int>>
                            {
                                new ChartDataDTO<int>{
                                    Values = data.Select(x => (int)x.Sum).ToList(),
                                    Type = null
                                }
                            }
                        };

                        break;
                    }
                case PeriodFilterEnum.Month:
                    {
                        var data = await trafficConsumptionAggregatedRepository.GetDataForMonth(Session);
                        data = data.ExtendWithEmptyData(Enumerable.Range(1, DateTime.DaysInMonth(DateTime.Today.MonthBefore().Year, DateTime.Today.MonthBefore().Month)));

                        dataForChart = new BaseChartDTO<int>
                        {
                            ChartLabel = "MB",
                            AxisXLabels = data.Select(x => x.Group.ToString()).ToList(),
                            Lines = new List<ChartDataDTO<int>>
                            {
                                new ChartDataDTO<int>{
                                    Values = data.Select(x => (int)x.Sum).ToList(),
                                    Type = null
                                }
                            }
                        };

                        break;
                    }
                case PeriodFilterEnum.Week:
                    {
                        var data = await trafficConsumptionAggregatedRepository.GetDataForWeek(Session);

                        var today = DateTime.Today;
                        var startOfPreviousWeek = today.WeekBefore().StartOfWeek();
                        var endOfPreviousWeek = today.WeekBefore().EndOfWeek();
                        var dates = Enumerable.Range(0, 1 + endOfPreviousWeek.Subtract(startOfPreviousWeek).Days).Select(offset => startOfPreviousWeek.AddDays(offset)).ToArray();

                        foreach (var r in data)
                        {
                            r.Group = (int)dates.Single(x => x.Day == r.Group).DayOfWeek;
                        }

                        data = data.ExtendWithEmptyData(dates.Select(x => (int)x.DayOfWeek));

                        dataForChart = new BaseChartDTO<int>
                        {
                            ChartLabel = "MB",
                            AxisXLabels = data.Select(x => DateTimeFormatInfo.InvariantInfo.GetAbbreviatedDayName((DayOfWeek)x.Group)).ToList(),
                            Lines = new List<ChartDataDTO<int>>
                            {
                                new ChartDataDTO<int>{
                                    Values = data.Select(x => (int)x.Sum).ToList(),
                                    Type = null
                                }
                            }
                        };

                        break;
                    }
            }

            return dataForChart;
        }
    }
}
