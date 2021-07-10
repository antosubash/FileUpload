using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace FileUpload.Web
{
    [Dependency(ReplaceServices = true)]
    public class FileUploadBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "FileUpload";
    }
}
