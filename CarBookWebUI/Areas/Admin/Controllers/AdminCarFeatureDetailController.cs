using Microsoft.AspNetCore.Mvc;

namespace CarBookWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminCarFeatureDetail")]
    public class AdminCarFeatureDetailController : Controller
    {
        [Route("Index/{id}")]
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
