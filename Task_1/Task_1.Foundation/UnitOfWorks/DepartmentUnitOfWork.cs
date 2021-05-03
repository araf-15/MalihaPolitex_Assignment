using Task_1.Foundation.Contexts;
using Task_1.Foundation.DataAccessLayer;
using Task_1.Foundation.Repositories;

namespace Task_1.Foundation.UnitOfWorks
{
    public class DepartmentUnitOfWork : UnitOfWork, IDepartmentUnitOfWork
    {
        public IDepartmentRepository DepartmentRepository { get; set; }

        public DepartmentUnitOfWork(StudentManagementContext context,
        IDepartmentRepository departmentRepository) : base(context)
        {
            DepartmentRepository = departmentRepository;
        }
    }
}
