/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Entities;
using System.Collections.Generic;

namespace IoT.Entities.System
{
    public class User : BaseUser
    {
        public virtual List<Device> DevicesCreatedBy { get; set; }
        public virtual List<Device> DevicesUpdatedBy { get; set; }

        public virtual List<DeviceParameter> ParametersCreatedBy { get; set; }
        public virtual List<DeviceParameter> ParametersUpdatedBy { get; set; }
    }
}
