using System.Collections.Generic;
using MyPortal.Roles.Dto;

namespace MyPortal.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}