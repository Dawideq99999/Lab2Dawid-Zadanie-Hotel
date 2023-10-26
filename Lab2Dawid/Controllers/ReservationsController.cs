using Microsoft.AspNetCore.Mvc;

namespace Lab2Dawid.Controllers
{
    
    public class ReservationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
