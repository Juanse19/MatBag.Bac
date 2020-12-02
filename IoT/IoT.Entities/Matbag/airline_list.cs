using System;
using IoT.Entities.System;
using System.Collections.Generic;

namespace IoT.Entities.Matbag
{
    public class airline_list
    {
        public long Id { get; set; }
        public string airline_name { get; set; }
        public string iata_designator { get; set; }
        public int? tree_digit_code { get; set; }
        public string icao_designator { get; set; }
        public string country_territory { get; set; }
        public int? airline_state { get; set; }
    
    }
}
 