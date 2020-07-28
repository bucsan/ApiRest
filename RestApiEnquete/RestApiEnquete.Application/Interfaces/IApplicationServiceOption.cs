using RestApiEnquete.Application.Dtos;
using System.Collections.Generic;

namespace RestApiEnquete.Application.Interfaces
{
    public interface IApplicationServiceOption
    {
        void Add(OptionDto optionDto);

        void Update(OptionDto optionDto);

        void Remove(OptionDto optionDto);

        IEnumerable<OptionDto> GetAll();

        OptionDto GetById(int id);
    }
}