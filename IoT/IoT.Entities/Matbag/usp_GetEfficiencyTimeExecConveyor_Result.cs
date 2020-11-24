using System;
namespace IoT.Entities.Matbag
{
    public class usp_GetEfficiencyTimeExecConveyor_Result
    {
        public string Conveyor { get; set; }
        public Nullable<DateTime> Fecha_Hora_Activ { get; set; }
        public Nullable<int> TiempoEncendido { get; set; }
        public Nullable<int> tiempo_Paro { get; set; }
    }
}
