using System.Collections.Generic;
using Dychar.Admin.Roles.Dto;
using Dychar.Admin.Users.Dto;

namespace Dychar.Admin.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
