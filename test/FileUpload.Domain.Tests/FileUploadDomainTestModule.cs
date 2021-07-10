using FileUpload.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FileUpload
{
    [DependsOn(
        typeof(FileUploadEntityFrameworkCoreTestModule)
        )]
    public class FileUploadDomainTestModule : AbpModule
    {

    }
}