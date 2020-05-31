using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing;
using StudentskiDom.Models;
using StudentskiDom.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace StudentskiDom.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentskiDomContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        //public HomeController(ILogger<HomeController> logger, StudentskiDomContext context)
        //{
        //    _logger = logger;
        //    _context = context;

        //}



       
        //[Route("~/")]
        //[Route("/Home")]
        [HttpGet]
        public IActionResult Login()
        {
            //ova se prva pokrece
            return View();
        }

        [Route("/Home/obrazaczaupis")]
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

            SkolovanjeInfo skolovanjeInfo = new SkolovanjeInfo(fakultet, brojIndeksa, ciklusStudija, godinaStudija);
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

        public HomeController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }



        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {               
               var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);
                if (result.Succeeded)
                {       
                    if(!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Uprava", "Uprava");
                    }
                   
                }
               ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }           
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Home");
        }


        private DateTime StringToDateTime(string datum)
        {
            string danString = datum.Substring(8, 2);
            string mjesecString = datum.Substring(5, 2);
            string godinaString = datum.Substring(0, 4);

            int dan = Int32.Parse(danString);
            int mjesec = Int32.Parse(mjesecString);
            int godina = Int32.Parse(godinaString);

            DateTime date = new DateTime(godina, mjesec, dan);
            return date;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
