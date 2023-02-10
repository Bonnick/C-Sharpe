using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Application_Eleven___Part_Assignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page - Academy of Learning";

            return View();
        }
        public ActionResult Instructor( int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };
            return View(dayTimeInstructor);
        }
        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Rick",
                    LastName = "Ramen"
                },
                new Instructor
                {
                    IDependencyResolver = 3,
                    FirstName = "Adam",
                    LastName = "Smithsonian"
                }
            };
            return View(instructors);
        }
    }
}