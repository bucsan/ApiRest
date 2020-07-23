using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Application.Interfaces;
using RestApiEnquete.Application.Interfaces.Mappers;
using RestApiEnquete.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiEnquete.Application
{
    public class ApplicationServiceVote : IApplicationServiceVote
    {
        private readonly IServiceVote serviceVote;
        private readonly IMapperVote mapperVote;

        public ApplicationServiceVote(IServiceVote serviceVote, IMapperVote mapperVote)
        {
            this.serviceVote = serviceVote;
            this.mapperVote = mapperVote;
        }

        public void Add(VoteDto voteDto)
        {
            var vote = mapperVote.MapperDtoToEntity(voteDto);
            serviceVote.Add(vote);
        }

        public IEnumerable<VoteDto> GetAll()
        {
            var votes = serviceVote.GetAll();
            return mapperVote.MapperListVoteDto(votes);
        }

        public VoteDto GetById(int id)
        {
            var vote = serviceVote.GetById(id);
            return mapperVote.MapperEntityToDto(vote);
        }

        public void Remove(VoteDto voteDto)
        {
            var vote = mapperVote.MapperDtoToEntity(voteDto);
            serviceVote.Remove(vote);
        }

        public void Update(VoteDto voteDto)
        {
            var vote = mapperVote.MapperDtoToEntity(voteDto);
            serviceVote.Update(vote);
        }
    }
}