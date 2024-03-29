﻿/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Entities;
using IoT.Entities.System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IoT.Services.Infrastructure
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetList(BaseFilter filter, ContextSession session);
        Task<User> Get(int id, ContextSession session);
        Task<User> Edit(User order, ContextSession session);
        Task Delete(int id, ContextSession session);
    }
}
