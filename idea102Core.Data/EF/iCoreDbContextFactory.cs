using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace idea102Core.Data.EF
{
    public class iCoreDbContextFactory : IDesignTimeDbContextFactory<iCoreDbContext>
    {
        public iCoreDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("eShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<iCoreDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new iCoreDbContext(optionsBuilder.Options);
        }
    }
}
