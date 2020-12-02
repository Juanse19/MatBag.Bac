using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class airline_list
    {
        public long Id { get; set; }
        public string AirlineName { get; set; }
        public string IataDesignator { get; set; }
        public int? TreeDigitCode { get; set; }
        public string IcaoDesignator { get; set; }
        public string CountryTerritory { get; set; }
        public int? AirlineState { get; set; }
    }
}
