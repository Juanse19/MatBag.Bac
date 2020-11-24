using System;
using System.Collections.Generic;

namespace IoT.DTO.MatbagDTO
{
    public class airline_listDTO
    {
        public long Id { get; set; }
        public string airline_name { get; set; }
        public string iata_designator { get; set; }
        public Nullable<int> tree_digit_code { get; set; }
        public string icao_designator { get; set; }
        public string country_territory { get; set; }
        public Nullable<int> airline_state { get; set; }
    }
}
