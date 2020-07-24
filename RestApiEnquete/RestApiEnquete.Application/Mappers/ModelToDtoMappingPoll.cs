using AutoMapper;
using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Domain.Entitys;

namespace RestApiEnquete.Application.Mappers
{
    public class ModelToDtoMappingPoll : Profile
    {

        public ModelToDtoMappingPoll()
        {
            PollDtoMap();
        }

        private void PollDtoMap()
        {
            CreateMap<Poll, PollDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.OptionDescription, opt => opt.MapFrom(x => x.OptionDescription))
                .ForMember(dest => dest.View, opt => opt.MapFrom(x => x.View))
                .ForMember(dest => dest.DateRegistration, opt => opt.Ignore())
                .ForMember(dest => dest.Option, opt => opt.MapFrom(x => x.Option));
        }
    }
}
