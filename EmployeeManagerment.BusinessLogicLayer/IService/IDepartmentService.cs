using EmployeeManagerment.Model;

namespace EmployeeManagerment.BusinessLogicLayer
{
    public interface IDepartmentService
    {
        /// <summary>
        /// sửa thông tin bản ghi
        /// </summary>
        /// <param name="entity"></param>
        public ServiceResult Update(Department department, object Id);
    }
}
