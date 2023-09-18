
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GymMGT.Models
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
        {
            //options.UseSqlServer(@"Data Source=DESKTOP-OS9K22T;Initial Catalog=EFCMigrationDemo;User Id=sa;Password=123;TrustServerCertificate=True");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>

            options.UseSqlServer(@"Data Source=DESKTOP-OS9K22T;Initial Catalog=GymDb;User Id=sa;Password=123;TrustServerCertificate=True");

        public DbSet<GymTrainee> Trainees { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<TrainingLevel> TrainingLevels { get; set; }
        public DbSet<MonthlyFeeVoucher> MonthlyFeeVouchers { get; set; }
        public DbSet<GymTrainee_result> GymTrainee_result { get; set; }
                    
            }
}
