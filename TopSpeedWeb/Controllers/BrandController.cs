using Microsoft.AspNetCore.Mvc;

namespace TopSpeedWeb.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
