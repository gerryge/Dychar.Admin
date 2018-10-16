using System.Collections.Generic;
using Dacnsoft.Admin.Roles.Dto;
using Dacnsoft.Admin.Users.Dto;

namespace Dacnsoft.Admin.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
