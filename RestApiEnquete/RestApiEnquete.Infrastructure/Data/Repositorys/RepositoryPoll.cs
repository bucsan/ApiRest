using RestApiEnquete.Domain.Core.Interfaces.Repositorys;
using RestApiEnquete.Domain.Entitys;

namespace RestApiEnquete.Infrastructure.Data.Repositorys
{
    public class RepositoryPoll : RepositoryBase<Poll>, IRepositoryPoll
    {
        private readonly SqlContext _sqlContext;

        public RepositoryPoll(SqlContext sqlContext)
            : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}