using Microsoft.AspNetCore.Mvc;

namespace CarBookWebUI.Controllers
{
    public class RentACarListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
