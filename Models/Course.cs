using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Courses")]
    public class Course
    {
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// 课程名称。
        /// </summary>
        [MaxLength(200)]
        public string? Name { get; set; }
        /// <summary>
        /// 课程简介。
        /// </summary>
        [MaxLength(500)]
        public string? Summary { get; set; }
    }
}
