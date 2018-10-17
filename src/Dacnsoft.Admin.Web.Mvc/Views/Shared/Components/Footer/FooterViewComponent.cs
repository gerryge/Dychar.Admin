using Microsoft.AspNetCore.Mvc;

namespace Dacnsoft.Admin.Web.Views.Shared.Components.Footer
{
    public class FooterViewComponent : ViewComponent
    {

        public FooterViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            return View();
        }
    }
}
