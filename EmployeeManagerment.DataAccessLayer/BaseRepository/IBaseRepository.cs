using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagerment.DataAccessLayer
{
    public interface IBaseRepository<Entity>
    {
        /// <summary>
        /// thêm mới 1 bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>thông tin bản ghi vừa thêm mới</returns>
        public Entity Add(Entity entity);
        /// <summary>
        /// xóa bỏ 1 bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>thông tin bản ghi đã xóa</returns>
        public Entity Delete(Entity entity);
        /// <summary>
        /// lấy ra danh sách tất cả bản ghi
        /// </summary>
        /// <returns>danh sách bản ghi</returns>
        public IEnumerable<Entity> GetAll();
        /// <summary>
        /// lấy bản ghi theo mã
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>bản ghi tìm thấy</returns>
        public Entity GetById(object Id);
        /// <summary>
        /// lấy bản ghi theo mã
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>bản ghi tìm thấy</returns>
        public Task<Entity> GetByIdAsync(object Id);
        /// <summary>
        /// lấy ra danh sách tất cả bản ghi
        /// </summary>
        /// <returns>danh sách bản ghi</returns>
        public Task<IEnumerable<Entity>> GetAllAsync();


    }
}
