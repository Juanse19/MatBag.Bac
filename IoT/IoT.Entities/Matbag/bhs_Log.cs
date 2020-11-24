using System;
namespace IoT.Entities.Matbag
{
    public class bhs_Log
    {
        public int ID { get; set; }
        public Nullable<DateTime> Date { get; set; }
        public string Thread { get; set; }
        public string Context { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Method { get; set; }
        public string Parameters { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string ExecutionTime { get; set; }
        public string UserName { get; set; }
        public string Module { get; set; }
    }
}
