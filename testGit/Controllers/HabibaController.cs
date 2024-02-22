using Microsoft.AspNetCore.Mvc;

namespace testGit.Controllers
{
    public class HabibaController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is Habiba");
        }
    }
}
