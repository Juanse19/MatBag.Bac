﻿/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using IoT.DTO;
using IoT.Entities.System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IoT.Services.Infrastructure
{
    public interface IContactService
    {
        Task<IEnumerable<ContactDTO>> GetAllContacts(ContactFilter filter);
        Task<byte[]> GetContactPhoto(int contactId);
    }
}
