/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using IoT.DataAccess.EFCore.Configuration.System;
using IoT.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IoT.DataAccess.EFCore
{
    public class DeviceConfig : TrackableEntityConfig<Device>
    {
        public DeviceConfig() : base("Devices", item => item.DevicesCreatedBy, item => item.DevicesUpdatedBy)
        {
        }

        public override void Configure(EntityTypeBuilder<Device> builder)
        {
            base.Configure(builder);

            builder.Property(obj => obj.Name).IsRequired();
            builder.Property(obj => obj.IsOn).IsRequired();
            builder.Property(obj => obj.Type).IsRequired();

            builder.HasMany(obj => obj.Parameters)
                .WithOne(obj => obj.Device)
                .IsRequired()
                .HasForeignKey(x => x.DeviceId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
        }
    }
}
