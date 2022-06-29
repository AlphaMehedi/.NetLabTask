using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_GO.Controllers
{
    public class RecepController : Controller
    {
        // GET: Recep
        public ActionResult Receplist()
        {
            ViewBag.name = "Tanvir Ahmed";
            string[] names = new string[3];
            names[0] = "mehedi";
            names[1] = "Mahi";
            names[2] = "Tina ";

            ViewBag.Names = names;

            return View();
        }
    }
}