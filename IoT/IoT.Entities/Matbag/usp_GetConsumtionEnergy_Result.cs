using System;
namespace IoT.Entities.Matbag
{
    public class usp_GetConsumtionEnergy_Result
    {
        public Nullable<DateTime> Date { get; set; }
        public Nullable<int> Hours { get; set; }
        public Nullable<double> Consumo { get; set; }
    }
}
