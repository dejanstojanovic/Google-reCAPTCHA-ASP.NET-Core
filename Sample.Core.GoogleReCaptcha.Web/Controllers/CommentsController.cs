using Microsoft.AspNetCore.Mvc;
using Sample.Core.GoogleReCaptcha.Web.Models;

namespace Sample.Core.GoogleReCaptcha.Web.Controllers
{
    public class CommentsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Comment comment)
        {
            if (!ModelState.IsValid)
            {
                //TODO: Comment saving logic here
                return View();
            }
            return View();
        }
    }
}