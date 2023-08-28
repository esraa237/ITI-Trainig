using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.Intrinsics.Arm;
using Third_version.BLL;
using Third_version.Migrations;
using Third_version.Models;


namespace Third_version.Controllers
{
    public class StudentController : Controller
    {
        IStudent db;
        public StudentController(IStudent _dp)
        {
            db = _dp;
        }
        public IActionResult Details(int id)
        {
            Student std = db.GetById(id);
            if(std == null) 
            {
                return NotFound("student not found");
            }
            return View(std);
        }
        public bool IsEqual(string Email)
        {
            int c=0;
            foreach(var s in db.GetAll())
            {
                if (s.Email == Email) c++;
            }
            if(c > 0) return true;
            else return false;
        }
        [AcceptVerbs("Post","Get")]
        public JsonResult IsEmailAvailable(string Email)
        {
            bool isExist=IsEqual(Email);
            if (isExist) return Json(data: false);
            else return Json(data: true);
        }
        [HttpGet]
        public IActionResult Create()
        { 
            DepartmentBLL model = new DepartmentBLL();
            ViewBag.departments =new SelectList(model.GetAll(),"DeptId","DeptName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Add(student);
                return RedirectToAction("Index");
            }
            DepartmentBLL model = new DepartmentBLL();
            ViewBag.departments = new SelectList(model.GetAll(), "DeptId", "DeptName");
            return View(student);
            
        }

        public IActionResult Edit(int? id)
        { 
            Student student = db.GetById(id.Value);
            if (student == null) return NotFound();
            DepartmentBLL model = new DepartmentBLL();
            ViewBag.departments = model.GetAll();
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student std)
        {
            db.Update(std);
            return RedirectToAction("index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            db.Delete(id.Value);
            return RedirectToAction("index");
        }
        
        public IActionResult Index()
        {
            var model =db.GetAll();
            DepartmentBLL model2 = new DepartmentBLL();
            ViewBag.departments = model2.GetAll();
            return View(model);
        }
     
        

       
    }
}
