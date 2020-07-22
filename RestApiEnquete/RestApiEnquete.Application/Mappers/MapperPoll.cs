using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Application.Interfaces.Mappers;
using RestApiEnquete.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace RestApiEnquete.Application.Mappers
{
    public class MapperPoll : IMapperPoll
    {
        public Poll MapperDtoToEntity(PollDto pollDto)
        {
            var poll = new Poll()
            {
                Id = pollDto.Id,
                PollDescription = pollDto.PollDescription,
                Option = (IEnumerable<Option>)pollDto.Option
            };

            return poll;
        }

        public PollDto MapperEntityToDto(Poll poll)
        {
            var pollDto = new PollDto()
            {
                Id = poll.Id,
                PollDescription = poll.PollDescription,
                Option = (IEnumerable<OptionDto>)poll.Option
            };

            return pollDto;
        }

        public IEnumerable<PollDto> MapperListPollDto(IEnumerable<Poll> polls)
        {
            var dto = polls.Select(c => new PollDto
            {
                Id = c.Id,
                PollDescription = c.PollDescription,
                Option = (IEnumerable<OptionDto>)c.Option
            });

            return dto;
        }
    }
}