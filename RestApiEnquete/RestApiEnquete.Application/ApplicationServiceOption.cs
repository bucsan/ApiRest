using AutoMapper;
using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Application.Interfaces;
using RestApiEnquete.Domain.Core.Interfaces.Services;
using RestApiEnquete.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiEnquete.Application
{
    public class ApplicationServiceOption : IApplicationServiceOption
    {
        private readonly IServiceOption _serviceOption;
        private readonly IMapper _mapper;

        public ApplicationServiceOption(IServiceOption serviceOption, IMapper mapper)
        {
            _serviceOption = serviceOption;
            _mapper = mapper;
        }

        public void Add(OptionDto optionDto)
        {
            var option = _mapper.Map<Option>(optionDto);
            _serviceOption.Add(option);
        }

        public IEnumerable<OptionDto> GetAll()
        {
            var options = _serviceOption.GetAll();
            var optionsDto = _mapper.Map<IEnumerable<OptionDto>>(options);
            return optionsDto;
        }

        public OptionDto GetById(int id)
        {
            var option = _serviceOption.GetById(id);
            var optionDto = _mapper.Map<OptionDto>(option);
            return optionDto;
        }

        public void Remove(OptionDto optionDto)
        {
            var option = _mapper.Map<Option>(optionDto);
            _serviceOption.Remove(option);
        }

        public void Update(OptionDto optionDto)
        {
            var option = _mapper.Map<Option>(optionDto);
            _serviceOption.Update(option);
        }
    }
}