using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FileUpload.Data
{
    /* This is used if database provider does't define
     * IFileUploadDbSchemaMigrator implementation.
     */
    public class NullFileUploadDbSchemaMigrator : IFileUploadDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}