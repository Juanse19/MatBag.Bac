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
    public class ElectricityConsumptionConfig : BaseEntityConfig<ElectricityConsumption>
    {
        public ElectricityConsumptionConfig() : base("ElectricityConsumptions")
        {
        }

        public override void Configure(EntityTypeBuilder<ElectricityConsumption> builder)
        {
            base.Configure(builder);

            builder.Property(obj => obj.Date).IsRequired();
            builder.Property(obj => obj.ConsumedValue).IsRequired();
            builder.Property(obj => obj.SpentMoneyValue).IsRequired();
            builder.Property(obj => obj.Type).IsRequired();
        }
    }
}
