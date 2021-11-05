using Abp.Authorization;
using MyPortal.Authorization.Roles;
using MyPortal.Authorization.Users;

namespace MyPortal.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
