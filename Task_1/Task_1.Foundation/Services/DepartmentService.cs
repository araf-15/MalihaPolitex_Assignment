using Task_1.Foundation.Entities;
using Task_1.Foundation.UnitOfWorks;

namespace Task_1.Foundation.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentUnitOfWork _departmentUnitOfWork;

        public DepartmentService(IDepartmentUnitOfWork departmentUnitOfWork)
        {
            _departmentUnitOfWork = departmentUnitOfWork;
        }
        public void AddDepartment(Department department)
        {
            _departmentUnitOfWork.DepartmentRepository.Add(department);
            _departmentUnitOfWork.Save();
        }
    }
}
