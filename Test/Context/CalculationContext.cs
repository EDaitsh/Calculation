using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Context
{
 

    public class CalculationContext
        : DbContext
    {
        public CalculationContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ScalarInt>().HasNoKey();
            modelBuilder.Entity<MinMaxAvgScalar>().HasNoKey();
        }

        public DbSet<CalculationHistory> CalculationHistories { get; set; }
        public DbSet<ScalarInt> ScalarIntValue { get; set; }
    }
}
