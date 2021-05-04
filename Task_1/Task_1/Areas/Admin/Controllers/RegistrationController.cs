using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Task_1.Areas.Admin.Models;

namespace Task_1.Areas.Admin.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ILogger<RegistrationController> _logger;

        public RegistrationController(ILogger<RegistrationController> logger)
        {
            _logger = logger;
        }

        [Area("Admin")]
        public IActionResult Registration()
        {
            var model = Startup.AutofacContainer.Resolve<RegistrationModel>();
            return View(model);
        }


        [HttpPost, ValidateAntiForgeryToken, Area("Admin")]
        public IActionResult Registration(RegistrationModel registrationModel)
        {
            try
            {
                registrationModel.AddRegistration();
            }
            catch (Exception e)
            {
                _logger.LogError("Failed to Make a Registration " + e);
            }
            return View(registrationModel);
        }
    }
}
