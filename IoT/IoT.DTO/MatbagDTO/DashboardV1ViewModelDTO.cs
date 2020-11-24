using System;
namespace IoT.DTO.MatbagDTO
{
    public class DashboardV1ViewModelDTO
    {
        public class AirlineData
        {
            public int Id { get; set; }
            public string Airline_Name { get; set; }
            public string Cod_Airline { get; set; }
        }

        public class Carrusel
        {
            public int IdAirline { get; set; }
            public string Airline_Name { get; set; }
            public string Cod_Airline { get; set; }
            public int carrusel { get; set; }
        }
    }
}
