using FileUpload.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace FileUpload.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class FileUploadPageModel : AbpPageModel
    {
        protected FileUploadPageModel()
        {
            LocalizationResourceType = typeof(FileUploadResource);
        }
    }
}