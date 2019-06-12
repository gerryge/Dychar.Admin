using System.Collections.Generic;
using Dychar.Admin.Roles.Dto;

namespace Dychar.Admin.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}