using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class ElectricityConsumptions
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ConsumedValue { get; set; }
        public int SpentMoneyValue { get; set; }
        public int Type { get; set; }
    }
}
