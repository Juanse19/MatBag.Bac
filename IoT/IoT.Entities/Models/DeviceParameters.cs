using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class DeviceParameters
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public int UpdatedByUserId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int DeviceId { get; set; }

        public virtual Users CreatedByUser { get; set; }
        public virtual Devices Device { get; set; }
        public virtual Users UpdatedByUser { get; set; }
    }
}
