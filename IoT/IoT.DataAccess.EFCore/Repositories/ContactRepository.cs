/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.DataAccess.EFCore;
using Common.Entities;
using IoT.Entities;
using IoT.Entities.System;
using IoT.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT.DataAccess.EFCore
{
    public class ContactRepository : BaseRepository<Contact, IoTDataContext>, IContactRepository
    {
        public ContactRepository(IoTDataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Contact>> GetList(ContactFilter filter, ContextSession session)
        {
            var query = GetEntities(session);

            if (filter?.SearchText != null)
            {
                query = query.Where(x =>
                    x.FirstName.StartsWith(filter.SearchText) || x.LastName.StartsWith(filter.SearchText));
            }

            return await query
                .OrderBy(x => x.FirstName)
                .Skip(filter.PageSize * (filter.PageNumber - 1))
                .Take(filter.PageSize)
                .ToArrayAsync();
        }
    }
}