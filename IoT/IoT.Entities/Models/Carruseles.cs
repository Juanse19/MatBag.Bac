using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class Carruseles
    {
        public int Id { get; set; }
        public int? Carrusel { get; set; }
        public int? IdAirlineList { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
