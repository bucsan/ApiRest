using RestApiEnquete.Domain.Core.Interfaces.Repositorys;
using RestApiEnquete.Domain.Core.Interfaces.Services;
using RestApiEnquete.Domain.Entitys;

namespace RestApiEnquete.Domain.Services
{
    public class ServiceOption : ServiceBase<Option>, IServiceOption
    {
        private readonly IRepositoryOption repositoryProduto;

        public ServiceOption(IRepositoryOption repositoryProduto)
            : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}