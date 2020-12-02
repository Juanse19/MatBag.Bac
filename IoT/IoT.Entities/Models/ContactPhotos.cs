using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class ContactPhotos
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }

        public virtual Contacts IdNavigation { get; set; }
    }
}
