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
        private readonly StudentskiDomContext _context;

        public HomeController(ILogger<HomeController> logger, StudentskiDomContext context)
        {
            _logger = logger;
            _context = context;

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
        public ActionResult PosaljiPrijavuAction(IFormCollection forma)
        {
            
            string prezime = forma["fldPrezime"].ToString();
            string ime = forma["fldIme"].ToString();
            long jmbg = long.Parse(forma["fldJmbg"].ToString());
            DateTime datumRodjenja = StringToDateTime(forma["fldDatumRodjenja"].ToString());
            string mjestoRodjenja = forma["fldMjestoRodjenja"].ToString();
            int mobitel = Int32.Parse(forma["fldMobitel"].ToString());
            string polValue = forma["pol"].ToString();
            Pol pol = Pol.Musko;

            if (polValue.Equals("Žensko"))
            {
                pol = Pol.Zensko;
            }

            string email = forma["fldEmail"].ToString();

            string adresa = forma["fldAdresa"].ToString();
            string kanton = forma["dlKanton"].ToString();
            string opcina = forma["fldOpcina"].ToString();
            
            string fakultet = forma["dlFakultet"].ToString();
            int ciklusStudija = Int32.Parse(forma["dlCiklusStudija"].ToString());
            int brojIndeksa = Int32.Parse(forma["fldBrojIndeksa"].ToString());
            int godinaStudija = Int32.Parse(forma["dlGodinaStudija"].ToString());

            SkolovanjeInfo skolovanjeInfo = new SkolovanjeInfo(fakultet, ciklusStudija, brojIndeksa, godinaStudija);
            PrebivalisteInfo prebivalisteInfo = new PrebivalisteInfo(adresa, kanton, opcina);
            LicniPodaci licniPodaci = new LicniPodaci(prezime, ime, mjestoRodjenja, pol, email, jmbg, datumRodjenja, mobitel, "");

            ZahtjevZaUpis zahtjevZaUpis = new ZahtjevZaUpis();
            zahtjevZaUpis.LicniPodaci = licniPodaci;
            zahtjevZaUpis.PrebivalisteInfo = prebivalisteInfo;
            zahtjevZaUpis.SkolovanjeInfo = skolovanjeInfo;


            _context.LicniPodaci.Add(licniPodaci);
            _context.PrebivalisteInfo.Add(prebivalisteInfo);
            _context.SkolovanjeInfo.Add(skolovanjeInfo);

            _context.ZahtjevZaUpis.Add(zahtjevZaUpis);
            
            _context.SaveChanges();

            return RedirectToAction("Login", "Home");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
