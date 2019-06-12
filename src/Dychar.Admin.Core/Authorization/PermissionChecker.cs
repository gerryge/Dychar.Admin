using Abp.Authorization;
using Dychar.Admin.Authorization.Roles;
using Dychar.Admin.Authorization.Users;

namespace Dychar.Admin.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
