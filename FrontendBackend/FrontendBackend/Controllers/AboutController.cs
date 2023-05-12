using Microsoft.AspNetCore.Mvc;

namespace FrontendBackend.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
