using Knights_of_Columbus_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Knights_of_Columbus_Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Knights ins)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Library() 
        {
            return View();
        }
    }

}
