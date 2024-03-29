﻿using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class UserRoles
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Discriminator { get; set; }

        public virtual Roles Role { get; set; }
        public virtual Users User { get; set; }
    }
}
