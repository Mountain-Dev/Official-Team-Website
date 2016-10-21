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
                Title = "HEAJEHSA",
                Description = "asdasdasdasdasd",
                Link = "asd"
            });
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View(ProjectList);

        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}