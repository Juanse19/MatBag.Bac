﻿/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.DataAccess.EFCore.Configuration.System;
using IoT.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IoT.DataAccess.EFCore
{
    public class PhoneCallConfig : BaseEntityConfig<PhoneCall>
    {
        public PhoneCallConfig() : base("PhoneCalls")
        {
        }

        public override void Configure(EntityTypeBuilder<PhoneCall> builder)
        {
            base.Configure(builder);

            builder.Property(obj => obj.DateOfCall).IsRequired();
            builder.Property(obj => obj.ContactId).IsRequired();

            builder.HasOne(obj => obj.Contact)
                .WithMany(obj => obj.Calls)
                .HasForeignKey(obj => obj.ContactId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
        }
    }
}