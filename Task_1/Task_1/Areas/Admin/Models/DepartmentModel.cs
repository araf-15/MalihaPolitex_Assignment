using Autofac;
using System.ComponentModel.DataAnnotations;
using Task_1.Foundation.Entities;
using Task_1.Foundation.Services;

namespace Task_1.Areas.Admin.Models
{
    public class DepartmentModel
    {
        private readonly IDepartmentService _departmentService;

        [Required]
        public string DepartmentName { get; set; }

        public DepartmentModel()
        {
            _departmentService = Startup.AutofacContainer.Resolve<IDepartmentService>();
        }

        public DepartmentModel(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public void Add()
        {
            _departmentService.AddDepartment(new Department
            {
                DepartmentName = DepartmentName
            });
        }
    }
}
