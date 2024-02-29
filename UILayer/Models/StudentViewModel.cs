using System.ComponentModel.DataAnnotations;

namespace UILayer.Models
{
    public class StudentViewModel
    {
        public Guid StudentId { get; set; }
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "{0}不可为空。")]
        public string? Name { get; set; }
        [Display(Name = "年龄")]
        [Range(18, 85)]
        [Required(ErrorMessage = "{0}不可为空。")]
        public int Age { get; set; }
        [Display(Name = "性别")]
        public bool Sex { get; set; }
        [Display(Name = "家庭地址")]
        public string? Address { get; set; }
        [Display(Name = "身份证号码")]
        [Required(ErrorMessage = "{0}不可为空。")]
        [MaxLength(18)]
        public string? CardId { get; set; }
    }
}
