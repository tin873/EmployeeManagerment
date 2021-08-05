using EmployeeManagerment.Model;

namespace EmployeeManagerment.DataAccessLayer
{
    public interface IEmployeeRepository
    {
        /// <summary>
        /// sửa thông tin bản ghi
        /// </summary>
        /// <param name="entity"></param>
        public void Update(Employee employee);
    }
}
