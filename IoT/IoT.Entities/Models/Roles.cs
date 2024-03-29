﻿using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class Roles
    {
        public Roles()
        {
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Discriminator { get; set; }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
