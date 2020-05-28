using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentskiDom.Models;

namespace StudentskiDom.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ObrazacZaUpis()
        {
            return View();
        }

     
        [HttpPost]
        public ActionResult LoginClick(IFormCollection forma)
        {
            string password = forma["fldPassword"];
            string username = forma["fldUsername"];
            if (username.ToLower().Equals("uprava"))
            {
                return RedirectToAction("Uprava", "Uprava");
            }else if (username.ToLower().Equals("restoran"))
            {
                return RedirectToAction("Restoran", "Restoran");
            }else if (username.ToLower().Equals("student"))
            {
                return RedirectToAction("Student", "Student");
            }
            return null;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
