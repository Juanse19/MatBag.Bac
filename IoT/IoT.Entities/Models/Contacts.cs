using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class Contacts
    {
        public Contacts()
        {
            PhoneCalls = new HashSet<PhoneCalls>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public int UpdatedByUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int NumberType { get; set; }

        public virtual ContactPhotos ContactPhotos { get; set; }
        public virtual ICollection<PhoneCalls> PhoneCalls { get; set; }
    }
}
