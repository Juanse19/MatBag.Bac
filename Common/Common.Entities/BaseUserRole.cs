/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

namespace Common.Entities
{
    public abstract class BaseUserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual BaseUser User { get; set; }
        public virtual BaseRole Role { get; set; }
    }
}
