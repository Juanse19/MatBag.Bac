using System;
using IoT.Entities.System;
using System.Collections.Generic;

namespace IoT.Entities.Matbag
{
    public class bhs_atr
    {
        public int id { get; set; }
        public int idAtr { get; set; }
        public string bagtag { get; set; }
        public string aux { get; set; }
        public Nullable<DateTime> DateRegister { get; set; }
    }
}
