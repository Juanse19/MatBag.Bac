﻿/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using System.Collections.Generic;

namespace Common.Entities
{
    public abstract class BaseRole : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<BaseUserRole> UserRoles { get; set; }
    }
}
