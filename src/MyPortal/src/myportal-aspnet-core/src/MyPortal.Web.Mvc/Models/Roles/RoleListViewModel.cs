using System.Collections.Generic;
using MyPortal.Roles.Dto;

namespace MyPortal.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
