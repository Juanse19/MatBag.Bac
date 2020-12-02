using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class UserPhotos
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }

        public virtual Users IdNavigation { get; set; }
    }
}
