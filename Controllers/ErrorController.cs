using Microsoft.AspNetCore.Mvc;

namespace IS4439_Project_1.Controllers;

// Creating Error 404 routing for the project
public class ErrorController : Controller
{
      [Route("Error/404")]
        public IActionResult NotFoundError()
        {
            return View("404");
        }

}
