using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Third_version.BLL;
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
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null) return BadRequest();
            Department dep = dp.Departments.SingleOrDefault(a => a.DeptId == id);
            if (dep == null) return NotFound();
            return View(dep);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int? id)
        {
            if (id == null) return BadRequest();
            Department dep = dp.Departments.SingleOrDefault(a => a.DeptId == id);
            if (dep == null) return NotFound();
            dp.Departments.Remove(dep);
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
