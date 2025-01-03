using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var blog = c.Blogs.Find(id);
            c.Blogs.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("BlogGetir", blog);
        }
        public ActionResult BlogGuncelle(Blog blog)
        {
            var blg = c.Blogs.Find(blog.ID);
            blg.Aciklama = blog.Aciklama;
            blg.Baslik = blog.Baslik;
            blg.BlogImage = blog.BlogImage;
            blg.Tarih = blog.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }

    }
}