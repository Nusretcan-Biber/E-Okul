using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class MasterContext : DbContext
    {
        public MasterContext()
        {
            
        }
        public MasterContext(DbContextOptions<MasterContext> options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(x => x.SudentId);
            modelBuilder.Entity<Note>().HasKey(x => x.NotesId);
            modelBuilder.Entity<Teacher>().HasKey(x => x.teacherId);
            modelBuilder.Entity<Lesson>().HasKey(x => x.lessonId);
            
            modelBuilder.Entity<StudentLesson>().HasKey( x => new {x.SId, x.LId});
            modelBuilder.Entity<TeacherLesson>().HasKey(x => new {x.TId, x.LId});

            modelBuilder.Entity<Lesson>().HasOne(x => x.Notes).WithOne(x => x.Lesson).HasForeignKey<Note>(x => x.NotesId);

            modelBuilder.Entity<Note>().HasOne(x => x.Student).WithMany(x => x.Notes);

            modelBuilder.Entity<StudentLesson>().HasOne(x => x.Student).WithMany(x => x.Lessons).HasForeignKey(x => x.SId);
            modelBuilder.Entity<StudentLesson>().HasOne(x => x.Lesson).WithMany(x => x.Students).HasForeignKey(x => x.LId);
           
            modelBuilder.Entity<TeacherLesson>().HasOne(x => x.Lesson).WithMany(x => x.Teachers).HasForeignKey(x => x.LId);
            modelBuilder.Entity<TeacherLesson>().HasOne(x => x.Teacher).WithMany(x => x.lessons).HasForeignKey(x => x.TId);



        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRES_URI"));
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }



    }
}
