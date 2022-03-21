using Microsoft.AspNetCore.Mvc;
using Proj3_Ali.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace Proj3_Ali.Controllers
{
    public class HomeController : Controller
    {
        private RegistrationContext _context;
        public HomeController(RegistrationContext registrationContext)
        {
            _context = registrationContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrations(string searchString) // routing with search String
        {
            var list = from s in _context.Registrations
                       select s; // Select all Data from Registrations table
            if (!String.IsNullOrEmpty(searchString)) // if applying search filter
            {
                // filter list by search string
                list = list.Where(s => s.LastName.Contains(searchString));
            }

            // pass list data to view
            return View("Registrations", list);
        }



        [HttpPost]
        public IActionResult Submit(RegisteredUser registeredUser)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    registeredUser.RegistrationDate = DateTime.Now;
                    _context.Add(registeredUser);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    return View("Error");
                }
                //Prepares submit page for rendering temporary data
                // current code has error now?
                //registeredUser.RegistrationDate = DateTime.Now;
                RegistrationViewModel model = new RegistrationViewModel();
                model.UserInfo = registeredUser;
                return View("Submit", model);
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
