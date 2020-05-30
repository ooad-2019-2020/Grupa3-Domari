using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentskiDom.Models;

namespace SD.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentskiDomContext _context;

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

        //[Route("/student/{id}/cimeraj")]
        public IActionResult Cimeraj()
        {
            ICollection<Paviljon> paviljoni = new Collection<Paviljon>();
            foreach(Paviljon p in _context.Paviljon)
            {
                paviljoni.Add(p);
            }
            ViewBag.paviljoni = paviljoni;

            ICollection<Soba> sobe = new Collection<Soba>();
            foreach (Soba s in _context.Soba)
            {
                sobe.Add(s);
            }
            ViewBag.sobe = sobe;
            
            return View();
        }

        [Route("/student/dashboard/{id}")]
        public IActionResult Student(int id)
        {
            //ovog dohvatiti iz baze, nek se zove varijabla student
            Student student =_context.Korisnik.Find(id) as Student;

            student.Soba = _context.Soba.Find(student.SobaId);
            student.SkolovanjeInfo = _context.SkolovanjeInfo.Find(student.SkolovanjeInfoId);
            student.PrebivalisteInfo = _context.PrebivalisteInfo.Find(student.PrebivalisteInfoId);
            student.LicniPodaci = _context.LicniPodaci.Find(student.LicniPodaciId);





            ViewBag.ImePrezime = student.LicniPodaci.Ime + " " + student.LicniPodaci.Prezime;
            ViewBag.BrojRucaka = student.BrojRucaka;
            ViewBag.BrojVecera = student.BrojVecera;
            ViewBag.DatumRodjenja = student.LicniPodaci.DatumRodjenja.ToShortDateString();
            ViewBag.MjestoRodjenja = student.LicniPodaci.MjestoRodjenja;
            ViewBag.Fakultet = student.SkolovanjeInfo.Fakultet;
            ViewBag.JMBG = student.LicniPodaci.Jmbg;
            ViewBag.BrojSobe = student.Soba.BrojSobe;

            //FALI GORE I SLIKA DA SE DOBAVI I DODA U CSHTML!!!

            //string ime = "Tarik";
            //string prezime = "Mehulić";
            //ViewBag.ImePrezime = ime + " " + prezime;
            //ViewBag.BrojRucaka = 15;
            //ViewBag.BrojVecera = 15;
            //DateTime datum = DateTime.Now;
            //ViewBag.DatumRodjenja = datum.ToShortDateString();
            //ViewBag.MjestoRodjenja = "Travnik";
            //ViewBag.Fakultet = "ETF";
            //ViewBag.JMBG = 123456789;
            //ViewBag.BrojSobe = 305;

            return View();
        }

        //[Route("/student/{id}/zahtjevzapremjestanje")]
        public IActionResult ZahtjevZaPremjestanje()
        {
            ICollection<Paviljon> paviljoni = new Collection<Paviljon>();
            foreach (Paviljon p in _context.Paviljon)
            {
                paviljoni.Add(p);
            }
            ViewBag.paviljoni = paviljoni;

            ICollection<Soba> sobe = new Collection<Soba>();
            foreach (Soba s in _context.Soba)
            {
                sobe.Add(s);
            }
            ViewBag.sobe = sobe;
            return View();
        }

        [HttpPost]
        public IActionResult posaljiCimeraj(IFormCollection forma)
        {
            string paviljon = forma["dlPaviljon"];
            string soba = forma["dlSoba"];
            string cimer1 = forma["fldCimer1"];
            string cimer2 = forma["fldCimer2"];
            string dodatneNapomene = forma["fldNpomene"];

            // Snimi zahtjev u bazu podataka
            ZahtjevZaCimeraj zahtjevZaCimeraj = new ZahtjevZaCimeraj();
            zahtjevZaCimeraj.PaviljonId = Int32.Parse(paviljon);
            zahtjevZaCimeraj.SobaId = Int32.Parse(soba);
            if(cimer1 != null && !cimer1.Equals(""))
                zahtjevZaCimeraj.Cimer1Id = Int32.Parse(cimer1);
            if (cimer2 != null && !cimer2.Equals(""))
                zahtjevZaCimeraj.Cimer2Id = Int32.Parse(cimer2);
            zahtjevZaCimeraj.DodatneNapomene = dodatneNapomene;

            zahtjevZaCimeraj.StudentId = 1;

            _context.Add(zahtjevZaCimeraj);
            _context.SaveChanges();

            return RedirectToAction("Student", "Student");
        }

        public IActionResult posaljiZahtjevZaPremjestanje(IFormCollection forma)
        {
            string trenutniPaviljon = forma["dlTrenutniPaviljon"];
            string trenutnaSoba = forma["dlTrenutnaSoba"];
            string noviPaviljon = forma["dlNoviPaviljon"];
            string novaSoba = forma["dlNovaSoba"];
            string dodatneNapomene = forma["fldNpomene"];

            // Snimi zahtjev u bazu podataka
            ZahtjevZaPremjestanje zahtjev = new ZahtjevZaPremjestanje();
            zahtjev.Paviljon1Id = Int32.Parse(trenutniPaviljon);
            zahtjev.Soba1Id = Int32.Parse(trenutnaSoba);
            zahtjev.Paviljon2Id = Int32.Parse(noviPaviljon);
            zahtjev.Soba2Id = Int32.Parse(novaSoba);
            zahtjev.RazlogPremjestanja = dodatneNapomene;

            zahtjev.StudentId = 1;

            _context.Add(zahtjev);
            _context.SaveChanges();


            return RedirectToAction("Student", "Student");
        }

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}
