/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.DataAccess.EFCore.Configuration.System;
using IoT.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IoT.DataAccess.EFCore
{
    public class TrafficConsumptionConfig : BaseEntityConfig<TrafficConsumption>
    {
        public TrafficConsumptionConfig() : base("TrafficConsumptions")
        {
        }

        public override void Configure(EntityTypeBuilder<TrafficConsumption> builder)
        {
            base.Configure(builder);

            builder.Property(obj => obj.Date).IsRequired();
            builder.Property(obj => obj.ConsumedValue).IsRequired();
        }
    }
}
