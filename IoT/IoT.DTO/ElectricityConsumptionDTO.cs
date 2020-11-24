/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

namespace IoT.DTO
{
    public class ElectricityConsumptionDTO
    {
        public string Month { get; set; }
        public int ConsumedValue { get; set; }
        public int SpentMoneyValue { get; set; }
        public double Trend { get; set; }
    }
}
