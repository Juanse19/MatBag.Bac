using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class BhsAtr
    {
        public int Id { get; set; }
        public int IdAtr { get; set; }
        public string Bagtag { get; set; }
        public string Aux { get; set; }
        public DateTime? DateRegister { get; set; }
    }
}
