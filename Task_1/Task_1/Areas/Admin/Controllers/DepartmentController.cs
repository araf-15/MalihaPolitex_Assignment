using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Task_1.Areas.Admin.Models;

namespace Task_1.Areas.Admin.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(ILogger<DepartmentController> logger)
        {
            _logger = logger;
        }

        [Area("Admin")]
        public IActionResult Department()
        {
            var model = Startup.AutofacContainer.Resolve<DepartmentModel>();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken, Area("Admin")]
        public IActionResult Department(DepartmentModel departmentModel)
        {
            try
            {
                departmentModel.Add();
            }
            catch (Exception e)
            {
                _logger.LogError("Failed to Add Department: " + e);
            }
            return View(departmentModel);
        }
    }
}
