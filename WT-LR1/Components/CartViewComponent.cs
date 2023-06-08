using Microsoft.AspNetCore.Mvc;

namespace WT_LR1.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
