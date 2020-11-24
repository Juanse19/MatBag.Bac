/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Entities;
using Common.Entities.Statistics;
using Common.Utils.Extensions;
using IoT.Entities;
using IoT.Entities.Statistics;
using IoT.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;

namespace IoT.DataAccess.EFCore
{
    public class ElectricityConsumptionAggregatedRepository : IElectricityConsumptionAggregatedRepository
    {
        private readonly IoTDataContext _dbContext;

        public ElectricityConsumptionAggregatedRepository(IoTDataContext context)
        {
            _dbContext = context;
        }

        protected IoTDataContext GetContext(ContextSession session)
        {
            _dbContext.Session = session;
            return _dbContext;
        }

        protected async Task<Dictionary<int, IEnumerable<AggregatedData>>> GetGroupedData(
            IEnumerable<Tuple<int, Expression<Func<ElectricityConsumption, bool>>>> groupWithCondition,
            Expression<Func<ElectricityConsumption, bool>> baseFilter,
            Expression<Func<ElectricityConsumption, AggregatedData>> groupDataSelector,
            ContextSession session)
        {
            var result = new Dictionary<int, IEnumerable<AggregatedData>>();
            var dataByGroupsQueries = new Dictionary<int, QueryFutureEnumerable<AggregatedData>>();
            foreach (var gr in groupWithCondition)
            {
                var query = GetContext(session).ElectricityConsumptions
                    .AsNoTracking()
                    .Where(baseFilter)
                    .Where(gr.Item2)
                    .Select(groupDataSelector)
                    .GroupBy(obj => obj.Group)
                    .Select(group => new AggregatedData
                        {Group = group.Key, Sum = group.Sum(x => x.Sum), Count = group.Sum(x => x.Count)})
                    .Future();
                dataByGroupsQueries.Add(gr.Item1, query);
            }

            foreach (var gr in groupWithCondition)
            {
                var data = await dataByGroupsQueries[gr.Item1].ToListAsync();
                result.Add(gr.Item1, data);
            }

            return result;
        }

        protected async Task<IEnumerable<AggregatedData>> GetChartData(
            Expression<Func<ElectricityConsumption, bool>> baseFilter,
            Expression<Func<ElectricityConsumption, AggregatedData>> groupDataSelector,
            ContextSession session)
        {
            return await GetContext(session).ElectricityConsumptions
                .AsNoTracking()
                .Where(baseFilter)
                .Select(groupDataSelector)
                .GroupBy(obj => obj.Group)
                .Select(group => new AggregatedData
                    {Group = group.Key, Sum = group.Sum(x => x.Sum), Count = group.Sum(x => x.Count)})
                .ToListAsync();
        }

        public Task<Dictionary<int, IEnumerable<AggregatedData>>> GetTableData(int countOfYears,
            ContextSession session)
        {
            var startDate = DateTime.Today.YearBefore(countOfYears + 1);
            var groupWithCondition = Enumerable.Range(startDate.Year, countOfYears)
                .Select(x =>
                    new Tuple<int, Expression<Func<ElectricityConsumption, bool>>>(x, obj => obj.Date.Year == x));

            var startOfPreviousYear = new DateTime(DateTime.Today.Year, 1, 1);
            var startOfThreeYearBeforeYear = new DateTime(startDate.Year, 1, 1);

            return GetGroupedData(groupWithCondition,
                obj => obj.Date >= startOfThreeYearBeforeYear && obj.Date < startOfPreviousYear,
                obj => new AggregatedData
                    {Group = obj.Date.Month, Sum = obj.ConsumedValue, Count = obj.SpentMoneyValue},
                session);
        }

        public Task<IEnumerable<AggregatedData>> GetWeekChartData(ContextSession session)
        {
            var startOfPreviousWeek = DateTime.Today.WeekBefore().StartOfWeek();
            var endOfPreviousWeek = DateTime.Today.WeekBefore().EndOfWeek();

            return GetChartData(
                obj => obj.Date >= startOfPreviousWeek && obj.Date <= endOfPreviousWeek,
                obj => new AggregatedData {Group = obj.Date.Day, Sum = obj.ConsumedValue, Count = obj.SpentMoneyValue},
                session);
        }

        public Task<IEnumerable<AggregatedData>> GetMonthlyChartData(ContextSession session)
        {
            var startOfPreviousMonth = DateTime.Today.MonthBefore().StartOfMonth();
            var endOfPreviousMonth = DateTime.Today.MonthBefore().EndOfMonth();

            return GetChartData(
                obj => obj.Date >= startOfPreviousMonth && obj.Date <= endOfPreviousMonth,
                obj => new AggregatedData {Group = obj.Date.Day, Sum = obj.ConsumedValue, Count = obj.SpentMoneyValue},
                session);
        }

        public Task<IEnumerable<AggregatedData>> GetYearlyChartData(ContextSession session)
        {
            var startOfPreviousYear = new DateTime(DateTime.Today.Year - 1, 1, 1);
            var endOfPreviousYear = new DateTime(DateTime.Today.Year - 1, 12, 31);

            return GetChartData(
                obj => obj.Date >= startOfPreviousYear && obj.Date <= endOfPreviousYear,
                obj => new AggregatedData
                    {Group = obj.Date.Month, Sum = obj.ConsumedValue, Count = obj.SpentMoneyValue},
                session);
        }

        public async Task<SolarEnergyConsumption> GetSolarEnergyStatistic(ContextSession session)
        {
            var total = await GetContext(session).ElectricityConsumptions.AsNoTracking().Select(x => x.ConsumedValue)
                .SumAsync(x => x);
            var solar = await GetContext(session).ElectricityConsumptions.AsNoTracking().Where(x => x.Type == 2)
                .Select(x => x.ConsumedValue).SumAsync(x => x);

            return new SolarEnergyConsumption
            {
                TotalValue = total,
                SolarValue = solar
            };
        }
    }
}