using Microsoft.AspNetCore.Mvc;
using System;

namespace Dychar.Admin.Web.Views.Shared.Components.PageHeader
{
    public class PageHeaderViewComponent : ViewComponent
    {

        public PageHeaderViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            Tuple<string, string> message;

            if (ViewBag.PageHeader == null)
            {
                message = Tuple.Create(string.Empty, string.Empty);
            }
            else
            {
                message = ViewBag.PageHeader as Tuple<string, string>;
            }
            return View(message);
        }
    }
}
