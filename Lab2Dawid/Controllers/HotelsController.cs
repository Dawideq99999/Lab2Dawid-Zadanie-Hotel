using Microsoft.AspNetCore.Mvc;

namespace Lab2Dawid.Controllers
{
   
    public class HotelsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reservation()
        {
            return View();
        }

    }
}
