using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACİ_Kurs.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();


        [HttpGet]
        public IActionResult OgrenciLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OgrenciLogin(Ogrenciler p)
        {
            var values = c.ogrencilers.FirstOrDefault(x=>x.KullanıcıAdı==p.KullanıcıAdı && x.Sifre==p.Sifre);

            if (values != null)
            {
                return RedirectToAction("Index", "Ogrenci");
            }
            else
                return View();
        }




        [HttpGet]
        public IActionResult OgretmenLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OgretmenLogin(Ogretmenler p)
        {
            var values = c.ogretmenlers.FirstOrDefault(x => x.KullanıcıAdı == p.KullanıcıAdı && x.Sifre == p.Sifre);

            if (values != null)
            {
                return RedirectToAction("OgretmenListesi", "Ogretmen");  // Öğretmen için Panel yapılacak
            }
            else
                return View();
        }
    }
}