/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.DataAccess.EFCore;
using IoT.Entities;
using IoT.Services.Infrastructure;

namespace IoT.DataAccess.EFCore
{
    public class ContactPhotoRepository : BaseRepository<ContactPhoto, IoTDataContext>, IContactPhotoRepository
    {
        public ContactPhotoRepository(IoTDataContext context) : base(context)
        {
        }
    }
}
