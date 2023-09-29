using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1_U1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MiPerfil()
        {
            return View();
        }
    }
}
