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
        private readonly IServiceOption serviceProduto;
        private readonly IMapper mapper;

        public ApplicationServiceOption(IServiceOption serviceProduto
                                        , IMapper mapper)
        {
            this.serviceProduto = serviceProduto;
            this.mapper = mapper;
        }

        public void Add(OptionDto produtoDto)
        {
            var produto = mapper.Map<Option>(produtoDto);
            serviceProduto.Add(produto);
        }

        public IEnumerable<OptionDto> GetAll()
        {
            var produtos = serviceProduto.GetAll();
            var produtosDto = mapper.Map<IEnumerable<OptionDto>>(produtos);
            return produtosDto;
        }

        public OptionDto GetById(int id)
        {
            var produto = serviceProduto.GetById(id);
            var produtoDto = mapper.Map<OptionDto>(produto);
            return produtoDto;
        }

        public void Remove(OptionDto produtoDto)
        {
            var produto = mapper.Map<Option>(produtoDto);
            serviceProduto.Remove(produto);
        }

        public void Update(OptionDto produtoDto)
        {
            var produto = mapper.Map<Option>(produtoDto);
            serviceProduto.Update(produto);
        }
    }
}