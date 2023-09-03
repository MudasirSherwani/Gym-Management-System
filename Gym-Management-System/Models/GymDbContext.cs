using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace Gym_Management_System.Models
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<DbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => 
           
            options.UseSqlServer(@"Data Source=DESKTOP-5NQVVIH\SQLEXPRESS;Initial Catalog=GymDb;User Id=sa;Password=sa;TrustServerCertificate=True");

    }
}
