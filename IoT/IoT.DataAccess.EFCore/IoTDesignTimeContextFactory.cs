/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace IoT.DataAccess.EFCore
{
    class IoTDesignTimeContextFactory : IDesignTimeDbContextFactory<IoTDataContext>
    {
        // this class used by EF tool for creating migrations via Package Manager Console
        // Add-Migration MigrationName -Project IoT.DataAccess.EFCore -StartupProject IoT.DataAccess.EFCore
        // or in case of console building: dotnet ef migrations add MigrationName --project IoT.DataAccess.EFCore --startup-project IoT.DataAccess.EFCore
        // after migration is added, please add migrationBuilder.Sql(SeedData.Initial()); to the end of seed method for initial data
        public IoTDesignTimeContextFactory() {}

        public IoTDataContext CreateDbContext(string[] args)
        {
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../IoT.WebApiCore"))
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .Build();

            var connectionString = configuration.GetConnectionString("localDb");

            var builder = new DbContextOptionsBuilder<IoTDataContext>();
            builder.UseSqlServer(connectionString);

            return new IoTDataContext(builder.Options);
        }
    }
}
