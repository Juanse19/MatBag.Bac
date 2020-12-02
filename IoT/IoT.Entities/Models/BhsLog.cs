using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class BhsLog
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
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
