using AutoMapper;
using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Application.Interfaces;
using RestApiEnquete.Application.ViewModels;
using RestApiEnquete.Domain.Core.Interfaces.Services;
using RestApiEnquete.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace RestApiEnquete.Application
{
    public class ApplicationServicePoll : IApplicationServicePoll
    {
        private readonly IServicePoll _servicePoll;
        private readonly IMapper _mapper;
        public ApplicationServicePoll(IServicePoll servicePoll , IMapper mapper)
        {
            _servicePoll = servicePoll;
            _mapper = mapper;
        }
        public void Add(PollDto pollDto)
        {
            var poll = _mapper.Map<Poll>(pollDto);
            _servicePoll.Add(poll);
        }

        public IEnumerable<PollDto> GetAll()
        {
            var polls = _servicePoll.GetAll();
            var pollsDto = _mapper.Map<IEnumerable<PollDto>>(polls);

            return pollsDto;
        }

        public PollDto GetById(int id)
        {
            var poll = _servicePoll.GetById(id);
            var pollDto = _mapper.Map<PollDto>(poll);

            return pollDto;
        }

        public PollGetByIdViewModelResponse GetByIdResponse(int id)
        {
            var poll = _servicePoll.GetById(id);
            var pollDto = _mapper.Map<PollDto>(poll);

            if (pollDto == null) return null;

            return new PollGetByIdViewModelResponse
            {
                Poll_Id = pollDto.Id,
                Poll_Description = pollDto.PollDescription,
                Options = pollDto.Option.Select(x => new PollGetByIdViewModelResponseOption { Option_Id = x.Id, Option_Description = x.OptionDescription }).ToList()
            };
        }

        public void Remove(PollDto pollDto)
        {
            var poll = _mapper.Map<Poll>(pollDto);
            _servicePoll.Remove(poll);
        }

        public void Update(PollDto pollDto)
        {
            var poll = _mapper.Map<Poll>(pollDto);
            _servicePoll.Update(poll);
        }
    }
}
