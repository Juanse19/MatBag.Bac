﻿/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Services.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Common.WebApiCore
{
    public static class BaseDependenciesConfig
    {
        public static void ConfigureDependencies(IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            services.AddScoped<ICurrentContextProvider, CurrentContextProvider>();

            services.AddSingleton<JwtManager>();
        }
    }
}
