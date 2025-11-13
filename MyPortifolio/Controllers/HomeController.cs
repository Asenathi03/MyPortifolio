using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortifolio.Models;

namespace MyPortifolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }



        public ActionResult About()
        {
            ViewBag.Title = "About Me";
            return View();
        }

        public ActionResult Projects()
        {
            var projects = new List<Project>
            {
                new Project { Title = "Student Management System", Description = "A web app to manage student records using ASP.NET MVC and SQL Server.", Technologies = "C#, ASP.NET MVC, SQL Server" },
                new Project { Title = "E-Commerce Platform", Description = "An online shop using .NET Core and Razor Pages.", Technologies = "C#, .NET Core, Razor Pages, Bootstrap" }
            };
            return View(projects);
        }

        public ActionResult Skills()
        {
            var skills = new List<Skill>
            {
                new Skill { Name = "C#", Level = "Advanced" },
                new Skill { Name = "ASP.NET MVC", Level = "Intermediate" },
                new Skill { Name = "SQL Server", Level = "Intermediate" },
                new Skill { Name = "JavaScript / jQuery", Level = "Intermediate" },
                new Skill { Name = "HTML / CSS / Bootstrap", Level = "Advanced" }
            };
            return View(skills);
        }

        public ActionResult Education()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactForm form)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Thank you for contacting me! I will get back to you soon.";
                ModelState.Clear();
            }
            return View();
        }
    
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
