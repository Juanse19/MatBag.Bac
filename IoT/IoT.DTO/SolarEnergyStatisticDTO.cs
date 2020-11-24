/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

namespace IoT.DTO
{
    public class SolarEnergyStatisticDTO
    {
        public string UnitOfMeasure { get; set; }
        public decimal TotalValue { get; set; }
        public decimal SolarValue { get; set; }
        public int Percent => (int)((TotalValue != 0 ? SolarValue / TotalValue : 1) * 100);
    }
}
