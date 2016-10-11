using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using lab4.Models;
using Microsoft.Extensions.DependencyInjection;

namespace lab4.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            ViewData["hour"] = DateTime.Now.ToString("hh");
            ViewData["minutes"] = DateTime.Now.ToString("mm", CultureInfo.InvariantCulture);
            ViewData["day"] = DateTime.Now.DayOfWeek.ToString();
            ViewData["year"] = DateTime.Now.Year.ToString();
            ViewData["month"] = DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture);
            ViewData["date"] = DateTime.Now.Day.ToString();
            ViewData["ampm"] = DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
            ViewData["daystillend"] = (365 - DateTime.Now.DayOfYear);

            return View();
        }

        public IActionResult PersonInfo()
        {
            ViewData["Message"] = "Welcome to the Person Info Page";
            personinfo josh = new personinfo {firstName = "Josh", lastname="Friedman", age = 21, birthDate = "12/13/1994"};
            return View();
        }

        static PersonRepo person = new PersonRepo();
       
        [HttpPost]
        public IActionResult Create(IEnumerable<personinfo> per)
        {
            List<personinfo> personList = new List<personinfo>(per);

            //if (ModelState.IsValid)
            // {
            // personinfo.PersonList.Add(newPerson);
            //  return RedirectToAction("Index");
            //}
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Error()
        {
            return View();
        }

        
    }
}
