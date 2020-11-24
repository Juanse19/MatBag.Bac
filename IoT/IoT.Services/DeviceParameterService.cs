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
    public class DeviceParameterService : BaseService, IDeviceParameterService
    {
        protected readonly IDeviceParameterRepository deviceParametersRepository;
        public DeviceParameterService(ICurrentContextProvider contextProvider, IDeviceParameterRepository deviceParametersRepository) : base(contextProvider)
        {
            this.deviceParametersRepository = deviceParametersRepository;
        }

        public async Task<IEnumerable<DeviceParameterDTO>> GetAllParameters(int deviceId)
        {
            var parameters = await deviceParametersRepository.GetList(deviceId, Session);
            return parameters.MapTo<IEnumerable<DeviceParameterDTO>>();
        }

        public async Task<DeviceParameterDTO> GetById(int id)
        {
            var parameter = await deviceParametersRepository.Get(id, Session);
            return parameter.MapTo<DeviceParameterDTO>();
        }

        public async Task<DeviceParameterDTO> Update(int deviceId, DeviceParameterDTO deviceParameter)
        {
            var deviceParameterEntity = deviceParameter.MapTo<DeviceParameter>();
            deviceParameterEntity.DeviceId = deviceId;
            var result = await deviceParametersRepository.Edit(deviceParameterEntity, Session);

            return result.MapTo<DeviceParameterDTO>();
        }

        public async Task<DeviceParameterDTO> Create(int deviceId, DeviceParameterDTO deviceParameter)
        {
            var deviceParameterEntity = deviceParameter.MapTo<DeviceParameter>();
            deviceParameterEntity.DeviceId = deviceId;
            var result = await deviceParametersRepository.Edit(deviceParameterEntity, Session);

            return result.MapTo<DeviceParameterDTO>();
        }

        public async Task Delete(int id)
        {
            await deviceParametersRepository.Delete(id, Session);
        }
    }
}
