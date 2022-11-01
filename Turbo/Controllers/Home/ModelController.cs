using Microsoft.AspNetCore.Mvc;

namespace Turbo.Controllers.Home
{
    public class ModelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
