using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_GO.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
           
            return View();
        }
        public ActionResult Log()
        {
            return View();
        }
        public ActionResult Donar()
        {
            return View();
        }
    }
}