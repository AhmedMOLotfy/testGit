using Microsoft.AspNetCore.Mvc;

namespace testGit.Controllers
{
    public class AyaController : Controller
    {
        public IActionResult Index()
        {
            return Content("Aya");
        }
    }
}
