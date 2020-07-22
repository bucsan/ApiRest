using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiEnquete.Application.Interfaces.Mappers
{
    public interface IMapperOption
    {
        Option MapperDtoToEntity(OptionDto optionDto);

        IEnumerable<OptionDto> MapperListOptionDto(IEnumerable<Option> options);

        OptionDto MapperEntityToDto(Option option);
    }
}