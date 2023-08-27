using Microsoft.AspNetCore.Mvc;
using Second_project.Models;

namespace Second_project.Controllers
{
    public class DepartmentController : Controller
    {
        public ViewResult Details()
        {
            ITIContext dp = new ITIContext();
            Department dep = dp.Departments.FirstOrDefault(b => b.DeptId == 1);
            return View(dep);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
