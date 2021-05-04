using System;
using Task_1.Foundation.Contexts;
using Task_1.Foundation.DataAccessLayer;
using Task_1.Foundation.Repositories;

namespace Task_1.Foundation.UnitOfWorks
{
    public class StudentUnitOfWork : UnitOfWork, IStudentUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public IDepartmentRepository DepartmentRepository { get; set; }

        public StudentUnitOfWork(StudentManagementContext context,
            IStudentRepository studentRepository,
            IDepartmentRepository departmentRepository) : base(context)
        {
            StudentRepository = studentRepository;
            DepartmentRepository = departmentRepository;
        }
    }
}
