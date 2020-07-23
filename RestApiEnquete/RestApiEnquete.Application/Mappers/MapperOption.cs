using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Application.Interfaces.Mappers;
using RestApiEnquete.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace RestApiEnquete.Application.Mappers
{
    public class MapperOption : IMapperOption
    {
        public Option MapperDtoToEntity(OptionDto optionDto)
        {
            var option = new Option()
            {
                Id = optionDto.Id,
                OptionDescription = optionDto.OptionDescription,
                Poll_Id = optionDto.Poll_Id
            };

            return option;
        }

        public OptionDto MapperEntityToDto(Option option)
        {
            var optionDto = new OptionDto()
            {
                Id = option.Id,
                OptionDescription = option.OptionDescription,
                Poll_Id = option.Poll_Id
            };

            return optionDto;
        }

        public IEnumerable<OptionDto> MapperListOptionDto(IEnumerable<Option> options)
        {
            var dto = options.Select(c => new OptionDto
            {
                Id = c.Id,
                OptionDescription = c.OptionDescription,
                Poll_Id = c.Poll_Id
            });

            return dto;
        }
    }
}