using Microsoft.AspNetCore.Mvc;

namespace testGit.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return Content("I am ahmed");
        }
    }
}
