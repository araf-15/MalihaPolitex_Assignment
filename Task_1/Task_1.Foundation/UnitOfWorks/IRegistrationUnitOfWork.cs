using Task_1.Foundation.DataAccessLayer;
using Task_1.Foundation.Repositories;

namespace Task_1.Foundation.UnitOfWorks
{
    public interface IRegistrationUnitOfWork : IUnitOfWork
    {
        IRegistrationRepository RegistrationRepository { get; set; }
        IStudentRepository StudentRepository { get; set; }
        ICourseRepository CourseRepository { get; set; }
    }
}
