using Task_1.Foundation.Contexts;
using Task_1.Foundation.DataAccessLayer;
using Task_1.Foundation.Entities;

namespace Task_1.Foundation.Repositories
{
    public class CourseRepository : Repository<Course, int, StudentManagementContext>, ICourseRepository
    {
        public CourseRepository(StudentManagementContext context) : base(context) { }
    }
}
