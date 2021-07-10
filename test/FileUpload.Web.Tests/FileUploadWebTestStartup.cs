using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace FileUpload
{
    public class FileUploadWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<FileUploadWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}