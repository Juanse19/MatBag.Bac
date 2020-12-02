using System;
using IoT.Entities.System;
using System.Collections.Generic;

namespace IoT.Entities.Matbag
{
    public class bhs_alarms
    {
        public int id { get; set; }
        public int idConveyors { get; set; }
        public string aux { get; set; }
        public DateTime? DateRegister { get; set; }
    
    }
}
