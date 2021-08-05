using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagerment.Model
{
    [Table("Department")]
    public class Department : BaseEntities
    {
        public Department ()
        {
            Employees = new HashSet<Employee>();
        }
        /// <summary>
        /// id phòng ban
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// mã phòng ban
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string DepartmentCode { get; set; }
        /// <summary>
        /// tên phòng ban
        /// </summary>
        public string DepartmentName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
