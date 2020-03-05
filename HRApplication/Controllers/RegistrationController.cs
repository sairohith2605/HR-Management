using HRApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRApplication.Controllers
{
    [Route("")]
    [Route("hr/registration")]
    public class RegistrationController : Controller
    {
        [HttpPost("new")]
        public IActionResult Register([Bind("ResourceName, Age, Department, Position, JoiningDate, Gender, HighestQualifications")] HumanResource newResource)
        {
            return RedirectToAction("ShowDetails", routeValues: newResource);
        }

        [HttpGet("details")]
        public IActionResult ShowDetails(HumanResource resourceDetails)
        {
            return View(viewName: "ResourceDetails", model: resourceDetails);
        }


        public IActionResult Index()
        {
            return View(viewName: "Form");
        }
    }
}