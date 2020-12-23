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
            AdvertsPage advertisements_page = new AdvertsPage(db.Cities.ToList(), db.Advertisements.ToList());
            return View(advertisements_page);
        }

        public IActionResult Page_404()
        {
            return View();
        }
        public IActionResult Advertisement_Page()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create_Advert_Page()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create_Advert_Page(string website, string name, string city, string brand, string model, string os, string firmware, string display, string color, int battery_capacity, int charge_power, int ram, int rom, string replacement_phone, string other, int time_of_use)
        {
            if (website != "" &&
               name != "" &&
               city != "" &&
               brand != "" &&
               model != "" &&
               os != "" &&
               firmware != "" &&
               display != "" &&
               color != "" &&
               battery_capacity != 0 &&
               charge_power != 0 &&
               ram != 0 &&
               rom != 0 &&
               replacement_phone != "" &&
               time_of_use != 0)
            {
                website = website.ToLower();
                website = website.Substring(0, 1).ToUpper() + website.Substring(1);
                if (db.SocialNetworks.SingleOrDefault(x => x.Name == website) == null)
                {
                    SocialNetwork sn = new SocialNetwork();
                    sn.Name = website;
                    db.SocialNetworks.Add(sn);
                    db.SaveChanges();
                }
                city = city.ToLower();
                city = city.Substring(0, 1).ToUpper() + city.Substring(1);
                if (db.Cities.SingleOrDefault(x => x.Name == city) == null)
                {
                    City City = new City();
                    City.Name = city;
                    db.Cities.Add(City);
                    db.SaveChanges();
                }              
                Phone phone = new Phone();
                phone.Brand = brand;
                phone.Model = model;
                phone.OS = os;
                phone.Firmware = firmware;
                phone.Display = display;
                phone.Color = color;
                phone.BatteryCapacity = battery_capacity;
                phone.ChargePower = charge_power;
                phone.RAM = ram;
                phone.ROM = rom;
                db.Phones.Add(phone);
                db.SaveChanges();
                Contact contact = new Contact();
                contact.Account = name;
                contact.SocialNetwork = db.SocialNetworks.Single(x => x.Name == website);
                contact.City = db.Cities.Single(x => x.Name == city);

                db.Contacts.Add(contact);
                db.SaveChanges();
                Advertisement advert = new Advertisement();
                advert.Phone = db.Phones.Single(x => x == phone);
                advert.Other = other;
                advert.TimeOfUse = time_of_use;
                advert.ReplacementPhone = replacement_phone;
                advert.Contact = db.Contacts.Single(x => x == contact);
                advert.DateOfAnnouncement = DateTime.Now;
                db.Advertisements.Add(advert);
                db.SaveChanges();

                return RedirectToAction("Create_Page");
            }
            else
                return RedirectToAction("Create_Error");
        }
        public IActionResult Create_Page()
        {
            return View();
        }
        public IActionResult Create_Error()
        {
            return View();
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
