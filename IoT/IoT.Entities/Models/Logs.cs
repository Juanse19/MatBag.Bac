﻿using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class Logs
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Level { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string Exception { get; set; }
        public int? UserId { get; set; }
    }
}
