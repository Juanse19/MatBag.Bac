/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using System.Collections.Generic;

namespace IoT.DTO
{
    public class ElectricityConsumptionByYearDTO
    {
        public int Year { get; set; }
        public IEnumerable<ElectricityConsumptionDTO> Data { get; set; }
        public string Currency { get; set; } = "USD";
        public string UnitOfMeasure { get; set; } = "kWh";
    }
}
