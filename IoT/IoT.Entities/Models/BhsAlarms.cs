using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class BhsAlarms
    {
        public int Id { get; set; }
        public int IdConveyors { get; set; }
        public string Aux { get; set; }
        public DateTime? DateRegister { get; set; }
    }
}
