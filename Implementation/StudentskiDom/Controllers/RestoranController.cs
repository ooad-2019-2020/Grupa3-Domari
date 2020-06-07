using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using StudentskiDom.Models;
using ActionNameAttribute = Microsoft.AspNetCore.Mvc.ActionNameAttribute;
using AuthorizeAttribute = Microsoft.AspNetCore.Authorization.AuthorizeAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

namespace SD.Controllers
{
    [Authorize(Roles = "Restoran")]
    public class RestoranController : Controller
    {
        private readonly StudentskiDomContext _context;
        private readonly string apiUrl = "https://studentskidomapi2020.azurewebsites.net";
        public static int IdTrenutnogStudenta = -1;

        public static List<StavkaNarudzbe> StavkeNarudzbe = new List<StavkaNarudzbe>();
        public static List<StavkaNarudzbe> Namirnice;

        private Restoran Model { get; set; }

        public RestoranController(StudentskiDomContext context)
        {
            _context = context;
            StudentskiDomSingleton.getInstance().SetContext(context);
        }

        // GET: Restorans
        public async Task<IActionResult> Index()
        {
            var studentskiDomContext = _context.Restoran.Include(r => r.DnevniMeni);
            return View(await studentskiDomContext.ToListAsync());
        }

        // GET: Restorans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restoran = await _context.Restoran
                .Include(r => r.DnevniMeni)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (restoran == null)
            {
                return NotFound();
            }

            return View(restoran);
        }

        // GET: Restorans/Create
        public IActionResult Create()
        {
            ViewData["DnevniMeniId"] = new SelectList(_context.DnevniMeni, "DnevniMeniId", "DnevniMeniId");
            return View();
        }

        // POST: Restorans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DnevniMeniId,Id,Username,Password")] Restoran restoran)
        {
            if (ModelState.IsValid)
            {
                _context.Add(restoran);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DnevniMeniId"] = new SelectList(_context.DnevniMeni, "DnevniMeniId", "DnevniMeniId", restoran.DnevniMeniId);
            return View(restoran);
        }

        // GET: Restorans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restoran = await _context.Restoran.FindAsync(id);
            if (restoran == null)
            {
                return NotFound();
            }
            ViewData["DnevniMeniId"] = new SelectList(_context.DnevniMeni, "DnevniMeniId", "DnevniMeniId", restoran.DnevniMeniId);
            return View(restoran);
        }

        // POST: Restorans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DnevniMeniId,Id,Username,Password")] Restoran restoran)
        {
            if (id != restoran.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restoran);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestoranExists(restoran.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DnevniMeniId"] = new SelectList(_context.DnevniMeni, "DnevniMeniId", "DnevniMeniId", restoran.DnevniMeniId);
            return View(restoran);
        }

        // GET: Restorans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restoran = await _context.Restoran
                .Include(r => r.DnevniMeni)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (restoran == null)
            {
                return NotFound();
            }

            return View(restoran);
        }

        // POST: Restorans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restoran = await _context.Restoran.FindAsync(id);
            _context.Restoran.Remove(restoran);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
        public IActionResult DnevniMeni()
        {
            ViewBag.jela = _context.Rucak.Where(r => r.DnevniMeniId == 2);
            ViewBag.rucak = StudentskiDomSingleton.getInstance().Restoran.DnevniMeni.Rucak;
            ViewBag.vecera = StudentskiDomSingleton.getInstance().Restoran.DnevniMeni.Vecera;
            return View();
        }

        public IActionResult PregledDnevniMeni()
        {
            ViewBag.rucak = StudentskiDomSingleton.getInstance().Restoran.DnevniMeni.Rucak;
            ViewBag.vecera = StudentskiDomSingleton.getInstance().Restoran.DnevniMeni.Vecera;
            return View();
        }

        [HttpPost]
        public IActionResult DodajRucakVeceru(IFormCollection forma, string dodaj)
        {
            if (dodaj.Equals("rucak"))
            {
                return DodajRucak(forma["dlJelo"]);
            }
            else if(dodaj.Equals("vecera"))
            {
                return DodajVeceru(forma["dlJelo"]); 
            }

            return RedirectToAction("DnevniMeni", "Restoran");
        }

        public IActionResult DodajRucak(string jelo)
        {
            Rucak rucak = new Rucak(jelo, 1);
            StudentskiDomSingleton.getInstance().Restoran.DodajRucak(rucak);
            return RedirectToAction("DnevniMeni", "Restoran");
        }

