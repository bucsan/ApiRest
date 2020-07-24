using AutoMapper;
using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Domain.Entitys;

namespace RestApiEnquete.Application.Mappers
{
    public class DtoToModelMappingPoll : Profile
    {
        public DtoToModelMappingPoll()
        {
            PollMap();
        }

        private void PollMap()
        {
            CreateMap<PollDto, Poll>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.OptionDescription, opt => opt.MapFrom(x => x.OptionDescription))
                .ForMember(dest => dest.DateRegistration, opt => opt.Ignore())
                .ForMember(dest => dest.View, opt => opt.MapFrom(x => x.View));
        }
    }
}
