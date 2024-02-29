using IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceContainer;
using UILayer.Models;

namespace UILayer.Controllers
{
    public class StudentController : Controller
    {

        private readonly IStudentService studentService = IOCContainerService.Resolve<IStudentService>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            //获取所有学生信息
            var students = await studentService.Query(s => true).ToListAsync();

            List<StudentViewModel> studentView = students.Select(student => new StudentViewModel
            {
                StudentId = student.Id,
                Name = student.Name,
                Sex = student.Sex,
                Address = student.Address,
                Age = student.Age,
                CardId = student.CardId,
            }).ToList();
            return View(studentView);
        }
    }
}
