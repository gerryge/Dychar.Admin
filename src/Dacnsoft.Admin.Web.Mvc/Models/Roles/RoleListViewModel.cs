using System.Collections.Generic;
using Dacnsoft.Admin.Roles.Dto;

namespace Dacnsoft.Admin.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
