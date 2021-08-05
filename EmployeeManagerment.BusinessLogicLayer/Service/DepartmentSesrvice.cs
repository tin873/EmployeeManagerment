using EmployeeManagerment.DataAccessLayer;
using EmployeeManagerment.Model;
using System;

namespace EmployeeManagerment.BusinessLogicLayer
{
    public class DepartmentSesrvice : BaseService<Department>, IDepartmentService
    {
        private IDepartmentRepository _departmentRepository;
        public DepartmentSesrvice(IDepartmentRepository departmentRepository, IUnitOfWork unitOfWork, IBaseRepository<Department> baseRepository) : base(baseRepository, unitOfWork)
        {
            _departmentRepository = departmentRepository;
        }
        public ServiceResult Update(Department department, object Id)
        {
            if (CheckIsExits(Id))
            {
                try
                {
                    _departmentRepository.Update(department);
                    _serviceResult.IsSuccess = true;
                    _serviceResult.Data = 1;
                    _serviceResult.DevMsg = "Sửa thành công.";
                    _serviceResult.ResultCode = ResultCode.Success;
                    _unitOfWork.Commit();
                    return _serviceResult;
                }
                catch (Exception)
                {
                    _serviceResult.IsSuccess = false;
                    _serviceResult.Data = -1;
                    _serviceResult.DevMsg = "Sửa thất bại.";
                    _serviceResult.ResultCode = ResultCode.NotValid;
                    return _serviceResult;
                }

            }
            else
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.Data = null;
                _serviceResult.DevMsg = "Bản ghi không tồn tại.";
                _serviceResult.ResultCode = ResultCode.NotFound;
                return _serviceResult;
            }
        }
    }
}
