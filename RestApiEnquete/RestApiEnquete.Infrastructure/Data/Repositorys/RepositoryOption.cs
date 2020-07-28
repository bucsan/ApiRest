using RestApiEnquete.Domain.Core.Interfaces.Repositorys;
using RestApiEnquete.Domain.Entitys;

namespace RestApiEnquete.Infrastructure.Data.Repositorys
{
    public class RepositoryOption : RepositoryBase<Option>, IRepositoryOption
    {
        private readonly SqlContext _sqlContext;

        public RepositoryOption(SqlContext sqlContext)
            : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}