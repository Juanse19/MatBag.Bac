/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.DataAccess.EFCore;
using IoT.Entities.System;

namespace IoT.DataAccess.EFCore
{
    public class UserClaimRepository : BaseUserClaimRepository<UserClaim, IoTDataContext>
    {
        public UserClaimRepository(IoTDataContext context) : base(context)
        {
        }
    }
}
