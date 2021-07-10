using FileUpload.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FileUpload.FileManagement
{
    public class DocumentRepository : EfCoreRepository<FileUploadDbContext, Document, Guid>
    {
        public DocumentRepository(IDbContextProvider<FileUploadDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
