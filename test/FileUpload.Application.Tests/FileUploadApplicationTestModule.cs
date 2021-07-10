using Volo.Abp.Modularity;

namespace FileUpload
{
    [DependsOn(
        typeof(FileUploadApplicationModule),
        typeof(FileUploadDomainTestModule)
        )]
    public class FileUploadApplicationTestModule : AbpModule
    {

    }
}