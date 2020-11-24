using System;
namespace IoT.Entities.Matbag
{
    public class bhs_ConveyorInfo
    {
        public int id { get; set; }
        public int idConveyors { get; set; }
        public string description { get; set; }
        public string ubication { get; set; }
        public string coordX { get; set; }
        public string coordY { get; set; }
        public Nullable<DateTime> DateRegister { get; set; }
    }
}
