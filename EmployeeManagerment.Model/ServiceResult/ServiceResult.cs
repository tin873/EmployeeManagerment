using System.Collections.Generic;

namespace EmployeeManagerment.Model
{
    public class ServiceResult
    {
        /// <summary>
        /// trạng thái thao tác (true- thành công . false-thất bại)
        /// </summary>
        public bool IsSuccess { get; set; } = true;
        /// <summary>
        /// dữ liệu trả về
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// code trả về
        /// </summary>
        public ResultCode ResultCode { get; set; }
        /// <summary>
        /// danh sách thông báo lỗi cho người dùng
        /// </summary>
        public List<string> UserMsg { get; set; }
        /// <summary>
        /// thông báo lỗi cho dev
        /// </summary>
        public string DevMsg { get; set; }
        /// <summary>
        /// constructor khởi tạo danh sách thông báo cho người dùng
        /// </summary>
        public ServiceResult()
        {
            this.UserMsg = new List<string>();
        }
    }
}
