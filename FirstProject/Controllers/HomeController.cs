using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        //If we do not inherit it from  Controller base class;
        // public string Index()
        // {
        //     //return this.ToString();
        //     //return "My First MVC Controller Action";
        // }

        //Used when we inherit from the Controller class
        public JsonResult Index()
        {
            return Json(new { id = 1, name = "Pragim" });
        }
    }
}