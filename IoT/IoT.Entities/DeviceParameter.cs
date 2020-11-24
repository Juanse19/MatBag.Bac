/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using IoT.Entities.System;

namespace IoT.Entities
{
    public class DeviceParameter : TrackableEntity
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public int DeviceId { get; set; }
        public virtual Device Device { get; set; }
    }
}
