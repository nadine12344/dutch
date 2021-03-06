﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;

        }
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
                _mailService.sendMessage("nano_mohh98@yahoo.com", model.Subject, $"From:{model.Name}{model.Email},Message:{model.Message}");

                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
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