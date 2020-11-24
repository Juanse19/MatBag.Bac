/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using System;

namespace IoT.DTO
{
    public class PhoneCallDTO
    {
        public int Id { get; set; }
        public ContactDTO Contact { get; set; }
        public DateTime DateOfCall { get; set; }
    }
}
