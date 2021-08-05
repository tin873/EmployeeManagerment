namespace EmployeeManagerment.DataAccessLayer
{
    public class DbFactory : Disposable,IDbFactory
    {
        private EmployeeManagermentDbContext _dbContext;
        public DbFactory(EmployeeManagermentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public EmployeeManagermentDbContext Init()
        {
            return _dbContext;
        }

        //public EmployeeManagermentDbContext Init() => _dbContext ?? (_dbContext = new EmployeeManagermentDbContext());

        protected override void DisposeCore()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }
    }
}
