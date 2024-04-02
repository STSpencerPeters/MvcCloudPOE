using Microsoft.AspNetCore.Mvc;

namespace MvcCloudPOE.Controllers
{
    public class ContactUs : Controller
    {

        private readonly List<Models.ContactUs> _contact;

        public ContactUs()
        {
            _contact = new List<Models.ContactUs>
            {
                new Models.ContactUs{ Name = "KhumaloCraft", Number = 0712368954, Address = "54 Phil Drive", ImageUrl = "~/images/GoogleMaps.png"},
            };
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
