using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShopSolution.Data.EF
{
    public class ShopDBContextFactory : IDesignTimeDbContextFactory<ShopDBContext>
    {
        public ShopDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ShopSolutionDB");
            var optionsBuilder = new DbContextOptionsBuilder<ShopDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopDBContext(optionsBuilder.Options);
        }
    }
}
