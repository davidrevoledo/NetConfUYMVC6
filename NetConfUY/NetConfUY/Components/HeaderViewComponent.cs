using Microsoft.AspNetCore.Mvc;

namespace NetConfUY.Components
{
    [ViewComponent(Name = "Header")]
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}