using System;
namespace IoT.Entities.Matbag
{
    public class usp_StoppagesByBaggage_Result
    {
        public string conveyor { get; set; }
        public string ubication { get; set; }
        public int? duracionParo { get; set; }
        public string Estado { get; set; }
    }
}
