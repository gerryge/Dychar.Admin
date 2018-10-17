using Dacnsoft.Admin.Web.Models.Common.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dacnsoft.Admin.Web.Views.Shared.Components.MenuNotification
{
    public class MenuNotificationViewComponent : ViewComponent
    {

        public MenuNotificationViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            var messages = GetData();
            return View(messages);
        }

        private List<ModalMessageViewModel> GetData()
        {
            var messages = new List<ModalMessageViewModel>();
            messages.Add(new ModalMessageViewModel
            {
                Id = 1,
                FontAwesomeIcon = "fa fa-users text-aqua",
                ShortDesc = "5 new members joined today",
                URLPath = "#",
            });

            return messages;
        }
    }
}
