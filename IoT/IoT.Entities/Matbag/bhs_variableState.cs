using System;
namespace IoT.Entities.Matbag
{
    public class bhs_variableState
    {
        public int id { get; set; }
        public string value { get; set; }
        public string aux { get; set; }
        public Nullable<DateTime> dateRegister { get; set; }
    }
}
