using RestApiEnquete.Domain.Core.Interfaces.Repositorys;
using RestApiEnquete.Domain.Core.Services;
using RestApiEnquete.Domain.Entitys;

namespace RestApiEnquete.Domain.Services
{
    public class ServiceOption : ServiceBase<Option>, IServiceOption
    {
        private readonly IRepositoryOption repositoryOption;

        public ServiceOption(IRepositoryOption repositoryOption) : base(repositoryOption)
        {
            this.repositoryOption = repositoryOption;
        }
    }
}