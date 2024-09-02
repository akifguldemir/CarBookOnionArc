using Microsoft.AspNetCore.Mvc;

namespace CarBookWebUI.Controllers
{
    public class CarPricingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Cars";
            ViewBag.v2 = "Prices";
            return View();
        }
    }
}
