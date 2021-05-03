using Microsoft.EntityFrameworkCore;
using Task_1.Foundation.Entities;

namespace Task_1.Foundation.Contexts
{
    public class StudentManagementContext : DbContext, IStudentManagementContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public StudentManagementContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString, m => m.MigrationsAssembly(_migrationAssemblyName));
            }
            base.OnConfiguring(dbContextOptionsBuilder);
        }

        //Fluent API
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Make Many to Many Relationship between Student and Course
            //builder.Entity<Registration>()
            //    .HasKey(rs => new { rs.StudentId, rs.CourseId });

            //Relationship between Registration and Student
            builder.Entity<Registration>()
                .HasOne(rs => rs.Student)
                .WithMany(st => st.Registrations)
                .HasForeignKey(rs => rs.StudentId);


            //Relationship between Registration and Course
            builder.Entity<Registration>()
                .HasOne(rs => rs.Course)
                .WithMany(cr => cr.Registrations)
                .HasForeignKey(rs => rs.CourseId);

            base.OnModelCreating(builder);
        }



        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}
