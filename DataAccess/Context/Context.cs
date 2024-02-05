using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class Context : DbContext
    {

        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(x => x.SudentId);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=root;Password=root;Host=localhost;Port=1907;Database=EntityExample_db;Pooling=true;MaxPoolSize=100;Connection Lifetime=0;");
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }



    }
}
