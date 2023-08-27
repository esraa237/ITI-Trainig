using Microsoft.AspNetCore.Mvc;
using Second_project.Models;

namespace Second_project.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Details()
        {
            ITIContext dp=new ITIContext();
            Student std = dp.Students.FirstOrDefault(a => a.Id == 1);
            return View(std);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
