using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Task_1.Areas.Admin.Models;

namespace Task_1.Areas.Admin.Controllers
{
    public class CourseController : Controller
    {
        private readonly ILogger<CourseController> _logger;

        public CourseController(ILogger<CourseController> logger)
        {
            _logger = logger;
        }

        [Area("Admin")]
        public IActionResult Course()
        {
            var model = Startup.AutofacContainer.Resolve<CourseModel>();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken, Area("Admin")]
        public IActionResult Course(CourseModel courseModel)
        {
            try
            {
                courseModel.Add();
            }
            catch (Exception e)
            {
                _logger.LogError("Failed to Add a Course " + e);
            }
            return View(courseModel);
        }
    }
}
