using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Task_1.Areas.Admin.Models;

namespace Task_1.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [Area("Admin")]
        public IActionResult Student()
        {
            var model = Startup.AutofacContainer.Resolve<StudentModel>();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken, Area("Admin")]
        public IActionResult Student(StudentModel studentModel)
        {
            try
            {
                studentModel.Add();
            }
            catch (Exception e)
            {
                _logger.LogError("Failed Add a Student " + e);
            }
            return View(studentModel);
        }
    }
}
