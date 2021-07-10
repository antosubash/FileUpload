using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace FileUpload.Files.Dto
{
    public class DocumentDto : EntityDto<Guid>
    {
        public long FileSize { get; set; }

        public string FileUrl { get; set; }

        public string MimeType { get; set; }
    }
}
