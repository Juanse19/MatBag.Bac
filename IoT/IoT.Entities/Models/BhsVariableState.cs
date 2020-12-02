using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class BhsVariableState
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Aux { get; set; }
        public DateTime? DateRegister { get; set; }
    }
}
