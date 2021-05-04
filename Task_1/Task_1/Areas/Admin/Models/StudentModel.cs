using Autofac;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Task_1.Foundation.Entities;
using Task_1.Foundation.Services;

namespace Task_1.Areas.Admin.Models
{
    public class StudentModel
    {
        private readonly IStudentService _studentService;

        [Required]
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }

        public StudentModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }

        public StudentModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void Add()
        {
            _studentService.AddStudent(new Student
            {
                Name = Name,
                DepartmentId = DepartmentId,
                DateOfBirth = DateOfBirth
            });
        }

        public IList<SelectListItem> GetListOfDepartments()
        {
            var departments = new List<SelectListItem>();
            var departmentList = _studentService.GetDepartments();
            departments.AddRange(departmentList.Select(dpt => new SelectListItem()
            {
                Value = dpt.Id.ToString(),
                Text = "ID: " + dpt.Id + " Name: " + dpt.DepartmentName
            }));
            return departments;
        }
    }
}
