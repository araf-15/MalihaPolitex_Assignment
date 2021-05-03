using System.Collections.Generic;
using Task_1.Foundation.Entities;

namespace Task_1.Foundation.Services
{
    public interface IRegistrationService
    {
        void MakeRegistration(Registration registration);
        IList<Student> GetStudents();
        IList<Course> GetCourses();
    }
}
