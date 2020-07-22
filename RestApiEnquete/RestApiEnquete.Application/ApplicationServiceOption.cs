using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Application.Interfaces;
using RestApiEnquete.Application.Interfaces.Mappers;
using RestApiEnquete.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiEnquete.Application
{
    public class ApplicationServiceOption : IApplicationServiceOption
    {
        private readonly IServiceOption serviceOption;
        private readonly IMapperOption mapperOption;

        public ApplicationServiceOption(IServiceOption serviceOption, IMapperOption mapperOption)
        {
            this.serviceOption = serviceOption;
            this.mapperOption = mapperOption;
        }

        public void Add(OptionDto optionDto)
        {
            var option = mapperOption.MapperDtoToEntity(optionDto);
            serviceOption.Add(option);
        }

        public IEnumerable<OptionDto> GetAll()
        {
            var options = serviceOption.GetAll();
            return mapperOption.MapperListOptionDto(options);
        }

        public OptionDto GetById(int id)
        {
            var option = serviceOption.GetById(id);
            return mapperOption.MapperEntityToDto(option);
        }

        public void Remove(OptionDto optionDto)
        {
            var option = mapperOption.MapperDtoToEntity(optionDto);
            serviceOption.Remove(option);
        }

        public void Update(OptionDto optionDto)
        {
            var option = mapperOption.MapperDtoToEntity(optionDto);
            serviceOption.Update(option);
        }
    }
}