using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NE_LAGAET_CHESTNO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NE_LAGAET_CHESTNO.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Контекст БД
        /// </summary>
        Context db;

        public HomeController(Context context)
        {
            this.db = context;
        }

        public IActionResult Advertisements_Page()
        {
            AdvertsPage advertisements_page = new AdvertsPage(this.db.Cities.ToList(), this.db.Advertisements.ToList());
            return View(advertisements_page);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
