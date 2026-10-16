using Microsoft.AspNetCore.Mvc;

namespace WebEc2.Controllers
{
    public class VendorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
