using Portfolyom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Portfolyom.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin login)
        {
            var kullanici = c.Admins.FirstOrDefault(x => x.UserName == login.UserName && x.Password == login.Password);
            if (kullanici != null)
            {
                FormsAuthentication.SetAuthCookie(kullanici.UserName, false);
                Session["Username"] = kullanici.UserName.ToString();
                return RedirectToAction("Home", "AdminControl");
            }
            else
            {
                return View();
            }

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddDays(-1);
            return RedirectToAction("Index", "Login");
        }
    }
}