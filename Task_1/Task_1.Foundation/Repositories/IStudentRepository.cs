using Task_1.Foundation.Contexts;
using Task_1.Foundation.DataAccessLayer;
using Task_1.Foundation.Entities;

namespace Task_1.Foundation.Repositories
{
    public interface IStudentRepository : IRepository<Student, int, StudentManagementContext>
    {
    }
}
