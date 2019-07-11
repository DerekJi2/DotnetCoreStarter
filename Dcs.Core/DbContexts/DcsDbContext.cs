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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected void OnModelCreatingBaseEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IBaseEntity>()
                .Property(b => b.Deleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<IBaseEntity>()
                .Property(b => b.Version)
                .HasDefaultValue(1);

            modelBuilder.Entity<IBaseEntity>()
                .Property(b => b.Created)
                .HasDefaultValueSql("GETDATE()");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingBaseEntity(modelBuilder);
        }
        //Sample
        //public DbSet<BaseEntity> BaseEntity { get; set; }
    }
}
