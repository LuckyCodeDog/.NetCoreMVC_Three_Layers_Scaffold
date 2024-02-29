using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Scores")]
    public class Score
    {
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// 分数。
        /// </summary>
        public double Mark { get; set; }
        /// <summary>
        /// 学期。
        /// </summary>
        [MaxLength(200)]
        public string? Semester { get; set; }
        /// <summary>
        /// 课程 Id。
        /// </summary>
        [ForeignKey(nameof(Course))]
        public Guid CourseId { get; set; }
        public Course? Course { get; set; }
        /// <summary>
        /// 学生 Id。
        /// </summary>
        [ForeignKey(nameof(Student))]
        public Guid StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
