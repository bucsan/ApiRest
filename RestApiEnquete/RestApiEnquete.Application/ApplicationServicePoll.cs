using AutoMapper;
using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Application.Interfaces;
using RestApiEnquete.Domain.Core.Interfaces.Services;
using RestApiEnquete.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiEnquete.Application
{
    public class ApplicationServicePoll : IApplicationServicePoll
    {
        private readonly IServicePoll serviceCliente;
        private readonly IMapper mapper;
        public ApplicationServicePoll(IServicePoll serviceCliente
                                       , IMapper mapper)
        {
            this.serviceCliente = serviceCliente;
            this.mapper = mapper;
        }
        public void Add(PollDto clienteDto)
        {
            var cliente = mapper.Map<Poll>(clienteDto);
            serviceCliente.Add(cliente);
        }

        public IEnumerable<PollDto> GetAll()
        {
            var clientes = serviceCliente.GetAll();
            var clientesDto = mapper.Map<IEnumerable<PollDto>>(clientes);

            return clientesDto;
        }

        public PollDto GetById(int id)
        {
            var cliente = serviceCliente.GetById(id);
            var clienteDto = mapper.Map<PollDto>(cliente);

            return clienteDto;
        }

        public void Remove(PollDto clienteDto)
        {
            var cliente = mapper.Map<Poll>(clienteDto);
            serviceCliente.Remove(cliente);
        }

        public void Update(PollDto clienteDto)
        {
            var cliente = mapper.Map<Poll>(clienteDto);
            serviceCliente.Update(cliente);
        }
    }
}
