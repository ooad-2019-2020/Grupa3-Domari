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
            Response.WriteAsync("JA SAM EMIR");
            Response.WriteAsync("E neka si");
            Response.WriteAsync("Ma nisi");
            Response.WriteAsync("Promjena 23.05.2020, 14:13");
            Response.WriteAsync("Nadam se da sad radi");
            Response.WriteAsync("Meni radi jedva");
            Response.WriteAsync("Valjda.");
            Response.WriteAsync("Izgleda da radi");
            Response.WriteAsync("Nadam se");
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
