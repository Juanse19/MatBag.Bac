/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using AutoMapper;
using IoT.DTO;
using IoT.Entities;

namespace IoT.Services.Infrastructure.MappingProfiles
{
    public class PhoneProfile : Profile
    {
        public PhoneProfile()
        {
            CreateMap<Contact, ContactDTO>().ReverseMap();
            CreateMap<PhoneCall, PhoneCallDTO>().ReverseMap();
        }
    }
}