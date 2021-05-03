using Task_1.Foundation.Contexts;
using Task_1.Foundation.DataAccessLayer;
using Task_1.Foundation.Repositories;

namespace Task_1.Foundation.UnitOfWorks
{
    public class CourseUnitOfWork : UnitOfWork, ICourseUnitOfWork
    {
        public ICourseRepository CourseRepository { get; set; }

        public CourseUnitOfWork(StudentManagementContext context,
            ICourseRepository courseRepository) : base(context)
        {
            CourseRepository = courseRepository;
        }
    }
}
