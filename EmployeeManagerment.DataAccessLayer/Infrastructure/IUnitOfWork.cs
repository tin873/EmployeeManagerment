using System.Threading.Tasks;

namespace EmployeeManagerment.DataAccessLayer
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// savechange database
        /// </summary>
        /// <returns>số nguyên</returns>
        int Commit();
        /// <summary>
        /// savechange database bất đồng bộ
        /// </summary>
        /// <returns>số nguyên</returns>
        Task<int> CommitAsync();
    }
}
