using Abp.Application.Navigation;

namespace Dychar.Admin.Web.Views.Shared.Components.SideBarNav
{
    public class UserMenuItemViewModel
    {
        public UserMenuItem MenuItem { get; set; }

        public string ActiveMenuItemName { get; set; }

        public int MenuItemIndex { get; set; }

        public bool RootLevel { get; set; }
    }
}
