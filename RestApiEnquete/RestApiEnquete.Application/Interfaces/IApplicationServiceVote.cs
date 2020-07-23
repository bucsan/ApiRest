using RestApiEnquete.Application.Dtos;
using System.Collections.Generic;

namespace RestApiEnquete.Application.Interfaces
{
    public interface IApplicationServiceVote
    {
        void Add(VoteDto voteDto);

        void Update(VoteDto voteDto);

        void Remove(VoteDto voteDto);

        IEnumerable<VoteDto> GetAll();

        VoteDto GetById(int id);
    }
}