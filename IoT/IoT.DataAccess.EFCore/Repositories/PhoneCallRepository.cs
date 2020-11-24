/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.DataAccess.EFCore;
using Common.Entities;
using IoT.Entities;
using IoT.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT.DataAccess.EFCore
{
    public class PhoneCallRepository : BaseRepository<PhoneCall, IoTDataContext>, IPhoneCallRepository
    {
        public PhoneCallRepository(IoTDataContext context) : base(context)
        {
        }

        public override async Task<PhoneCall> Get(int id, ContextSession session)
        {
            return await GetEntities(session)
                .Where(obj => obj.Id == id)
                .Include(obj => obj.Contact)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PhoneCall>> GetList(BaseFilter filter, ContextSession session)
        {
            return await GetEntities(session)
                .Include(obj => obj.Contact)
                .OrderByDescending(x => x.DateOfCall)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .ToArrayAsync();
        }
    }
}