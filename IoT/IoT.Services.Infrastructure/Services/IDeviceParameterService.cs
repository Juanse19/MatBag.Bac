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
    public interface IDeviceParameterService
    {
        Task<IEnumerable<DeviceParameterDTO>> GetAllParameters(int deviceId);
        Task<DeviceParameterDTO> GetById(int id);
        Task<DeviceParameterDTO> Update(int deviceId, DeviceParameterDTO deviceParameter);
        Task<DeviceParameterDTO> Create(int deviceId, DeviceParameterDTO deviceParameter);
        Task Delete(int id);
    }
}
