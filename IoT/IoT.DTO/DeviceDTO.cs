/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using System.Collections.Generic;

namespace IoT.DTO
{
    public class DeviceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOn { get; set; }
        public DeviceTypeEnum Type { get; set; }
        public IEnumerable<DeviceParameterDTO> Parameters { get; set; }
    }
}
