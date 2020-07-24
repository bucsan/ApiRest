using AutoMapper;
using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Domain.Entitys;

namespace RestApiEnquete.Application.Mappers
{
    public class ModelToDtoMappingOption : Profile
    {
        public ModelToDtoMappingOption()
        {
            OptionDtoMap();
        }
        private void OptionDtoMap()
        {
            CreateMap<Option, OptionDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.OptionDescription, opt => opt.MapFrom(x => x.OptionDescription))
                .ForMember(dest => dest.Qty, opt => opt.MapFrom(x => x.Qty));
        }
    }
}
