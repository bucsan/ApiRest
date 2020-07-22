using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiEnquete.Application.Interfaces.Mappers
{
    public interface IMapperPoll
    {
        Poll MapperDtoToEntity(PollDto pollDto);

        IEnumerable<PollDto> MapperListPollDto(IEnumerable<Poll> polls);

        PollDto MapperEntityToDto(Poll poll);
    }
}