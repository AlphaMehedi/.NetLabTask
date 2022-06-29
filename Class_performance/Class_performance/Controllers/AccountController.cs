using System.Linq;
using System.Web.Mvc;
using Class_performance.Models;

namespace Class_performance.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Membership model)
        {
            using(var context=new officeEntities())
            {
                bool isValid = context.Users.Any();
            }
            return View();
        }

       public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User model)
        {
            using (var context = new officeEntities())
            {
                context.Users.Add(model);
                context.SaveChanges();    
            }
            return RedirectToAction("Login");
        }

       
    }
}