using Microsoft.AspNetCore.Mvc;
using Sample.Core.GoogleReCaptcha.Web.Models;

namespace Sample.Core.GoogleReCaptcha.Web.Controllers
{
    public class CommentsController : Controller
    {
        [HttpGet]
        public IActionResult Invisible()
        {
            return View("Invisible");
        }

        [HttpPost]
        public IActionResult Invisible(Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return View("Invisible",comment);
            }
            //TODO: Comment saving logic here
            return View("Invisible");
        }


        [HttpGet]
        public IActionResult NotRobot()
        {
            return View("NotRobot");
        }
        [HttpPost]
        public IActionResult NotRobot(Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return View("NotRobot", comment);
            }
            //TODO: Comment saving logic here
            return View("NotRobot");
        }

    }
}