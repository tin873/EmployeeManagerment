using EmployeeManagerment.Model;

namespace EmployeeManagerment.BusinessLogicLayer
{
    public interface IEmployeeService 
    {
        /// <summary>
        /// sửa thông tin bản ghi
        /// </summary>
        /// <param name="entity"></param>
        public ServiceResult Update(Employee employee, object Id);
    }
}
