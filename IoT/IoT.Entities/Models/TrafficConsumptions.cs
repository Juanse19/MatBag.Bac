﻿using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class TrafficConsumptions
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ConsumedValue { get; set; }
    }
}
