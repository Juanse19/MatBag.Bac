using System;
namespace IoT.Entities.Matbag
{
    public class usp_CreateViewCardsConveyors_Result
    {
        public string Description { get; set; }
        public string State { get; set; }
        public Nullable<double> Potencia { get; set; }
        public Nullable<int> TimeOn { get; set; }
        public Nullable<int> TimeOff { get; set; }
    }
}
