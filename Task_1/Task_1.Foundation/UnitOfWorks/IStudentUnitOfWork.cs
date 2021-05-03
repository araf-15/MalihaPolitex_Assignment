using Task_1.Foundation.DataAccessLayer;
using Task_1.Foundation.Repositories;

namespace Task_1.Foundation.UnitOfWorks
{
    public interface IStudentUnitOfWork : IUnitOfWork
    {
        IStudentRepository StudentRepository { get; set; }
        IDepartmentRepository DepartmentRepository { get; set; }
    }
}
