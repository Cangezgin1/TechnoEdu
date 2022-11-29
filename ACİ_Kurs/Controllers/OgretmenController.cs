using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACİ_Kurs.Controllers
{
    public class OgretmenController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var values = c.ogrencilers.ToList();
            return View(values);
        }

    }
}
