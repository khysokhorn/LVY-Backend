using Abp.Authorization;
using LVY-Backend.Authorization.Roles;
using LVY-Backend.Authorization.Users;

namespace LVY-Backend.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
