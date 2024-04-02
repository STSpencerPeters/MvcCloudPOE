using Microsoft.AspNetCore.Mvc;

namespace MvcCloudPOE.Controllers
{
    public class MyWork : Controller
    {
        private readonly List<Models.MyWork> _works;

        public MyWork()
        {
            _works = new List<Models.MyWork>
            {
                new Models.MyWork{ Id = 1, Name = "Darren Mac", Type = "Paper Crafts", Price = 700.00, ImageUrl = "~/images/PaperCrafts.jpeg"},
                new Models.MyWork{ Id = 2, Name = "Stacy Pruis", Type = "Knitting", Price = 600.00, ImageUrl = "~/images/Knitting.jpeg"},
                new Models.MyWork{ Id = 3, Name = "Jana Modron", Type = "Origami", Price = 500.00, ImageUrl = "~/images/Origami.jpeg"}
            };
        }

        public IActionResult Index()
        {
            return View(_works);
        }
    }
}
