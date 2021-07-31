using Dyabp.Cds.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dyabp.Cds.Permissions
{
    public class CdsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CdsPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CdsPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CdsResource>(name);
        }
    }
}
