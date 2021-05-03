using Microsoft.EntityFrameworkCore;
using System;
using Task_1.Foundation.Entities;

namespace Task_1.Foundation.Contexts
{
    public interface IStudentManagementContext
    {
        DbSet<Department> Departments { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Registration> Registrations { get; set; }
    }
}
