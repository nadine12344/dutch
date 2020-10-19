using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
          
            ViewBag.Title = "Contacts";

            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            ViewBag.Title = "Contacts";
            if (ModelState.IsValid)
            {

            }
            else
            {

            }
            return View();
        }

        public IActionResult Aboutus()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}