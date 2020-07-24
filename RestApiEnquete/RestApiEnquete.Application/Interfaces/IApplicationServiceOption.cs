using RestApiEnquete.Application.Dtos;
using System.Collections.Generic;

namespace RestApiEnquete.Application.Interfaces
{
    public interface IApplicationServiceOption
    {
        void Add(OptionDto produtoDto);

        void Update(OptionDto produtoDto);

        void Remove(OptionDto produtoDto);

        IEnumerable<OptionDto> GetAll();

        OptionDto GetById(int id);
    }
}