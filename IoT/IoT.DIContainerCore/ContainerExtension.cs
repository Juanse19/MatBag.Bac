/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.DataAccess.EFCore;
using Common.Services;
using Common.Services.Infrastructure;
using IoT.DataAccess.EFCore;
using IoT.Entities.System;
using IoT.Services;
using IoT.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IoT.DIContainerCore
{
    public static class ContainerExtension
    {
        public static void Initialize(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<IoTDataContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IDataBaseInitializer, DataBaseInitializer>();

            services.AddTransient<IDeviceService, DeviceService>();
            services.AddTransient<IContactService, ContactService>();
            services.AddTransient<IContactPhotoRepository, ContactPhotoRepository>();
            services.AddTransient<IElectricityConsumptionAggregationService, ElectricityConsumptionAggregationService>();
            services.AddTransient<IPhoneCallService, PhoneCallService>();
            services.AddTransient<ITrafficConsumptionAggregationService, TrafficConsumptionAggregationService>();
            services.AddTransient<IUserPhotoRepository, UserPhotoRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IPhoneCallRepository, PhoneCallRepository>();
            services.AddTransient<IDeviceRepository, DeviceRepository>();
            services.AddTransient<ITrafficConsumptionAggregatedRepository, TrafficConsumptionAggregatedRepository>();
            services.AddTransient<IElectricityConsumptionAggregatedRepository, ElectricityConsumptionAggregatedRepository>();
            services.AddTransient<IDeviceParameterRepository, DeviceParameterRepository>();
            services.AddTransient<IDeviceParameterService, DeviceParameterService>();
            services.AddTransient<IUserService, UserService<User>>();
            services.AddTransient<IUserRepository<User>, UserRepository>();
            services.AddTransient<IIdentityUserRepository<User>, IdentityUserRepository>();
            services.AddTransient<IRoleRepository<Role>, RoleRepository>();
            services.AddTransient<IUserRoleRepository<UserRole>, UserRoleRepository>();
            services.AddTransient<IUserClaimRepository<UserClaim>, UserClaimRepository>();

            services.AddTransient<ISettingsService, SettingsService>();
            services.AddTransient<ISettingsRepository, SettingsRepository>();
        }
    }
}
