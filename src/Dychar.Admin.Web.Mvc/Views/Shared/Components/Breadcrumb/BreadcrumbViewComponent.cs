using Dychar.Admin.Web.Models.Common.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dychar.Admin.Web.Views.Shared.Components.Breadcrumb
{
    public class BreadcrumbViewComponent : ViewComponent
    {

        public BreadcrumbViewComponent()
        {

        }

        public IViewComponentResult Invoke(string filter)
        {
            if (ViewBag.Breadcrumb == null)
            {
                ViewBag.Breadcrumb = new List<ModalMessageViewModel>();
            }

            return View(ViewBag.Breadcrumb as List<ModalMessageViewModel>);
        }
    }
}
