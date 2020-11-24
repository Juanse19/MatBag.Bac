/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Entities;
using Common.Services.Infrastructure;
using IoT.DataAccess.EFCore;

namespace Common.DataAccess.EFCore
{
    public class SettingsRepository : BaseRepository<Settings, IoTDataContext>, ISettingsRepository
    {
        public SettingsRepository(IoTDataContext context) : base(context) { }
    }
}