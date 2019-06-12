using Microsoft.AspNetCore.Mvc;

namespace Dychar.Admin.Web.Views.Shared.Components.MenuUser
{
    public class MenuUserViewComponent : ViewComponent
    {

        public MenuUserViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            return View();
        }
    }
}
