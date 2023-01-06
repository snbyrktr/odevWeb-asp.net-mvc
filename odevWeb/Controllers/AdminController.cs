using odevWeb.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odevWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }
        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.AnaSayfas.Find(id);
            return View("AnaSayfaGetir", ag);
        }
        public ActionResult AnaSayfaGuncelle(AnaSayfa x)
        {
            var ag = c.AnaSayfas.Find(x.id);
            ag.isim = x.isim;
            ag.profil = x.profil;
            ag.iletisim = x.iletisim;
            ag.unvan = x.unvan;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
         
        public ActionResult ikonListesi()
        {
            var deger = c.ikonlars.ToList();
            return View(deger);
        }
    }
}