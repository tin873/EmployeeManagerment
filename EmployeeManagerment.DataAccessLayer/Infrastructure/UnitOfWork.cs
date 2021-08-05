using System.Threading.Tasks;

namespace EmployeeManagerment.DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private EmployeeManagermentDbContext _dbContext;
        public EmployeeManagermentDbContext DbContext => _dbContext ?? (_dbContext = _dbFactory.Init());
        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public int Commit()
        {
            return DbContext.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return DbContext.SaveChangesAsync();
        }
    }
}
