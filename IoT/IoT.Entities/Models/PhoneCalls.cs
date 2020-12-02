using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class PhoneCalls
    {
        public int Id { get; set; }
        public DateTime DateOfCall { get; set; }
        public int ContactId { get; set; }

        public virtual Contacts Contact { get; set; }
    }
}
