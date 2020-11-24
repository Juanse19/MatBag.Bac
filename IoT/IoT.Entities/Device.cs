/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using IoT.Entities.System;
using System.Collections.Generic;

namespace IoT.Entities
{
    public class Device : TrackableEntity
    {
        public string Name { get; set; }
        public bool IsOn { get; set; }
        public int Type { get; set; }

        public virtual ICollection<DeviceParameter> Parameters { get; set; }
    }
}
