using System;
using System.Collections.Generic;
using System.Text;
using FileUpload.Localization;
using Volo.Abp.Application.Services;

namespace FileUpload
{
    /* Inherit your application services from this class.
     */
    public abstract class FileUploadAppService : ApplicationService
    {
        protected FileUploadAppService()
        {
            LocalizationResource = typeof(FileUploadResource);
        }
    }
}
