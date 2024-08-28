using Microsoft.AspNetCore.Mvc;

namespace CarBookWebUI.ViewComponents.RentACarFilterComponents
{
    public class _RentACarFilterComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
