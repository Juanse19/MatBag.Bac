/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.WebApiCore.Controllers;
using IoT.Services.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IoT.WebApiCore.Controllers
{
    [Route("energy-aggregated")]
    public class EnergyAggregatedController : BaseApiController
    {
        protected readonly IElectricityConsumptionAggregationService electricityConsumptionService;
        public EnergyAggregatedController(IElectricityConsumptionAggregationService electricityConsumptionService)
        {
            this.electricityConsumptionService = electricityConsumptionService;
        }

        [HttpGet]
        [Route("summary")]
        public async Task<IActionResult> SolarEnergyStatistic()
        {
            var result = await electricityConsumptionService.GetSolarEnergyStatistic();
            return Ok(result);
        }

        [HttpGet]
        [Route("history")]
        public async Task<IActionResult> GetDataForTable(int countOfYears = 3)
        {
            var result = await electricityConsumptionService.GetDataForTable(countOfYears);
            return Ok(result);
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetDataForChart(string period = "week")
        {
            var result = await electricityConsumptionService.GetDataForChart(period);
            return Ok(result);
        }
    }
}
