/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.WebApiCore.Controllers;
using IoT.DTO;
using IoT.Services.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IoT.WebApiCore.Controllers
{
    [Route("devices/{deviceId:int}/parameters")]
    public class DeviceParametersController : BaseApiController
    {
        protected readonly IDeviceParameterService parametersService;

        public DeviceParametersController(IDeviceParameterService parametersService)
        {
            this.parametersService = parametersService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Parameters(int deviceId)
        {
            var parameters = await parametersService.GetAllParameters(deviceId);
            return Ok(parameters);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Parameter(int deviceId, int id)
        {
            var parameter = await parametersService.GetById(id);
            return Ok(parameter);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create(int deviceId, DeviceParameterDTO dto)
        {
            var parameter = await parametersService.Create(deviceId, dto);
            return Ok(parameter);
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> Update(int deviceId, DeviceParameterDTO dto)
        {
            var parameter = await parametersService.Update(deviceId, dto);
            return Ok(parameter);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int deviceId, int id)
        {
            await parametersService.Delete(id);
            return Ok();
        }
    }
}