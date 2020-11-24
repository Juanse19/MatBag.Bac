/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.DTO;
using System.Threading.Tasks;

namespace IoT.Services.Infrastructure
{
    public interface ITrafficConsumptionAggregationService
    {
        Task<BaseChartDTO<int>> GetDataForChart(string aggregation);
    }
}
