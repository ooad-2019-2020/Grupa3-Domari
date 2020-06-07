using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using StudentskiDom.Models;

namespace SD.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        private readonly StudentskiDomContext _context;
        private readonly string apiUrl = "https://studentskidomapi2020.azurewebsites.net";

        public StudentController(StudentskiDomContext context)
        {
            _context = context;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            var studentskiDomContext = _context.Student.Include(s => s.LicniPodaci).Include(s => s.PrebivalisteInfo).Include(s => s.SkolovanjeInfo).Include(s => s.Soba);
            return View(await studentskiDomContext.ToListAsync());
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .Include(s => s.LicniPodaci)
                .Include(s => s.PrebivalisteInfo)
                .Include(s => s.SkolovanjeInfo)
                .Include(s => s.Soba)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            ViewData["LicniPodaciId"] = new SelectList(_context.LicniPodaci, "LicniPodaciId", "LicniPodaciId");
            ViewData["PrebivalisteInfoId"] = new SelectList(_context.PrebivalisteInfo, "PrebivalisteInfoId", "PrebivalisteInfoId");
            ViewData["SkolovanjeInfoId"] = new SelectList(_context.SkolovanjeInfo, "SkolovanjeInfoId", "SkolovanjeInfoId");
            ViewData["SobaId"] = new SelectList(_context.Soba, "SobaId", "SobaId");
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BrojRucaka,BrojVecera,LicniPodaciId,PrebivalisteInfoId,SkolovanjeInfoId,SobaId,Id,Username,Password")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LicniPodaciId"] = new SelectList(_context.LicniPodaci, "LicniPodaciId", "LicniPodaciId", student.LicniPodaciId);
            ViewData["PrebivalisteInfoId"] = new SelectList(_context.PrebivalisteInfo, "PrebivalisteInfoId", "PrebivalisteInfoId", student.PrebivalisteInfoId);
            ViewData["SkolovanjeInfoId"] = new SelectList(_context.SkolovanjeInfo, "SkolovanjeInfoId", "SkolovanjeInfoId", student.SkolovanjeInfoId);
            ViewData["SobaId"] = new SelectList(_context.Soba, "SobaId", "SobaId", student.SobaId);
            return View(student);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewData["LicniPodaciId"] = new SelectList(_context.LicniPodaci, "LicniPodaciId", "LicniPodaciId", student.LicniPodaciId);
            ViewData["PrebivalisteInfoId"] = new SelectList(_context.PrebivalisteInfo, "PrebivalisteInfoId", "PrebivalisteInfoId", student.PrebivalisteInfoId);
            ViewData["SkolovanjeInfoId"] = new SelectList(_context.SkolovanjeInfo, "SkolovanjeInfoId", "SkolovanjeInfoId", student.SkolovanjeInfoId);
            ViewData["SobaId"] = new SelectList(_context.Soba, "SobaId", "SobaId", student.SobaId);
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BrojRucaka,BrojVecera,LicniPodaciId,PrebivalisteInfoId,SkolovanjeInfoId,SobaId,Id,Username,Password")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
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
            ViewData["LicniPodaciId"] = new SelectList(_context.LicniPodaci, "LicniPodaciId", "LicniPodaciId", student.LicniPodaciId);
            ViewData["PrebivalisteInfoId"] = new SelectList(_context.PrebivalisteInfo, "PrebivalisteInfoId", "PrebivalisteInfoId", student.PrebivalisteInfoId);
            ViewData["SkolovanjeInfoId"] = new SelectList(_context.SkolovanjeInfo, "SkolovanjeInfoId", "SkolovanjeInfoId", student.SkolovanjeInfoId);
            ViewData["SobaId"] = new SelectList(_context.Soba, "SobaId", "SobaId", student.SobaId);
            return View(student);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .Include(s => s.LicniPodaci)
                .Include(s => s.PrebivalisteInfo)
                .Include(s => s.SkolovanjeInfo)
                .Include(s => s.Soba)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Student.FindAsync(id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Cimeraj(int id)
        {
            ViewBag.paviljoni = _context.Paviljon;
            ViewBag.sobe = _context.Soba.Where(s => s.PaviljonId==1);
            ViewBag.id = id;
            
            return View();
        }

        public async Task<IActionResult> StudentAsync(int ID)
        {
            //ovog dohvatiti iz baze, nek se zove varijabla student
            Student student =await GetStudentAsync(ID);
            ViewBag.Id = ID;
            ViewBag.ImePrezime = student.LicniPodaci.Ime + " " + student.LicniPodaci.Prezime;
            ViewBag.Pol = student.LicniPodaci.Pol.ToString();
            ViewBag.BrojRucaka = student.BrojRucaka;
            ViewBag.BrojVecera = student.BrojVecera;
            ViewBag.DatumRodjenja = student.LicniPodaci.DatumRodjenja.ToShortDateString();
            ViewBag.MjestoRodjenja = student.LicniPodaci.MjestoRodjenja;
            ViewBag.Fakultet = student.SkolovanjeInfo.Fakultet;
            ViewBag.JMBG = student.LicniPodaci.Jmbg;
            ViewBag.BrojSobe = student.Soba.BrojSobe;
            ViewBag.Slika = student.LicniPodaci.Slika;

            return View();
        }


        public IActionResult ZahtjevZaPremjestanje(int id)
        {
            ViewBag.paviljoni = _context.Paviljon;
            ViewBag.sobe = _context.Soba.Where(s => s.PaviljonId == 1);
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public IActionResult posaljiCimeraj(IFormCollection forma, int id)
        {
            string paviljon = forma["dlPaviljon"];
            string soba = forma["dlSoba"];
            string cimer1 = forma["fldCimer1"];
            string cimer2 = forma["fldCimer2"];
            string dodatneNapomene = forma["fldNpomene"];

            if (string.IsNullOrEmpty(cimer1) || string.IsNullOrEmpty(cimer2) || 
                _context.Student.Find(Int32.Parse(cimer1))==null || _context.Student.Find(Int32.Parse(cimer2)) == null)
                return RedirectToAction("Cimeraj", "Student", new { id });

            // Snimi zahtjev u bazu podataka
            ZahtjevZaCimeraj zahtjevZaCimeraj = new ZahtjevZaCimeraj();
            zahtjevZaCimeraj.PaviljonId = Int32.Parse(paviljon);
            zahtjevZaCimeraj.SobaId = Int32.Parse(soba);
            zahtjevZaCimeraj.Cimer1Id = Int32.Parse(cimer1);
            zahtjevZaCimeraj.Cimer2Id = Int32.Parse(cimer2);
            zahtjevZaCimeraj.DodatneNapomene = dodatneNapomene;

            zahtjevZaCimeraj.StudentId = id;

            _context.Add(zahtjevZaCimeraj);
            _context.SaveChanges();

            return RedirectToAction("Student", "Student", new { ID = id });
        }

        public IActionResult posaljiZahtjevZaPremjestanje(IFormCollection forma, int id)
        {
            string trenutniPaviljon = forma["dlTrenutniPaviljon"];
            string trenutnaSoba = forma["dlTrenutnaSoba"];
            string noviPaviljon = forma["dlNoviPaviljon"];
            string novaSoba = forma["dlNovaSoba"];
            string dodatneNapomene = forma["fldNapomene"];

            // Snimi zahtjev u bazu podataka
            ZahtjevZaPremjestanje zahtjev = new ZahtjevZaPremjestanje();
            zahtjev.Paviljon1Id = Int32.Parse(trenutniPaviljon);
            zahtjev.Soba1Id = Int32.Parse(trenutnaSoba);
            zahtjev.Paviljon2Id = Int32.Parse(noviPaviljon);
            zahtjev.Soba2Id = Int32.Parse(novaSoba);
            zahtjev.RazlogPremjestanja = dodatneNapomene;

            zahtjev.StudentId = id;

            _context.Add(zahtjev);
            _context.SaveChanges();


            return RedirectToAction("Student", "Student", new { ID = id });
        }

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }

        private async Task<Student> GetStudentAsync(int id)
        {
            Student s = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/student/" + id);


                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;

                    s = JsonConvert.DeserializeObject<Student>(response);
                    s.PrebivalisteInfo = _context.PrebivalisteInfo.Find(s.PrebivalisteInfoId);
                    s.SkolovanjeInfo = _context.SkolovanjeInfo.Find(s.SkolovanjeInfoId);
                    s.LicniPodaci = _context.LicniPodaci.Find(s.LicniPodaciId);
                    s.Soba = _context.Soba.Find(s.SobaId);
                    s.Soba.Paviljon = _context.Paviljon.Find(s.Soba.PaviljonId);
                }
            }
            return s;
        }
    }
}
