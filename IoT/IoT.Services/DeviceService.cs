/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Services;
using Common.Services.Infrastructure;
using Common.Utils;
using IoT.DTO;
using IoT.Entities;
using IoT.Services.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IoT.Services
{
    public class DeviceService : BaseService, IDeviceService
    {
        protected readonly IDeviceRepository deviceRepository;
        public DeviceService(ICurrentContextProvider contextProvider, IDeviceRepository deviceRepository): base(contextProvider)
        {
            this.deviceRepository = deviceRepository;
        }

        public async Task<IEnumerable<DeviceDTO>> GetAllDevices()
        {
            var devices = await deviceRepository.GetList(Session);

            return devices.MapTo<IEnumerable<DeviceDTO>>();
        }

        public async Task<DeviceDTO> GetById(int id)
        {
            var device = await deviceRepository.Get(id, Session);

            return device.MapTo<DeviceDTO>();
        }

        public async Task<DeviceDTO> Update(DeviceDTO device)
        {
            device.Parameters = null;
            var result = await deviceRepository.Edit(device.MapTo<Device>(), Session);
            return result.MapTo<DeviceDTO>();
        }

        public async Task<DeviceDTO> Create(DeviceDTO device)
        {
            device.Parameters = null;
            var result = await deviceRepository.Edit(device.MapTo<Device>(), Session);
            return result.MapTo<DeviceDTO>();
        }
    }
}
