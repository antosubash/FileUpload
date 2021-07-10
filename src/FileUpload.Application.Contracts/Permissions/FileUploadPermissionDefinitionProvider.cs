using FileUpload.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FileUpload.Permissions
{
    public class FileUploadPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FileUploadPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(FileUploadPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FileUploadResource>(name);
        }
    }
}
