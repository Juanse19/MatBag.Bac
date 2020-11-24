/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Entities;
using Common.Entities.Statistics;
using Common.Utils.Extensions;
using IoT.Entities;
using IoT.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IoT.DataAccess.EFCore
{
    public class TrafficConsumptionAggregatedRepository : ITrafficConsumptionAggregatedRepository
    {
        private readonly IoTDataContext _dbContext;

        public TrafficConsumptionAggregatedRepository(IoTDataContext context)
        {
            _dbContext = context;
        }

        protected IoTDataContext GetContext(ContextSession session)
        {
            _dbContext.Session = session;
            return _dbContext;
        }

        private async Task<IEnumerable<AggregatedData>> GetChartData(
            Expression<Func<TrafficConsumption, bool>> baseFilter,
            Expression<Func<TrafficConsumption, AggregatedData>> groupDataSelector,
            ContextSession session)
        {
            return await GetContext(session).TrafficConsumptions
                .AsNoTracking()
                .Where(baseFilter)
                .Select(groupDataSelector)
                .GroupBy(obj => obj.Group)
                .Select(group => new AggregatedData {Group = group.Key, Sum = group.Sum(x => x.Sum), Count = 0})
                .ToListAsync();
        }

        public Task<IEnumerable<AggregatedData>> GetDataForYear(ContextSession session)
        {
            var startOfPreviousYear = new DateTime(DateTime.Today.Year - 1, 1, 1);
            var endOfPreviousYear = new DateTime(DateTime.Today.Year - 1, 12, 31);
            return GetChartData(
                obj => obj.Date >= startOfPreviousYear && obj.Date <= endOfPreviousYear,
                obj => new AggregatedData {Group = obj.Date.Month, Sum = obj.ConsumedValue, Count = 0},
                session);
        }

        public Task<IEnumerable<AggregatedData>> GetDataForMonth(ContextSession session)
        {
            var startOfPreviousMonth = DateTime.Today.MonthBefore().StartOfMonth();
            var endOfPreviousMonth = DateTime.Today.MonthBefore().EndOfMonth();
            return GetChartData(
                obj => obj.Date >= startOfPreviousMonth && obj.Date <= endOfPreviousMonth,
                obj => new AggregatedData {Group = obj.Date.Day, Sum = obj.ConsumedValue, Count = 0},
                session);
        }

        public Task<IEnumerable<AggregatedData>> GetDataForWeek(ContextSession session)
        {
            var startOfPreviousWeek = DateTime.Today.WeekBefore().StartOfWeek();
            var endOfPreviousWeek = DateTime.Today.WeekBefore().EndOfWeek();
            return GetChartData(
                obj => obj.Date >= startOfPreviousWeek && obj.Date <= endOfPreviousWeek,
                obj => new AggregatedData {Group = obj.Date.Day, Sum = obj.ConsumedValue, Count = 0},
                session);
        }
    }
}