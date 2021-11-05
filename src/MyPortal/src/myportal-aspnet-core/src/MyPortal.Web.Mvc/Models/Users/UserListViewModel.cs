using System.Collections.Generic;
using MyPortal.Roles.Dto;

namespace MyPortal.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
