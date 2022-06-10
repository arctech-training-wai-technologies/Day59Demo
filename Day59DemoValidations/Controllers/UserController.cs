using Day59DemoValidations.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day59DemoValidations.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            // Save to database
            return View();
        }
    }
}
