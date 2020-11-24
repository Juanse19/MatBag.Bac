/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Entities;
using Common.Services;
using Common.Services.Infrastructure;
using Common.Utils;
using IoT.DTO;
using IoT.Services.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IoT.Services
{
    public class PhoneCallService : BaseService, IPhoneCallService
    {
        protected readonly IPhoneCallRepository phoneCallRepository;

        public PhoneCallService(ICurrentContextProvider contextProvider, IPhoneCallRepository phoneCallRepository) : base(contextProvider)
        {
            this.phoneCallRepository = phoneCallRepository;
        }

        public async Task<IEnumerable<PhoneCallDTO>> GetRecentCalls(BaseFilter filter)
        {
            var calls = await phoneCallRepository.GetList(filter, Session);
            return calls.MapTo<IEnumerable<PhoneCallDTO>>();
        }
    }
}
