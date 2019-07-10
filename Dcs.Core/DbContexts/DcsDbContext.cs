using Dcs.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.DbContexts
{
    public class DcsDbContext : DbContext
    {
        private readonly string connectionString;

        public DcsDbContext(IConfiguration configuration) : base()
        {
            this.connectionString = configuration.GetConnectionString("Default");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        //Sample
        //public DbSet<BaseEntity> BaseEntity { get; set; }
    }
}
