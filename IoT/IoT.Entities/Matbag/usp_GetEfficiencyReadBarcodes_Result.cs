using System;
namespace IoT.Entities.Matbag
{
    public class usp_GetEfficiencyReadBarcodes_Result
    {
        public Nullable<int> idAtr { get; set; }
        public Nullable<double> Reads { get; set; }
        public Nullable<double> NoReads { get; set; }
        public Nullable<double> Error { get; set; }
        public Nullable<double> Eficiencia { get; set; }
    }
}
