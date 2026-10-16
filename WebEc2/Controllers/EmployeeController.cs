using Microsoft.AspNetCore.Mvc;
using WebEc2.Models;

namespace WebEc2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string fistName, string lastName, string phone)
        {
            Console.WriteLine("fist Name" + fistName);
            Console.WriteLine("last Name" + lastName);
            Console.WriteLine(" phone" + phone);
            return View();


        }

        [HttpGet]
        public IActionResult Store()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Store(Employee model)
        {

            ViewData["Employee"] = model;
            return View();
        }
    }
}
