using Microsoft.AspNetCore.Mvc;

namespace Turbo.Controllers.Home
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
