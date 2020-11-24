using System;
namespace IoT.Entities.Matbag
{
    public class usp_CreateViewsConveyors_Result
    {
        public string Description { get; set; }
        public Nullable<int> Reads { get; set; }
        public Nullable<int> NoReads { get; set; }
        public Nullable<int> Eficiencia { get; set; }
        public string State { get; set; }
    }
}
