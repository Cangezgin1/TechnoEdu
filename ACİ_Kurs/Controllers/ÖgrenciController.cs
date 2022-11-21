using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACİ_Kurs.Controllers
{
    public class ÖgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
