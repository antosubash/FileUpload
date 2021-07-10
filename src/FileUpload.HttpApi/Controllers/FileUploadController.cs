using FileUpload.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FileUpload.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FileUploadController : AbpController
    {
        protected FileUploadController()
        {
            LocalizationResource = typeof(FileUploadResource);
        }
    }
}