using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTS_CodingTest.Models
{
    public class WTSContext : DbContext
    {
        private IConfigurationRoot _config;

        public WTSContext(IConfigurationRoot config, DbContextOptions<WTSContext> options):base(options)
        {
            _config = config;
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Employee_Works_Shift> Employee_Works_Shift { get; set; }
        public DbSet<Shifts> Shifts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:WTSContextConnection"]).EnableSensitiveDataLogging();
        }

    }
}
