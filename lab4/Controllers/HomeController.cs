using System;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using lab4.Models;

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
            ViewData["Heading"] = "Person Info";
            person person = new person()
            {
                firstName = "First Name",
                lastname = "Last Name",
                birthDate = "10/10/2000",
                age = 16
            };


            return View(person);
        }



        [HttpPost]
        public IActionResult PersonInfo(person person)
        {

            if (ModelState.IsValid)
            {
                return View("PersonInfo");


            }
            return View("Error");

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
