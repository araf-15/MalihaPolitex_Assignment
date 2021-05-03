using Task_1.Foundation.Contexts;
using Task_1.Foundation.DataAccessLayer;
using Task_1.Foundation.Repositories;

namespace Task_1.Foundation.UnitOfWorks
{
    public class RegistrationUnitOfWork : UnitOfWork, IRegistrationUnitOfWork
    {
        public IRegistrationRepository RegistrationRepository { get; set; }
        public IStudentRepository StudentRepository { get; set; }
        public ICourseRepository CourseRepository { get; set; }

        public RegistrationUnitOfWork(StudentManagementContext context,
            IRegistrationRepository registrationRepository,
            IStudentRepository studentRepository,
            ICourseRepository courseRepository)
            : base(context)
        {
            RegistrationRepository = registrationRepository;
            StudentRepository = studentRepository;
            CourseRepository = courseRepository;
        }
    }
}
