using System;

namespace EmployeeManagerment.DataAccessLayer
{
    public interface IDbFactory : IDisposable
    {
        /// <summary>
        /// khởi tạo đối tượng Dbcontext
        /// </summary>
        /// <returns></returns>
        EmployeeManagermentDbContext Init();
    }
}
