using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proj3_Ali.Models;

namespace Proj3_Ali.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Submit(RegisteredUser registeredUser)
        {
            //Server-side validation
            if (ModelState.IsValid)
            {
                //Prepares submit page for rendering temporary data
                ViewBag.FirstName = registeredUser.FirstName;
                ViewBag.LastName = registeredUser.LastName;
                ViewBag.Zip = registeredUser.Zip;
                ViewBag.Email = registeredUser.Email;
                ViewBag.PhoneNum = registeredUser.PhoneNum;
                ViewBag.YearlyIncome = registeredUser.YearlyIncome;
                ViewBag.LoanTerm = registeredUser.LoanTerm;
                ViewBag.CreditCheck = registeredUser.CreditCheck;
                ViewBag.PrimaryContact = registeredUser.PrimaryContact;
                ViewBag.Username = registeredUser.Username;
                ViewBag.Password = registeredUser.Password;
                return View();
            }
            //Render this view if server-side validation fails
            else
            {
                return View("Error");
            }
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
