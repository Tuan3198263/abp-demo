using EmpManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EmpManager.Permissions;

public class EmpManagerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EmpManagerPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EmpManagerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EmpManagerResource>(name);
    }
}
