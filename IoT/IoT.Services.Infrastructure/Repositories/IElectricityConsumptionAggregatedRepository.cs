/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Entities;
using Common.Entities.Statistics;
using IoT.Entities.Statistics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IoT.Services.Infrastructure
{
    public interface IElectricityConsumptionAggregatedRepository
    {
        Task<Dictionary<int, IEnumerable<AggregatedData>>> GetTableData(int countOfYears, ContextSession session);

        Task<IEnumerable<AggregatedData>> GetWeekChartData(ContextSession session);
        Task<IEnumerable<AggregatedData>> GetYearlyChartData(ContextSession session);
        Task<IEnumerable<AggregatedData>> GetMonthlyChartData(ContextSession session);
        Task<SolarEnergyConsumption> GetSolarEnergyStatistic(ContextSession session);
    }
}
