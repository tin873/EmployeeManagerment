using EmployeeManagerment.DataAccessLayer;
using EmployeeManagerment.Model;
using System;

namespace EmployeeManagerment.BusinessLogicLayer
{
    public class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork, IBaseRepository<Employee> baseRepository) : base(baseRepository, unitOfWork)
        {
            _employeeRepository = employeeRepository;
        }
        public ServiceResult Update(Employee employee, object Id)
        {
            if (CheckIsExits(Id))
            {
                try
                {
                    _employeeRepository.Update(employee);
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
