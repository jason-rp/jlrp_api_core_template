using AutoMapper;
using jlrp_api_core_template.Data.Entity;
using jlrp_api_core_template.DTO;
using jlrp_api_core_template.DTO.Response;
using jlrp_api_core_template.DTO.Request;

namespace jlrp_api_core_template.Infrastructure.Configs
{
    public class MappingProfileConfiguration : Profile
    {
        public MappingProfileConfiguration()
        {
            CreateMap<Person, CreatePersonRequest>().ReverseMap();
            CreateMap<Person, UpdatePersonRequest>().ReverseMap();
            CreateMap<Person, PersonQueryResponse>().ReverseMap();
        }
    }
}
