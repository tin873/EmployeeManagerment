using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagerment.Model
{
    [Table("Employee")]
    public class Employee : BaseEntities
    {
        /// <summary>
        /// id nhân viên
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// mã nhân viên
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string EmployeeCode { get; set; }
        /// <summary>
        /// ho
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// tên
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// địa chỉ
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// số điện thoại
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Khóa ngoại
        /// </summary>
        public Guid DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
