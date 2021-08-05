using EmployeeManagerment.Model;

namespace EmployeeManagerment.DataAccessLayer
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        private EmployeeManagermentDbContext _dbContext;

        public EmployeeRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            DbFactory = dbFactory;
        }
        protected EmployeeManagermentDbContext DbContext => _dbContext ?? (_dbContext = DbFactory.Init());
        void IEmployeeRepository.Update(Employee employee)
        {
            _dbContext.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
