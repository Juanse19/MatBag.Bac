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
    [Route("devices")]
    public class DevicesController : BaseApiController
    {
        protected readonly IDeviceService deviceService;
        public DevicesController(IDeviceService deviceService)
        {
            this.deviceService = deviceService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Devices()
        {
            var devices = await deviceService.GetAllDevices();
            return Ok(devices);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Device(int id)
        {
            var device = await deviceService.GetById(id);
            return Ok(device);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update(int id, DeviceDTO device)
        {
            if (id != device.Id)
            {
                return BadRequest();
            }

            var result = await deviceService.Update(device);
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create(DeviceDTO device)
        {
            var result = await deviceService.Create(device);
            return Ok(result);
        }
    }
}
