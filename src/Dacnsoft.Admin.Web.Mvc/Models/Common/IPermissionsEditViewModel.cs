using System.Collections.Generic;
using Dacnsoft.Admin.Roles.Dto;

namespace Dacnsoft.Admin.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}