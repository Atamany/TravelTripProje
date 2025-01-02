using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(4).ToList();
            return View(degerler);
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Skip(2).Take(1).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var degerler = c.Blogs.ToList();
            return PartialView(degerler);
        }
    }
}