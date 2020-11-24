/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using IoT.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IoT.Services.Infrastructure
{
    public interface IDeviceService
    {
        Task<IEnumerable<DeviceDTO>> GetAllDevices();
        Task<DeviceDTO> GetById(int id);
        Task<DeviceDTO> Update(DeviceDTO device);
        Task<DeviceDTO> Create(DeviceDTO device);
    }
}
