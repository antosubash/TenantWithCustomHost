using CustomHost.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CustomHost.Permissions
{
    public class CustomHostPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CustomHostPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(CustomHostPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CustomHostResource>(name);
        }
    }
}
