using EmployeeManagerment.DataAccessLayer;
using EmployeeManagerment.Model;
using System.Threading.Tasks;

namespace EmployeeManagerment.BusinessLogicLayer
{
    public class BaseService<Entity> : IBaseService<Entity> where Entity : class
    {
        private readonly IBaseRepository<Entity> _baseRepository;
        protected ServiceResult _serviceResult;
        protected IUnitOfWork _unitOfWork;

        public BaseService(IBaseRepository<Entity> baseRepository, IUnitOfWork unitOfWork)
        {
            _baseRepository = baseRepository;
            _serviceResult = new ServiceResult();
            _unitOfWork = unitOfWork;
        }
        public ServiceResult Add(Entity entity)
        {
            var result = _baseRepository.Add(entity);
            if (result != null)
            {
                _serviceResult.IsSuccess = true;
                _serviceResult.Data = result;
                _serviceResult.DevMsg = "Thêm mới thành công.";
                _serviceResult.ResultCode = ResultCode.Success;
                _unitOfWork.Commit();
                return _serviceResult;
            }
            else
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.Data = result;
                _serviceResult.DevMsg = "Thêm mới thất bại.";
                _serviceResult.ResultCode = ResultCode.NotValid;
                return _serviceResult;
            }
        }

        public ServiceResult Delete(object Id)
        {
            if (CheckIsExits(Id))
            {
                var result = _baseRepository.Delete(_baseRepository.GetById(Id));
                if (result != null)
                {
                    _serviceResult.IsSuccess = true;
                    _serviceResult.Data = result;
                    _serviceResult.DevMsg = "Xóa thành công.";
                    _serviceResult.ResultCode = ResultCode.Success;
                    _unitOfWork.Commit();
                    return _serviceResult;
                }
                else
                {
                    _serviceResult.IsSuccess = false;
                    _serviceResult.Data = result;
                    _serviceResult.DevMsg = "Xóa thất bại.";
                    _serviceResult.ResultCode = ResultCode.NotValid;
                    return _serviceResult;
                }
            }
            else
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.Data = null;
                _serviceResult.DevMsg = "Không tìm thấy bản ghi.";
                _serviceResult.ResultCode = ResultCode.NotFound;
                return _serviceResult;
            }
        }

        public ServiceResult GetAll()
        {
            var result = _baseRepository.GetAll();
            if (result != null)
            {
                _serviceResult.IsSuccess = true;
                _serviceResult.Data = result;
                _serviceResult.DevMsg = "Lấy thành công.";
                _serviceResult.ResultCode = ResultCode.Success;
                return _serviceResult;
            }
            else
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.Data = null;
                _serviceResult.DevMsg = "Không tìm thấy kết quả.";
                _serviceResult.ResultCode = ResultCode.NotFound;
                return _serviceResult;
            }
        }

        public async Task<ServiceResult> GetAllAsync()
        {
            var result = await _baseRepository.GetAllAsync();
            if (result != null)
            {
                _serviceResult.IsSuccess = true;
                _serviceResult.Data = result;
                _serviceResult.DevMsg = "Lấy thành công.";
                _serviceResult.ResultCode = ResultCode.Success;
                return _serviceResult;
            }
            else
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.Data = null;
                _serviceResult.DevMsg = "Không tìm thấy kết quả.";
                _serviceResult.ResultCode = ResultCode.NotFound;
                return _serviceResult;
            }
        }

        public ServiceResult GetById(object Id)
        {
            var result = _baseRepository.GetById(Id);
            if (result != null)
            {
                _serviceResult.IsSuccess = true;
                _serviceResult.Data = result;
                _serviceResult.DevMsg = "Lấy thành công.";
                _serviceResult.ResultCode = ResultCode.Success;
                return _serviceResult;
            }
            else
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.Data = null;
                _serviceResult.DevMsg = "Không tìm thấy kết quả.";
                _serviceResult.ResultCode = ResultCode.NotFound;
                return _serviceResult;
            }
        }

        public async Task<ServiceResult> GetByIdAsync(object Id)
        {
            var result = await _baseRepository.GetByIdAsync(Id);
            if (result != null)
            {
                _serviceResult.IsSuccess = true;
                _serviceResult.Data = result;
                _serviceResult.DevMsg = "Lấy thành công.";
                _serviceResult.ResultCode = ResultCode.Success;
                return _serviceResult;
            }
            else
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.Data = null;
                _serviceResult.DevMsg = "Không tìm thấy kết quả.";
                _serviceResult.ResultCode = ResultCode.NotFound;
                return _serviceResult;
            }
        }

        public bool CheckIsExits(object Id)
        {
            if (_baseRepository.GetById(Id) != null)
                return true;
            else
                return false;
        }
    }
}
