using Microsoft.EntityFrameworkCore;
using corusesStduentRelation.modles;

namespace corusesStduentRelation.Database
{
    public class AppdataBase : DbContext
    {
        public AppdataBase(DbContextOptions<AppdataBase> options) : base(options) { }
        // form this part down it what AI works 
        // I understand that we have to override a method but because the lack of knowldge of the class i can't do it by my slef :(

        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<StudentCours> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCours>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCours>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCours>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);
        }
    }
}