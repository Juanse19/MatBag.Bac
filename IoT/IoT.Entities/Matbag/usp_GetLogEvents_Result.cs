using System;
namespace IoT.Entities.Matbag
{
    public class usp_GetLogEvents_Result
    {
        public int Id { get; set; }
        public Nullable<DateTime> Date { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
    }
}
