using Microsoft.AspNetCore.Mvc;

namespace CarBookWebUI.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Rent A Car";
            ViewBag.v2 = "Rent A Car Form";
            return View();
        }
    }
}
