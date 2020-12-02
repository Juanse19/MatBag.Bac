using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class BhsDashboardV2
    {
        public int Id { get; set; }
        public int IdConveyor { get; set; }
        public int State { get; set; }
        public DateTime ValueDateTime { get; set; }
    }
}
