using Microsoft.AspNetCore.Mvc;
using WebEc2.Models;

namespace WebEc2.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var data = new
            {
                Title = "Category",
                Massage = "Hello"

            };
            ViewBag.Data = data;
            ViewBag.Message = "helollo";



            var categories = new List<Category>(
            new Category[] {
                new Category { CategoryId = 1, CategoryName = "Electronics", Description = "Electronic items", IsActive = true },
                new Category { CategoryId = 2, CategoryName = "Clothing", Description = "Apparel and clothing items", IsActive = true },
               }
            );

            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        public object Test()
        {
            return new { message = "hello" };
        }
       

    }
}
