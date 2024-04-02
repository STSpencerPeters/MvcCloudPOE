using Microsoft.AspNetCore.Mvc;

namespace MvcCloudPOE.Controllers
{
    public class AboutUs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
