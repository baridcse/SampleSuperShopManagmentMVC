using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shopManagment.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
      
        public ActionResult LoginView()
        {
            return View("Login");
        }
        public ActionResult LoginCheek(string UsernameTextbox, string PasswordTextbox)
        {

            string name = UsernameTextbox;
            string password= PasswordTextbox;

            if (name == "barid" && password == "123")
            {
                return RedirectToAction("sell", "Home");
            }
            else
            {
                ViewData["isWrong"] = "true";
                return View("Login");
            }

        }
    }
}