using Alfa5.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Alfa5.Permissions;

public class Alfa5PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Alfa5Permissions.GroupName);

        myGroup.AddPermission(Alfa5Permissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        myGroup.AddPermission(Alfa5Permissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);

        var booksPermission = myGroup.AddPermission(Alfa5Permissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(Alfa5Permissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(Alfa5Permissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(Alfa5Permissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Alfa5Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Alfa5Resource>(name);
    }
}
