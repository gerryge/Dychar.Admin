using Abp.Application.Navigation;

namespace Dychar.Admin.Web.Views.Shared.Components.SideBarNav
{
    public class SideBarNavViewModel
    {
        public UserMenu MainMenu { get; set; }

        public string ActiveMenuItemName { get; set; }
    }
}
