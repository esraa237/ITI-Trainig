using Microsoft.AspNetCore.Mvc;

namespace firstProject.Controllers
{
    public class FirstController : Controller
    {
        //First/Show
        public string Show()
        {
            return "MVC";
        }
        //First/Add
        public int Add()
        {
            return 200;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
