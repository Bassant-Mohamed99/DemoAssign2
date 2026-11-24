using DemoAssign2.Enteties;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DemoAssign2.Context
{
    public class GymDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymDbGo1;Trusted_Connection=True; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberShip> Memberships { get; set; }
        public DbSet<Plans> Plans { get; set; }
    }
}
