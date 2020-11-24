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
    public class DeviceParameterConfig : TrackableEntityConfig<DeviceParameter>
    {
        public DeviceParameterConfig() : base("DeviceParameters", item => item.ParametersCreatedBy, item => item.ParametersUpdatedBy)
        {
        }

        public override void Configure(EntityTypeBuilder<DeviceParameter> builder)
        {
            base.Configure(builder);

            builder.Property(obj => obj.Name).IsRequired();
            builder.Property(obj => obj.Value).IsRequired();
        }
    }
}