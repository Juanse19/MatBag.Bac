using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class Devices
    {
        public Devices()
        {
            DeviceParameters = new HashSet<DeviceParameters>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public int UpdatedByUserId { get; set; }
        public string Name { get; set; }
        public bool IsOn { get; set; }
        public int Type { get; set; }

        public virtual Users CreatedByUser { get; set; }
        public virtual Users UpdatedByUser { get; set; }
        public virtual ICollection<DeviceParameters> DeviceParameters { get; set; }
    }
}
