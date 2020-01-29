using Microsoft.AspNetCore.Mvc;
using FirstProject.Models;

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
        

        //Used here for dependency injection;
        private IEmployeeRepository _empRepo;
        public HomeController(IEmployeeRepository empRepository)
        {
            _empRepo = empRepository;
        }

        public string Index()
        {
            return _empRepo.GetEmployee(1).Name;
        }

        public JsonResult GetDetails()
        {
            var model = _empRepo.GetEmployee(1);
            return Json(model);
        }

         public ObjectResult GetDetailsObject()
        {
            var model = _empRepo.GetEmployee(1);
            return new ObjectResult(model);
        }   

        //Home/GetDetailsView
        public ViewResult GetDetailsView()
        {
            var model = _empRepo.GetEmployee(3);
            var modelVB = _empRepo.GetEmployee(1);

            var modelST = _empRepo.GetEmployee(2);
            
            ViewData["Title"] = "View Data Title";
            ViewData["Empdata"] = model;

            ViewBag.TitleVB = "View Bag Title";
            ViewBag.EmpdataVB = modelVB;

            return View(modelST);
        }

        //Home/GetDetailsViewDiscovery
        public ViewResult GetDetailsViewDiscovery()
        {
            var model = _empRepo.GetEmployee(3);
            return View("TEST");
        }

        //Home/GetDetailsViewDiscoveryabsolute
        public ViewResult GetDetailsViewDiscoveryabsolute()
        {
            var model = _empRepo.GetEmployee(3);
            return View("Views/Employee/TESTEmployee.cshtml");
        }     

        //Used when we inherit from the Controller class
        // public JsonResult Index()
        // {
        //     return Json(new { id = 1, name = "Pragim" });
        // }
    }
}