using System.Threading.Tasks;

namespace FileUpload.Data
{
    public interface IFileUploadDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
