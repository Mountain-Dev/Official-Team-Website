using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;


namespace Website.Controllers
{
    public class HomeController : Controller
    {
        List<Project> ProjectList;

        public HomeController()
        {
            ProjectList = new List<Project>();

            ProjectList.Add(new Project()
            {
                Title = "Team website",
                Description = "Thsi was our first collaboratively made website.",
                Link = "https://github.com/Mountain-Dev/Team-Website"
            });

            ProjectList.Add(new Project()
            {
                Title = "Official team website",
                Description = "The refined version that we are planning to use.",
                Link = "https://github.com/Mountain-Dev/Team-Website"
            });
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(ProjectList);
        }

        public ActionResult About()
        {
            return View(ProjectList);
        }

        public ActionResult Projects()
        {
            return View(ProjectList);
        }

        public ActionResult Contact()
        {
            return View(ProjectList);
        }
    }
}