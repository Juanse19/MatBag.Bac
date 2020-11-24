using System;
namespace IoT.Entities.Matbag
{
    public class usp_GetTrackingWP_Result
    {
        public string airline { get; set; }
        public Nullable<int> Wake_Up { get; set; }
        public Nullable<DateTime> DateRegister { get; set; }
    }
}
