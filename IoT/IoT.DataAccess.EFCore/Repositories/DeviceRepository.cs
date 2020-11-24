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
    public class DeviceRepository : BaseRepository<Device, IoTDataContext>, IDeviceRepository
    {
        public DeviceRepository(IoTDataContext context) : base(context)
        {
        }

        public override async Task<Device> Get(int id, ContextSession session)
        {
            return await GetEntities(session)
                .Where(obj => obj.Id == id)
                .Include(obj => obj.Parameters)
                .FirstOrDefaultAsync();
        }

        public override async Task<IEnumerable<Device>> GetList(ContextSession session)
        {
            return await GetEntities(session)
                .Include(c => c.Parameters)
                .ToArrayAsync();
        }
    }
}