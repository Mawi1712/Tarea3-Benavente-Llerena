using Microsoft.AspNetCore.Mvc;

namespace Veterinaria.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
