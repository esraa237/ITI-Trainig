using Microsoft.AspNetCore.Mvc;
using Third_version.BLL;
using Third_version.Models;

namespace Third_version.Controllers
{
    public class StudentController : Controller
    {
        ITIContext dp = new ITIContext();
        public IActionResult Details(int id)
        {
            Student std = dp.Students.FirstOrDefault(a => a.Id == id);
            if(std == null) 
            {
                return NotFound("student not found");
            }
            return View(std);
        }
        [HttpGet]
        public IActionResult Create()
        {
            DepartmentBLL model = new DepartmentBLL();
            ViewBag.departments = model.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            dp.Students.Add(student);
            dp.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return BadRequest();
            Student student = dp.Students.SingleOrDefault(a => a.Id == id);
            if (student == null) return NotFound();
            DepartmentBLL model = new DepartmentBLL();
            ViewBag.departments = model.GetAll();
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student std)
        {
            dp.Students.Update(std);
            dp.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return BadRequest();
            Student student = dp.Students.SingleOrDefault(a => a.Id == id);
            if (student == null) return NotFound();
            dp.Students.Remove(student);
            dp.SaveChanges();
            return RedirectToAction("index");
        }
        
        public IActionResult Index()
        {
            var model = dp.Students.ToList();
            DepartmentBLL model2 = new DepartmentBLL();
            ViewBag.departments = model2.GetAll();
            return View(model);
        }
    }
}
