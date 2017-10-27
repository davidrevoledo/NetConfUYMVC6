using Microsoft.AspNetCore.Mvc;
using NetConfUY.Models;

namespace NetConfUY.Components
{
    [ViewComponent(Name = "PriceComponent")]
    public class PriceItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(bool bestOption, int price)
        {
            return View(new PriceItemModel
            {
                Class = bestOption
                    ? "best-option"
                    : string.Empty,

                Price = price
            });
        }
    }
}