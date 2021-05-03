using System.Collections.Generic;
using Task_1.Foundation.Entities;
using Task_1.Foundation.UnitOfWorks;

namespace Task_1.Foundation.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentUnitOfWork _studentUnitOfWork;

        public StudentService(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork;
        }

        public void AddStudent(Student student)
        {
            _studentUnitOfWork.StudentRepository.Add(student);
            _studentUnitOfWork.Save();
        }

        public IList<Department> GetDepartments()
        {
            IList<Department> departments = _studentUnitOfWork.DepartmentRepository.GetAll();
            return departments;
        }
    }
}
