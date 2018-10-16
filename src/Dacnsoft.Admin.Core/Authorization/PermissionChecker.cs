using Abp.Authorization;
using Dacnsoft.Admin.Authorization.Roles;
using Dacnsoft.Admin.Authorization.Users;

namespace Dacnsoft.Admin.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
