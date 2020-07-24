using AutoMapper;
using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Domain.Entitys;

namespace RestApiEnquete.Application.Mappers
{
    public class DtoToModelMappingOption : Profile
    {
        public DtoToModelMappingOption()
        {
            OptionMap();
        }

        private void OptionMap()
        {
            CreateMap<OptionDto, Option>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Poll_Id, opt => opt.MapFrom(x => x.Poll_Id))
                .ForMember(dest => dest.OptionDescription, opt => opt.MapFrom(x => x.OptionDescription))
                .ForMember(dest => dest.Qty, opt => opt.MapFrom(x => x.Qty))
                .ForMember(dest => dest.DateRegistration, opt => opt.Ignore());
        }
    }
}
