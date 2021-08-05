using EmployeeManagerment.BusinessLogicLayer;
using EmployeeManagerment.DataAccessLayer;
using EmployeeManagerment.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeManagerment.Controllers
{
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class EmployeeController : EmployeeManagerBaseController<Employee>
    {
        IEmployeeService _employeeService;
        private readonly EmployeeManagermentDbContext _dbContext;
        private ServiceResult _serviceResult;
        public EmployeeController(IBaseService<Employee> baseService, IEmployeeService employeeService, EmployeeManagermentDbContext dbContext) : base(baseService)
        {
            _employeeService = employeeService;
            _dbContext = dbContext;
            _serviceResult = new ServiceResult();
        }

        /// <summary>
        /// Sửa đổi 1 bản ghi trong bảng
        /// </summary>
        /// <param name="id">id thực thể</param>
        /// <param name="entity"> thực thể</param>
        /// <returns>ServiceResult bao gồm (data và thông báo)</returns>
        [HttpPut("{id}")]
        public virtual IActionResult Put([FromBody] Employee entity, Guid id)
        {
            //var result = _employeeService.Update(entity, id);
            //if (result != null)
            //    return Ok(result);
            //else
            //    return BadRequest(result);
            if (id != entity.DepartmentId)
            {
                return BadRequest();
            }

            _dbContext.Entry(entity).State = EntityState.Modified;
            try
            {
                _dbContext.SaveChanges();
                _serviceResult.IsSuccess = true;
                _serviceResult.Data = 1;
                _serviceResult.DevMsg = "Sửa thành công.";
                _serviceResult.ResultCode = ResultCode.Success;
                return Ok(_serviceResult);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}
