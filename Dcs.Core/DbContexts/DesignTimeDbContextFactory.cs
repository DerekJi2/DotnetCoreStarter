using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Dcs.Core.DbContexts
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DcsDbContext>
    {
        public DcsDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<DcsDbContext>();
            var connectionString = configuration.GetConnectionString("Default");

            builder.UseSqlServer(connectionString);

            return new DcsDbContext(builder.Options, connectionString);
        }
    }
}
