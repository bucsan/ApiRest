using RestApiEnquete.Application.Dtos;
using System.Collections.Generic;

namespace RestApiEnquete.Application.Interfaces
{
    public interface IApplicationServicePoll
    {
        void Add(PollDto clienteDto);

        void Update(PollDto clienteDto);

        void Remove(PollDto clienteDto);

        IEnumerable<PollDto> GetAll();

        PollDto GetById(int id);
    }
}