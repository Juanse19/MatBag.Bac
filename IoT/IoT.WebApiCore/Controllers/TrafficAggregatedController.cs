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
    [Route("network-aggregated")]
    public class TrafficAggregatedController : BaseApiController
    {
        protected readonly ITrafficConsumptionAggregationService trafficService;
        public TrafficAggregatedController(ITrafficConsumptionAggregationService trafficService)
        {
            this.trafficService = trafficService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> TrafficConsumption(string period = "year")
        {
            var traffic = await trafficService.GetDataForChart(period);
            return Ok(traffic);
        }
    }
}
