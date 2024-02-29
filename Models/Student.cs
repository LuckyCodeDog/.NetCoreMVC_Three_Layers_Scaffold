using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// 学生姓名
        /// </summary>
        [MaxLength(20)]
        public string? Name { get; set; }
        /// <summary>
        /// 学生年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 学生性别
        /// </summary>
        public bool Sex { get; set; }
        /// <summary>
        /// 家庭地址
        /// </summary>
        [MaxLength(500)]
        public string? Address { get; set; }

        [MaxLength(18)]
        public string? CardId { get; set; }
    }
}
