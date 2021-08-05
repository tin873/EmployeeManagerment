using EmployeeManagerment.Model;

namespace EmployeeManagerment.DataAccessLayer
{
    public interface IDepartmentRepository
    {
        /// <summary>
        /// sửa thông tin bản ghi
        /// </summary>
        /// <param name="entity"></param>
        public void Update(Department department);
    }
}
