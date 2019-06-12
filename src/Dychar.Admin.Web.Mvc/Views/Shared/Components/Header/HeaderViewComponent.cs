using Microsoft.AspNetCore.Mvc;

namespace Dychar.Admin.Web.Views.Shared.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {

        public HeaderViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            return View();
        }
    }
}
