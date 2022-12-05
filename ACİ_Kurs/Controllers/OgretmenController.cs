using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ACİ_Kurs.Controllers
{
    public class OgretmenController : Controller
    {
        Context c = new Context();

        OgretmenlerManager om = new OgretmenlerManager(new EfOgretmenlerDal());
        OgretmenlerValidator ogretmenvalidator = new OgretmenlerValidator();


        public IActionResult OgrenciListesi()        // Öğrenci Listesi
        {
            var values = c.ogrencilers.ToList();
            return View(values);
        }




        public IActionResult OgretmenListesi()   // Öğretmen Listesi
        {
            var values = c.ogretmenlers.ToList();
            return View(values);
        }





        [HttpGet]
        public IActionResult OgretmenEkle()     // Öğretmen Ekleme
        {
            return View();
        }
        [HttpPost]
        public IActionResult OgretmenEkle(Ogretmenler p)
        {
            FluentValidation.Results.ValidationResult result = ogretmenvalidator.Validate(p);

            if (result.IsValid)
            {
                om.AddOgretmen(p);
                return RedirectToAction("OgretmenListesi", "Ogretmen");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        




        public IActionResult DeleteOgretmen(int id)
        {
            var values = c.ogretmenlers.Find(id);
            om.DeleteOgretmen(values);
            c.SaveChanges();
            return RedirectToAction("OgretmenListesi", "Ogretmen");
        }





        [HttpGet]
        public IActionResult UpdateOgretmen(int id)
        {
            var values = c.ogretmenlers.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateOgretmen(Ogretmenler ogretmenler)
        {
            om.UpdateOgretmen(ogretmenler);
            c.SaveChanges();
            return RedirectToAction("OgretmenListesi","Ogretmen");
        }


    }
}
