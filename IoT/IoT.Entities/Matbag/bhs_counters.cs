using System;
namespace IoT.Entities.Matbag
{
    public class bhs_counters
    {
        public int id { get; set; }
        public string value { get; set; }
        public string aux { get; set; }
        public Nullable<DateTime> DateRegister { get; set; }
    }
}
