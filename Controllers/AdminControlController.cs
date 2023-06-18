using Portfolyom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolyom.Controllers
{
    public class AdminControlController : Controller
    {
        Context c = new Context();
        [Authorize]
        public ActionResult Home()
        {
            return View(c.CartInfos.ToList());
        }

        [Authorize]
        public ActionResult HomeIcerikSil(int id)
        {
            var bul = c.CartInfos.Find(id);
            c.CartInfos.Remove(bul);
            c.SaveChanges();
            return RedirectToAction("Home", "AdminControl");
        }
        [HttpGet]
        [Authorize]
        public ActionResult HomeGuncelle(int id)
        {
            var bul = c.CartInfos.Find(id);
            return View(bul);
        }
        [HttpPost]
        [Authorize]
        public ActionResult HomeGuncelle(CartInfo p)
        {
            var data = c.CartInfos.Where(x => x.Id == p.Id).SingleOrDefault();
            data.Title = p.Title;
            data.Id = p.Id;
            data.Image = p.Image;
            c.SaveChanges();
            return RedirectToAction("Home", "AdminControl");
        }

        //--------------------------------------------------------------------Home Kismi

        [Authorize]
        public ActionResult About()
        {
            return View(c.Abouts.ToList());
        }

        [Authorize]
        public ActionResult AboutIcerikSil(int id)
        {
            var bul = c.Abouts.Find(id);
            c.Abouts.Remove(bul);
            c.SaveChanges();
            return RedirectToAction("Home", "AdminControl");
        }

        [HttpGet]
        [Authorize]
        public ActionResult AboutGuncelle(int id)
        {
            var bul = c.Abouts.Find(id);
            return View(bul);
        }

        [HttpPost]
        [Authorize]
        public ActionResult AboutGuncelle(About p)
        {
            var data = c.Abouts.Where(x => x.Id == p.Id).SingleOrDefault();
            data.Id = p.Id;
            data.Image = p.Image;
            data.About_Desc = p.About_Desc;
            data.About_Desc = p.About_Desc;
            c.SaveChanges();
            return RedirectToAction("Home", "AdminControl");
        }

        //--------------------------------------------------------------------About Kismi
        [Authorize]
        public ActionResult Project()
        {
            return View(c.Projects.ToList());
        }

        [Authorize]
        public ActionResult Contact()
        {
            return View(c.Contacts.ToList());
        }
    }
}