using System.Collections.Generic;
using Task_1.Foundation.Entities;
using Task_1.Foundation.UnitOfWorks;

namespace Task_1.Foundation.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRegistrationUnitOfWork _registrationUnitOfWork;

        public RegistrationService(IRegistrationUnitOfWork registrationUnitOfWork)
        {
            _registrationUnitOfWork = registrationUnitOfWork;
        }


        public void MakeRegistration(Registration registration)
        {
            _registrationUnitOfWork.RegistrationRepository.Add(registration);
            _registrationUnitOfWork.Save();
        }

        public IList<Student> GetStudents()
        {
            IList<Student> students = _registrationUnitOfWork.StudentRepository.GetAll();
            return students;
        }

        public IList<Course> GetCourses()
        {
            IList<Course> courses = _registrationUnitOfWork.CourseRepository.GetAll();
            return courses;
        }
    }
}
