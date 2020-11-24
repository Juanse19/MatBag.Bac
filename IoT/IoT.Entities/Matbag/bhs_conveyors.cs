using System;
namespace IoT.Entities.Matbag
{
    public class bhs_conveyors
    {
        public int id { get; set; }
        public int idConveyors { get; set; }
        public string current { get; set; }
        public string power { get; set; }
        public string state { get; set; }
        public string idFailure { get; set; }
        public Nullable<DateTime> DateRegister { get; set; }
    }
}
