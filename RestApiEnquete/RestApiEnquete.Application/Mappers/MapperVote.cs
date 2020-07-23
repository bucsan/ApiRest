using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Application.Interfaces.Mappers;
using RestApiEnquete.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace RestApiEnquete.Application.Mappers
{
    public class MapperVote : IMapperVote
    {
        public Vote MapperDtoToEntity(VoteDto voteDto)
        {
            var poll = new Vote()
            {
                Id = voteDto.Id,
                Qty = voteDto.Qty,
                Option_Id = voteDto.Option_Id
            };

            return poll;
        }

        public VoteDto MapperEntityToDto(Vote vote)
        {
            var voteDto = new VoteDto()
            {
                Id = vote.Id,
                Qty = vote.Qty,
                Option_Id = vote.Option_Id
            };

            return voteDto;
        }

        public IEnumerable<VoteDto> MapperListVoteDto(IEnumerable<Vote> votes)
        {
            var dto = votes.Select(c => new VoteDto
            {
                Id = c.Id,
                Qty = c.Qty,
                Option_Id = c.Option_Id
            });

            return dto;
        }
    }
}