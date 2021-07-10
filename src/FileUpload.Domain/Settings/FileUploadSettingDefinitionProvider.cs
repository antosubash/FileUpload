using Volo.Abp.Settings;

namespace FileUpload.Settings
{
    public class FileUploadSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FileUploadSettings.MySetting1));
        }
    }
}
