using Microsoft.AspNetCore.Mvc;
using Turbo.Models;

namespace Turbo.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Brend brend = new Brend
            {
                Id = 1,
                Name = "BMW"
            };

            return View(brend);
        }
    }
}
