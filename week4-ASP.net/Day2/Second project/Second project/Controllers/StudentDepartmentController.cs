using Microsoft.AspNetCore.Mvc;
using Second_project.Models;

namespace Second_project.Controllers
{
    public class StudentDepartmentController : Controller
    {
        public ViewResult Details()
        {
            ITIContext dp = new ITIContext();
            Student std = dp.Students.FirstOrDefault(a => a.Id == 1);
            Department dep = dp.Departments.FirstOrDefault(b => b.DeptId == 1);
            StudentDepartmentViewModel model = new StudentDepartmentViewModel() { student = std, department = dep };
            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
