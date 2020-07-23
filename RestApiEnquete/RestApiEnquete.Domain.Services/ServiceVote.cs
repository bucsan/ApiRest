using RestApiEnquete.Domain.Core.Interfaces.Repositorys;
using RestApiEnquete.Domain.Core.Interfaces.Services;
using RestApiEnquete.Domain.Entitys;

namespace RestApiEnquete.Domain.Services
{
    public class ServiceVote : ServiceBase<Vote>, IServiceVote
    {
        private readonly IRepositoryVote repositoryVote;

        public ServiceVote(IRepositoryVote repositoryVote) : base(repositoryVote)
        {
            this.repositoryVote = repositoryVote;
        }
    }
}