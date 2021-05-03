using Task_1.Foundation.Entities;
using Task_1.Foundation.DataAccessLayer;
using Task_1.Foundation.Contexts;

namespace Task_1.Foundation.Repositories
{
    public interface ICourseRepository : IRepository<Course, int, StudentManagementContext>
    {
        
    }
}
