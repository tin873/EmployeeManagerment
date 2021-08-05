using EmployeeManagerment.BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeManagerment.Controllers
{
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class EmployeeManagerBaseController<Entity> : ControllerBase
    {
        private IBaseService<Entity> _baseService;
        public EmployeeManagerBaseController(IBaseService<Entity> baseService)
        {
            _baseService = baseService;
        }
        /// <summary>
        /// lấy tất cả thông tin trong bảng
        /// </summary>
        /// <returns>Serviceresult bao gồm (data và thông báo)</returns>
        [HttpGet]
        public virtual IActionResult Get()
        {
            var result = _baseService.GetAll();
            return Ok(result);
        }
        /// <summary>
        /// lấy bản ghi theo mã
        /// </summary>
        /// <param name="id">id thực thể</param>
        /// <returns>Serviceresult bao gồm (data và thông báo)</returns>
        [HttpGet("{id}")]
        public virtual IActionResult Get(Guid id)
        {
            var result = _baseService.GetById(id);
            return Ok(result);
        }
        /// <summary>
        /// Thêm mới 1 bản ghi vào bảng
        /// </summary>
        /// <param name="entity"> thực thể</param>
        /// <returns>ServiceReuslt bao gồm (data và thông báo)</returns>
        [HttpPost]
        public virtual IActionResult Post([FromBody] Entity entity)
        {
            var result = _baseService.Add(entity);
            if (result != null)
                return Ok(result);
            else
                return BadRequest(result);
        }
        /// <summary>
        /// Xóa 1 bản ghi trong bảng
        /// </summary>
        /// <param name="id"></param>
        /// <returns>serviceResult bao gồm (data và thông báo)</returns>
        [HttpDelete("{id}")]
        public virtual IActionResult Delete(Guid id)
        {
            var result = _baseService.Delete(id);
            if (result != null)
                return Ok(result);
            else
                return BadRequest(result);
        }

    }
}
