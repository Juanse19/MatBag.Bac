using System;
namespace IoT.Entities.Matbag
{
    public class usp_CreateViewCardsConveyors_Result
    {
        public string Description { get; set; }
        public string State { get; set; }
        public double? Potencia { get; set; }
        public int? TimeOn { get; set; }
        public int? TimeOff { get; set; }
    }
}
