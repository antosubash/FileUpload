using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FileUpload.Data;
using Volo.Abp.DependencyInjection;

namespace FileUpload.EntityFrameworkCore
{
    public class EntityFrameworkCoreFileUploadDbSchemaMigrator
        : IFileUploadDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFileUploadDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FileUploadDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FileUploadDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
