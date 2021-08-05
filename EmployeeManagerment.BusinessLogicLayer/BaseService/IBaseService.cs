using EmployeeManagerment.Model;
using System.Threading.Tasks;

namespace EmployeeManagerment.BusinessLogicLayer
{
    public interface IBaseService<Entity>
    {
        /// <summary>
        /// thêm mới 1 bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>thông tin bản ghi vừa thêm mới</returns>
        public ServiceResult Add(Entity entity);
        /// <summary>
        /// xóa bỏ 1 bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>thông tin bản ghi đã xóa</returns>
        public ServiceResult Delete(object Id);
        /// <summary>
        /// lấy ra danh sách tất cả bản ghi
        /// </summary>
        /// <returns>danh sách bản ghi</returns>
        public ServiceResult GetAll();
        /// <summary>
        /// lấy bản ghi theo mã
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>bản ghi tìm thấy</returns>
        public ServiceResult GetById(object Id);
        /// <summary>
        /// lấy bản ghi theo mã
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>bản ghi tìm thấy</returns>
        public Task<ServiceResult> GetByIdAsync(object Id);
        /// <summary>
        /// lấy ra danh sách tất cả bản ghi
        /// </summary>
        /// <returns>danh sách bản ghi</returns>
        public Task<ServiceResult> GetAllAsync();


    }
}
