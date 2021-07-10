using AutoMapper;
using FileUpload.FileManagement;
using FileUpload.Files.Dto;

namespace FileUpload
{
    public class FileUploadApplicationAutoMapperProfile : Profile
    {
        public FileUploadApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Document, DocumentDto>().ReverseMap();
        }
    }
}
