/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Entities;
using System;

namespace IoT.Entities
{
    public class PhoneCall : BaseEntity
    {
        public DateTime DateOfCall { get; set; }
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
