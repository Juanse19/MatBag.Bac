/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Entities;
using System.Collections.Generic;

namespace IoT.Entities
{
    public class Contact : BaseTrackableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public int NumberType { get; set; }

        public virtual ContactPhoto Photo { get; set; }

        public virtual ICollection<PhoneCall> Calls { get; set; }
    }
}
