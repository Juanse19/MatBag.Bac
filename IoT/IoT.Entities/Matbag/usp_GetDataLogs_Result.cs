using System;
namespace IoT.Entities.Matbag
{
    public class usp_GetDataLogs_Result
    {
        public Nullable<DateTime> date { get; set; }
        public string level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
    }
}
