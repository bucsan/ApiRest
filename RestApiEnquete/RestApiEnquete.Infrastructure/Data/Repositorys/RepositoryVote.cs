using RestApiEnquete.Domain.Core.Interfaces.Repositorys;
using RestApiEnquete.Domain.Entitys;

namespace RestApiEnquete.Infrastructure.Data.Repositorys
{
    public class RepositoryVote : RepositoryBase<Vote>, IRepositoryVote
    {
        private readonly SqlContext sqlContext;

        public RepositoryVote(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}