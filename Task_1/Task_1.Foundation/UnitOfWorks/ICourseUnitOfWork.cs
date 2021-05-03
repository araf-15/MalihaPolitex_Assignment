using Task_1.Foundation.DataAccessLayer;
using Task_1.Foundation.Repositories;

namespace Task_1.Foundation.UnitOfWorks
{
    public interface ICourseUnitOfWork : IUnitOfWork
    {
        ICourseRepository CourseRepository { get; set; }
    }
}
