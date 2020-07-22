using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Application.Interfaces;
using RestApiEnquete.Application.Interfaces.Mappers;
using RestApiEnquete.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiEnquete.Application
{
    public class ApplicationServicePoll : IApplicationServicePoll
    {
        private readonly IServicePoll servicePoll;
        private readonly IMapperPoll mapperPoll;

        public ApplicationServicePoll(IServicePoll servicePoll, IMapperPoll mapperPoll)
        {
            this.servicePoll = servicePoll;
            this.mapperPoll = mapperPoll;
        }

        public void Add(PollDto pollDto)
        {
            var poll = mapperPoll.MapperDtoToEntity(pollDto);
            servicePoll.Add(poll);
        }

        public IEnumerable<PollDto> GetAll()
        {
            var polls = servicePoll.GetAll();
            return mapperPoll.MapperListPollDto(polls);
        }

        public PollDto GetById(int id)
        {
            var poll = servicePoll.GetById(id);
            return mapperPoll.MapperEntityToDto(poll);
        }

        public void Remove(PollDto pollDto)
        {
            var poll = mapperPoll.MapperDtoToEntity(pollDto);
            servicePoll.Remove(poll);
        }

        public void Update(PollDto pollDto)
        {
            var poll = mapperPoll.MapperDtoToEntity(pollDto);
            servicePoll.Update(poll);
        }
    }
}