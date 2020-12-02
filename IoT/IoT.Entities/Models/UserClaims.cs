using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class UserClaims
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string Discriminator { get; set; }

        public virtual Users User { get; set; }
    }
}
