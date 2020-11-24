/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.DataAccess.EFCore;
using Common.DataAccess.EFCore.Configuration;
using IoT.Entities;
using IoT.Entities.System;
using Microsoft.EntityFrameworkCore;

namespace IoT.DataAccess.EFCore
{
    public class IoTDataContext : CommonDataContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<PhoneCall> Calls { get; set; }
        public DbSet<TrafficConsumption> TrafficConsumptions { get; set; }
        public DbSet<ElectricityConsumption> ElectricityConsumptions { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceParameter> DeviceParameters { get; set; }
        public DbSet<ContactPhoto> ContactPhotos { get; set; }

        public IoTDataContext(DbContextOptions<IoTDataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.ApplyConfiguration(new UserRoleConfig());
            modelBuilder.ApplyConfiguration(new UserClaimConfig());
            modelBuilder.ApplyConfiguration(new SettingsConfig());

            modelBuilder.ApplyConfiguration(new DeviceConfig());
            modelBuilder.ApplyConfiguration(new DeviceParameterConfig());
            modelBuilder.ApplyConfiguration(new ContactConfig());
            modelBuilder.ApplyConfiguration(new PhoneCallConfig());
            modelBuilder.ApplyConfiguration(new ElectricityConsumptionConfig());
            modelBuilder.ApplyConfiguration(new TrafficConsumptionConfig());
            modelBuilder.ApplyConfiguration(new ContactPhotoConfig());

            modelBuilder.HasDefaultSchema("iot_core");
        }
    }
}
