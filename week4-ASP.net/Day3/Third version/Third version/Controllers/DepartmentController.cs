using Microsoft.AspNetCore.Mvc;
using Third_version.Models;

namespace Third_version.Controllers
{
    public class DepartmentController : Controller
    {
        ITIContext dp = new ITIContext();
        public IActionResult Details(int id)
        {
            Department dept = dp.Departments.FirstOrDefault(a => a.DeptId == id);
            if (dept == null)
            {
                return NotFound("Department not found");
            }
            return View(dept);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            dp.Departments.Add(department);
            dp.SaveChanges();
            return RedirectToAction("Index");

        }
        
        public IActionResult Index()
        {
            var model = dp.Departments.ToList();
            return View(model);
        }
    
    }
}
