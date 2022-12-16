using Microsoft.AspNetCore.Mvc;

namespace webApplication_prova1.Controllers
{
    public class CustomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomPage()
        {
            return View();
        }
    }
}
