using RestApiEnquete.Domain.Core.Interfaces.Repositorys;
using RestApiEnquete.Domain.Core.Interfaces.Services;
using RestApiEnquete.Domain.Entitys;

namespace RestApiEnquete.Domain.Services
{
    public class ServicePoll : ServiceBase<Poll>, IServicePoll
    {
        private readonly IRepositoryPoll repositoryCliente;

        public ServicePoll(IRepositoryPoll repositoryCliente)
            : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}