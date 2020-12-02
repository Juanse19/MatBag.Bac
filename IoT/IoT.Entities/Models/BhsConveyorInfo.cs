using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class BhsConveyorInfo
    {
        public int Id { get; set; }
        public int IdConveyors { get; set; }
        public string Description { get; set; }
        public string Ubication { get; set; }
        public string CoordX { get; set; }
        public string CoordY { get; set; }
        public DateTime? DateRegister { get; set; }
    }
}
