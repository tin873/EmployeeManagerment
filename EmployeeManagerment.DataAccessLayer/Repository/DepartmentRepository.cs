using EmployeeManagerment.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagerment.DataAccessLayer
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        private EmployeeManagermentDbContext _dbContext;

        public DepartmentRepository(IDbFactory dbFactory, EmployeeManagermentDbContext dbContext) : base(dbFactory)
        {
            DbFactory = dbFactory;
            _dbContext = dbContext;
        }
        void IDepartmentRepository.Update(Department department)
        {
            _dbContext.Entry(department).State = EntityState.Modified;
        }
    }
}
