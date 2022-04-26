using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RabbitMq.Core.Common.Configurations;
using RabbitMq.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMq.Core.Domain
{
    public class RabbitDbContext : DbContext
    {
        public virtual DbSet<Branch> branches { get; set; }
        public virtual DbSet<Dealer> dealers { get; set; }
        public virtual DbSet<Report> reports { get; set; }

        private readonly DatabaseSettings _databaseSettings;
        public RabbitDbContext(DatabaseSettings databaseSettings)
        {
            _databaseSettings = databaseSettings;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
              .UseMySql(_databaseSettings.ConnectionString)
              .UseLoggerFactory(LoggerFactory.Create(b => b
                  .AddFilter(level => level > Microsoft.Extensions.Logging.LogLevel.Information)))
              .EnableSensitiveDataLogging()
              .EnableDetailedErrors();
        }
    }
}
