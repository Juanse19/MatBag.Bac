using System;
namespace IoT.Entities.Matbag
{
    public class bhs_bpi
    {
        public int id { get; set; }
        public string bagtag { get; set; }
        public string quality { get; set; }
        public string aux { get; set; }
        public Nullable<DateTime> DateRegister { get; set; }
    }
}
