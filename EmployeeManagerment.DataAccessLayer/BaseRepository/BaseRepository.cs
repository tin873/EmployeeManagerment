using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagerment.DataAccessLayer
{
    public class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : class
    {
        private EmployeeManagermentDbContext _dbContext;
        private readonly DbSet<Entity> _dbSet;

        protected IDbFactory DbFactory;
        protected EmployeeManagermentDbContext DbContext => _dbContext ?? (_dbContext = DbFactory.Init());

        public BaseRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            _dbSet = DbContext.Set<Entity>();
        }

        public Entity Add(Entity entity)
        {
            return _dbSet.Add(entity).Entity;
        }

        public Entity Delete(Entity entity)
        {
            if(_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            return _dbSet.Remove(entity).Entity;
        }

        public IEnumerable<Entity> GetAll()
        {
            return _dbSet;
        }

        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public Entity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }

        public async Task<Entity> GetByIdAsync(object Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public Entity Update(Entity entity)
        {
            return _dbSet.Update(entity).Entity;
        }
    }
}
