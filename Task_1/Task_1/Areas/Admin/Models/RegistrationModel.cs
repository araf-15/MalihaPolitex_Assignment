using Autofac;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1.Foundation.Entities;
using Task_1.Foundation.Services;

namespace Task_1.Areas.Admin.Models
{
    public class RegistrationModel
    {
        private readonly IRegistrationService _registrationService;
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime EnrollDate { get; set; }
        public bool IsPaymentComplete { get; set; }




        //public IList<SelectListItem> StudentList { get; set; }
        //public IList<SelectListItem> CourseList { get; set; }

        public RegistrationModel()
        {
            _registrationService = Startup.AutofacContainer.Resolve<IRegistrationService>();
        }

        public RegistrationModel(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        public void AddRegistration()
        {
            _registrationService.MakeRegistration(new Registration
            {
                StudentId = StudentId,
                CourseId = CourseId,
                EnrollDate = EnrollDate,
                IsPaymentComplete = IsPaymentComplete
            });
        }

        public IList<SelectListItem> GetListOfStudents()
        {
            var students = new List<SelectListItem>();
            var studentList = _registrationService.GetStudents();
            students.AddRange(studentList.Select(st => new SelectListItem()
            {
                Value = st.DepartmentId.ToString(),
                Text = st.Name
            }));
            return students;
        }

        public IList<SelectListItem> GetListOfCourses()
        {
            var courses = new List<SelectListItem>();
            var courseList = _registrationService.GetCourses();
            courses.AddRange(courseList.Select(crs => new SelectListItem()
            {
                Value = crs.Id.ToString(),
                Text = crs.Title
            }));
            return courses;
        }

    }
}
