using Microsoft.AspNetCore.Mvc;

namespace Third_version.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            //Response.Cookies.Append("id", "3");
            //Response.Cookies.Append("name", "esraa");
            //Response.Cookies.Append("id", "10");
            //Response.Cookies.Append("name", "esra");
            HttpContext.Session.SetInt32("id", 5);
            HttpContext.Session.SetString("name", "Esraa");
            ViewBag.id = 3;
            ViewBag.name = "esraa";
            return View();

        }
        public IActionResult Display()
        {
            //int id = int.Parse(Request.Cookies["id"]);
            //string name = Request.Cookies["name"];
            int? id = HttpContext.Session.GetInt32("id");
            string name= HttpContext.Session.GetString("name");
            ViewBag.id = id;
            ViewBag.name = name;
            return View();
        }
    }
}