        public IActionResult DodajVeceru(string jelo)
        {
            Vecera vecera = new Vecera(jelo, 1);
            StudentskiDomSingleton.getInstance().Restoran.DodajVeceru(vecera);
            return RedirectToAction("DnevniMeni", "Restoran");
        }

        public IActionResult IzbaciRucak()
        {
            Rucak rucak = StudentskiDomSingleton.getInstance().Restoran.DnevniMeni.Rucak.Last();
            if (rucak != null)
            {
                StudentskiDomSingleton.getInstance().Restoran.IzbaciRucak(rucak);
            }
            return RedirectToAction("DnevniMeni", "Restoran");
        }

        public IActionResult IzbaciVeceru()
        {
            Vecera vecera = StudentskiDomSingleton.getInstance().Restoran.DnevniMeni.Vecera.Last();
            if (vecera != null)
            {
                StudentskiDomSingleton.getInstance().Restoran.IzbaciVeceru(vecera);
            }
            return RedirectToAction("DnevniMeni", "Restoran");
        }

        public IActionResult IzbaciSve()
        {
            StudentskiDomSingleton.getInstance().Restoran.IzbaciSve();
            return RedirectToAction("DnevniMeni", "Restoran");
        }


        public async Task<IActionResult> RestoranAsync(int? StudentId)
        {
  
            if (StudentId == null)
            {
                ViewBag.Ime = "Ime";
                ViewBag.Prezime = "Prezime";
                ViewBag.BrojRucaka = 0;
                ViewBag.BrojVecera = 0;
                ViewBag.Slika = "blank.jpg";
                return View();
            }
            else
            {
                Student student = new Student();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = await client.GetAsync("api/student/" + StudentId);

                    if (Res.IsSuccessStatusCode)
                    {
                        var response = Res.Content.ReadAsStringAsync().Result;

                        student = JsonConvert.DeserializeObject<Student>(response);
                        student.PrebivalisteInfo = _context.PrebivalisteInfo.Find(student.PrebivalisteInfoId);
                        student.SkolovanjeInfo = _context.SkolovanjeInfo.Find(student.SkolovanjeInfoId);
                        student.LicniPodaci = _context.LicniPodaci.Find(student.LicniPodaciId);
                        student.Soba = _context.Soba.Find(student.SobaId);
                        student.Soba.Paviljon = _context.Paviljon.Find(student.Soba.PaviljonId);
                    }
                }
                if (student == null)
                {
                    ViewBag.Ime = "Ime";
                    ViewBag.Prezime = "Prezime";
                    ViewBag.BrojRucaka = 0;
                    ViewBag.BrojVecera = 0;
                    ViewBag.Slika = "blank.jpg";
                    return View();
                }
                else
                {
                    student.LicniPodaci = _context.LicniPodaci.Find(student.LicniPodaciId);
                    ViewBag.Ime = student.LicniPodaci.Ime;
                    ViewBag.Prezime = student.LicniPodaci.Prezime;
                    ViewBag.BrojRucaka = student.BrojRucaka;
                    ViewBag.BrojVecera = student.BrojVecera;
                    ViewBag.Slika = student.LicniPodaci.Slika;

                    return View();
                }
            }
        }

        public async Task<ActionResult> SkiniRucakAsync()
        {
            if(IdTrenutnogStudenta==-1)
                return RedirectToAction("Restoran", "Restoran");

            Student student = new Student();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/student/" + IdTrenutnogStudenta);

                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;

                    student = JsonConvert.DeserializeObject<Student>(response);
                    student.PrebivalisteInfo = _context.PrebivalisteInfo.Find(student.PrebivalisteInfoId);
                    student.SkolovanjeInfo = _context.SkolovanjeInfo.Find(student.SkolovanjeInfoId);
                    student.LicniPodaci = _context.LicniPodaci.Find(student.LicniPodaciId);
                    student.Soba = _context.Soba.Find(student.SobaId);
                    student.Soba.Paviljon = _context.Paviljon.Find(student.Soba.PaviljonId);
                }
            }
            if (student.BrojRucaka == 0)
                throw new Exception("Nedovoljno bonova");
            student.BrojRucaka = student.BrojRucaka - 1;

            _context.Student.Update(student);
            _context.SaveChanges();

            return RedirectToAction("Restoran", "Restoran", new { StudentId = IdTrenutnogStudenta });
        }

        public async Task<ActionResult> SkiniVeceruAsync()
        {
            if (IdTrenutnogStudenta == -1)
                return RedirectToAction("Restoran", "Restoran");

            Student student = new Student();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/student/" + IdTrenutnogStudenta);

                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;

                    student = JsonConvert.DeserializeObject<Student>(response);
                    student.PrebivalisteInfo = _context.PrebivalisteInfo.Find(student.PrebivalisteInfoId);
                    student.SkolovanjeInfo = _context.SkolovanjeInfo.Find(student.SkolovanjeInfoId);
                    student.LicniPodaci = _context.LicniPodaci.Find(student.LicniPodaciId);
                    student.Soba = _context.Soba.Find(student.SobaId);
                    student.Soba.Paviljon = _context.Paviljon.Find(student.Soba.PaviljonId);
                }
            }
            if (student.BrojVecera == 0)
                throw new Exception("Nedovoljno bonova");
            student.BrojVecera = student.BrojVecera - 1;

            _context.Student.Update(student);
            _context.SaveChanges();

            return RedirectToAction("Restoran", "Restoran", new { StudentId = IdTrenutnogStudenta });
        }

        [HttpPost]
        public ActionResult ProvjeriID(IFormCollection forma)
        {
            if (forma["fldStudentId"].Equals(""))
            {
                IdTrenutnogStudenta = -1;
                return RedirectToAction("Restoran", "Restoran");
            }


            IdTrenutnogStudenta = Int32.Parse(forma["fldStudentId"].ToString());
            Korisnik student = null;
            student = _context.Korisnik.Find(IdTrenutnogStudenta);
            if (student == null)
            {
                //error neki
            }
            else
            {
                return RedirectToAction("Restoran", "Restoran", new { StudentId = IdTrenutnogStudenta });
            }
            return RedirectToAction("Restoran", "Restoran");

        }


        public IActionResult ZahtjevZaNabavkuNamirnica()
        {
            if(Namirnice==null)
                Namirnice = _context.StavkaNarudzbe.Where(sn => sn.ZahtjevZaNabavkuNamirnicaId==39).ToList();
            ViewBag.Namirnice = Namirnice;
            ViewBag.Stavke = StavkeNarudzbe;
            return View();
        }

        public IActionResult DodajStavkuNarudzbe(IFormCollection forma)
        {
            if (!string.IsNullOrEmpty(forma["fldKolicina"]))
            {
                StavkaNarudzbe sn = _context.StavkaNarudzbe.Find(Int32.Parse(forma["dlStavkeNarudzbe"]));
                sn.Kolicina = Int32.Parse(forma["fldKolicina"]);
                sn.StavkaNarudzbeId = 0;

                StavkeNarudzbe.Add(sn);
            }

            return RedirectToAction("ZahtjevZaNabavkuNamirnica", "Restoran");
        }

        public IActionResult ObrisiStavkuNarudzbe(IFormCollection forma)
        {
            if(StavkeNarudzbe.Count != 0)
                StavkeNarudzbe.RemoveAt(StavkeNarudzbe.Count() - 1);
            
            return RedirectToAction("ZahtjevZaNabavkuNamirnica", "Restoran");
        }

        public IActionResult PosaljiZahtjevZaNabavkuNamirnica()
        {
            ZahtjevZaNabavkuNamirnica zahtjev = new ZahtjevZaNabavkuNamirnica();
            // Mozda bolje ovdje staviti ovo model, ali ne znam jel fino implementirano
            zahtjev.RestoranId = _context.Korisnik.FirstOrDefault(k => k is Restoran).Id;
            //zahtjev.StavkeNadruzbe = StavkeNarudzbe;
                
            _context.ZahtjevZaNabavkuNamirnica.Add(zahtjev);
            _context.SaveChanges();
            foreach (StavkaNarudzbe sn in StavkeNarudzbe)
            {
                sn.ZahtjevZaNabavkuNamirnica = zahtjev;
                sn.ZahtjevZaNabavkuNamirnicaId = zahtjev.ZahtjevId;
                _context.StavkaNarudzbe.Add(sn);
            }
            //_context.ZahtjevZaNabavkuNamirnica.Add(zahtjev);
            _context.SaveChanges();

            return RedirectToAction("Restoran", "Restoran");
        }

        public IActionResult OdbaciZahtjevZaNabavkuNamirnica()
        {
            StavkeNarudzbe.Clear();
            return RedirectToAction("Restoran", "Restoran");
        }

        public IActionResult ObrisiStavkeNarudzbe()
        {
            StavkeNarudzbe.Clear();
            return RedirectToAction("ZahtjevZaNabavkuNamirnica", "Restoran");
        }

        private bool RestoranExists(int id)
        {
            return _context.Restoran.Any(e => e.Id == id);
        }
    }
}
