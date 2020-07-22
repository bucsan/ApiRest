using RestApiEnquete.Application.Dtos;
using System.Collections.Generic;

namespace RestApiEnquete.Application.Interfaces
{
    public interface IApplicationServicePoll
    {
        void Add(PollDto pollDto);

        void Update(PollDto pollDto);

        void Remove(PollDto pollDto);

        IEnumerable<PollDto> GetAll();

        PollDto GetById(int id);
    }
}