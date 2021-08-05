namespace EmployeeManagerment.Model
{
    public class EmployeeManagermentEnums
    {
    }
    public enum ResultCode
    {
        /// <summary>
        /// Dữ liệu hợp lệ
        /// </summary>
        IsValid = 100,

        /// <summary>
        /// Dữ liệu không hợp lệ
        /// </summary>
        NotValid = 400,

        /// <summary>
        /// Thành công
        /// </summary>
        Success = 200,

        /// <summary>
        /// Lỗi
        /// </summary>
        Exeption = 500,

        /// <summary>
        /// không tìm thấy dữ liệu
        /// </summary>
        NotFound = 404,

        /// <summary>
        /// không có nội dung
        /// </summary>
        NoContent = 204,
    }
}
