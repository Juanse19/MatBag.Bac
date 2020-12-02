/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.DataAccess.EFCore;
using Common.DataAccess.EFCore.Configuration;
using IoT.Entities;
using IoT.Entities.Models;
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

        public virtual DbSet<airline_list> AirlineList { get; set; }
        public virtual DbSet<BhsAlarms> bhs_alarms { get; set; }
        public virtual DbSet<BhsAtr> BhsAtr { get; set; }
        public DbSet<BhsBpi> BhsBpi { get; set; }
        public DbSet<BhsConveyorInfo> BhsConveyorInfo { get; set; }
        public DbSet<BhsConveyorState> BhsConveyorState { get; set; }
        public DbSet<BhsConveyors> BhsConveyors { get; set; }
        public DbSet<BhsCounters> BhsCounters { get; set; }
        public DbSet<BhsDashboardV2> BhsDashboardV2 { get; set; }
        public DbSet<BhsLog> BhsLog { get; set; }
        public DbSet<BhsVariableState> BhsVariableState { get; set; }
        public DbSet<Carruseles> Carruseles { get; set; }

        public IoTDataContext(DbContextOptions<IoTDataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=10.100.22.48;Database=IotMat;Trusted_Connection=True;");
            }
        }

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
