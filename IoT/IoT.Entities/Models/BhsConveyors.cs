using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class BhsConveyors
    {
        public int Id { get; set; }
        public int IdConveyors { get; set; }
        public string Current { get; set; }
        public string Power { get; set; }
        public string State { get; set; }
        public string IdFailure { get; set; }
        public DateTime? DateRegister { get; set; }
    }
}
