using Microsoft.AspNetCore.Mvc;

namespace WebEc2.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public PartialViewResult test()
        {
            return PartialView("_modal");
        }
        public RedirectResult toGoogle()
        {
            return Redirect("https://www.google.com/");
        }
        public RedirectToActionResult toIndex()
        {
            return RedirectToAction("index","Home");
        }
        public ContentResult text()
        {
            return Content("hello bro ra");
        }
        
        //selectorname

        [ActionName("GetJsons")]
        public JsonResult GetJson()
        {
            return Json(
                new
                {
                    name = "hong",
                    age = 12
                });
        }
        [NonAction]
        public string GetName(string? name, int age)
        {
            return "Hello, " + name + ". Your age is " + age;
        }
        public string GetExample()
        {
            return GetName("Bla Bla", 30);
        }

        //actionverb get/post
        //[HttpGet]
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string name)
        {
            return View();
        }
    }
}