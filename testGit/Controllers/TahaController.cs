using Microsoft.AspNetCore.Mvc;

namespace testGit.Controllers
{
    public class TahaController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello Taha");
        }
    }
}
