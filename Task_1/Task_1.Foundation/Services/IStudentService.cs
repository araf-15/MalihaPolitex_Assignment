using System.Collections.Generic;
using Task_1.Foundation.Entities;

namespace Task_1.Foundation.Services
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        IList<Department> GetDepartments();
    }
}
