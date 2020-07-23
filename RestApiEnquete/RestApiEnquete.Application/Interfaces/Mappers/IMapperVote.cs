using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiEnquete.Application.Interfaces.Mappers
{
    public interface IMapperVote
    {
        Vote MapperDtoToEntity(VoteDto voteDto);

        IEnumerable<VoteDto> MapperListVoteDto(IEnumerable<Vote> votes);

        VoteDto MapperEntityToDto(Vote vote);
    }
}