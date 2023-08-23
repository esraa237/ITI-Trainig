using Microsoft.AspNetCore.Mvc;
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
              return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            dp.Students.Add(student);
            dp.SaveChanges();
            return RedirectToAction("Index");

        }
        //[HttpGet]
        //public IActionResult Edit()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Edit(Student student)
        //{
        //    dp.Students.Update(student);
        //    dp.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        public IActionResult Index()
        {
            var model = dp.Students.ToList();
            return View(model);
        }
    }
}
