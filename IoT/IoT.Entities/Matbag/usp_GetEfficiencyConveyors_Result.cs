using System;
namespace IoT.Entities.Matbag
{
    public class usp_GetEfficiencyConveyors_Result
    {
        public string desc { get; set; }
        public string State { get; set; }
        public Nullable<double> power { get; set; }
        public Nullable<double> current { get; set; }
        public string failure { get; set; }
    }
}
