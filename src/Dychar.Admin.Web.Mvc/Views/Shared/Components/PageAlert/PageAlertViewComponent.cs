using Dychar.Admin.Web.Models.Common.Modals;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Dychar.Admin.Web.Views.Shared.Components.PageAlert
{
    public class PageAlertViewComponent : ViewComponent
    {

        public PageAlertViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            List<ModalMessageViewModel> messages;
            if (ViewBag.PageAlerts == null)
            {
                messages = new List<ModalMessageViewModel>();
            }
            else
            {
                messages = new List<ModalMessageViewModel>(ViewBag.PageAlerts);
            }
            return View(messages);
        }
    }
}
