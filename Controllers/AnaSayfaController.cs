using Portfolyom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolyom.Controllers
{
    public class AnaSayfaController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View(c.CartInfos.ToList());
        }

        public ActionResult About()
        {
            return View(c.Abouts.ToList());
        }

        public ActionResult Projects()
        {
            return View(c.Projects.ToList());
        }

        public ActionResult Contact()
        {
            return View();
        }


    }
}