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
        IStudentRepository IStudentUnitOfWork.StudentRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IDepartmentRepository IStudentUnitOfWork.DepartmentRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public StudentUnitOfWork(StudentManagementContext context,
            IStudentRepository studentRepository,
            IDepartmentRepository departmentRepository) : base(context)
        {
            StudentRepository = studentRepository;
            DepartmentRepository = departmentRepository;
        }
    }
}
