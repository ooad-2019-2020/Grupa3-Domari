using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using StudentskiDom.Models;
using System.Configuration;

namespace SD.Controllers
{
    public class UpravaController : Controller
    {
        private readonly StudentskiDomContext _context;
        public static List<Student> studentiSoba;
        public static List<Soba> sobe;
        public static List<Paviljon> paviljoni;

        public UpravaController(StudentskiDomContext context)
        {
            _context = context;
        }

        // GET: Upravas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Uprava.ToListAsync());
        }

        // GET: Upravas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uprava = await _context.Uprava
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uprava == null)
            {
                return NotFound();
            }

            return View(uprava);
        }

        // GET: Upravas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Upravas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KorisnikId,Id,Username,Password")] Uprava uprava)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uprava);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uprava);
        }

        // GET: Upravas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uprava = await _context.Uprava.FindAsync(id);
            if (uprava == null)
            {
                return NotFound();
            }
            return View(uprava);
        }

        // POST: Upravas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KorisnikId,Id,Username,Password")] Uprava uprava)
        {
            if (id != uprava.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uprava);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UpravaExists(uprava.Id))
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
            return View(uprava);
        }

        // GET: Upravas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uprava = await _context.Uprava
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uprava == null)
            {
                return NotFound();
            }

            return View(uprava);
        }

        // POST: Upravas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uprava = await _context.Uprava.FindAsync(id);
            _context.Uprava.Remove(uprava);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //[Route("/uprava/{id}/blagajna")]
        public IActionResult Blagajna(int? StudentId)
        {
            //naci blagajnu iz uprava id, a kao parametar nek se prima student
            Blagajna blagajna = _context.Blagajna.Find(1);
            ViewBag.Blagajna = blagajna;
            ViewBag.mjeseci = new List<String>();
            if (StudentId == null)
            {
                return View();
            }
            else
            {
                Student student = _context.Korisnik.FirstOrDefault(k => k.Id == StudentId) as Student;
                if (student == null)
                {
                    ViewBag.Ime = null;
                    ViewBag.Prezime = null;
                    ViewBag.Fakultet = null;
                    ViewBag.Kanton = null;
                    ViewBag.Soba = null;
                    ViewBag.mjeseci = new List<String>();
                    return View();
                }
                else
                {
                    student.Soba = _context.Soba.Find(student.SobaId);
                    student.SkolovanjeInfo = _context.SkolovanjeInfo.Find(student.SkolovanjeInfoId);
                    student.PrebivalisteInfo = _context.PrebivalisteInfo.Find(student.PrebivalisteInfoId);
                    student.LicniPodaci = _context.LicniPodaci.Find(student.LicniPodaciId);
                    ViewBag.Ime = student.LicniPodaci.Ime;
                    ViewBag.Prezime = student.LicniPodaci.Prezime;
                    ViewBag.Fakultet = student.SkolovanjeInfo.Fakultet;
                    ViewBag.Kanton = student.PrebivalisteInfo.Kanton;
                    ViewBag.Soba = student.Soba.BrojSobe;

                    // Trebaju biti mjeseci od studenta
                    string[] mjeseci = { "Septembar", "Oktobar", "Novembar", "Decembar", "Januar", "Februar", "Mart", "April", "Maj", "Juni", "Juli" };
                    ViewBag.mjeseci = mjeseci;
                    return View();
                }


            }
        }

        [Route("/uprava/dashboard/{id}")]
        public IActionResult Uprava()
        {
            //ovdje kreirati upravu
            return View();
        }

        public IActionResult SmjestajniKapacitet()
        {
            ViewBag.paviljoni = _context.Paviljon.ToList();
            ViewBag.sobe = _context.Soba.ToList();

            if (studentiSoba == null)
            {
                SetStudentsSoba(_context.Paviljon.FirstOrDefault().PaviljonId, _context.Soba.FirstOrDefault().SobaId);
            }
            ViewBag.studentiSoba = studentiSoba;
            return View();
        }

        [HttpPost]
        public IActionResult DajKpacitet(IFormCollection forma)
        {
            int paviljonId = Int32.Parse(forma["dlPaviljon"]);
            int sobaId = Int32.Parse(forma["dlSoba"]);

            SetStudentsSoba(paviljonId, sobaId);

            return RedirectToAction("SmjestajniKapacitet", "Uprava");
        }

        [HttpPost]
        public ActionResult ProvjeriID(IFormCollection forma)
        {
            int id = Int32.Parse(forma["fldStudentId"].ToString());
            Korisnik student = null;
            student = _context.Korisnik.Find(id);
            if (student == null)
            {
                //error neki
            }
            else
            {
                return RedirectToAction("Blagajna", "Uprava", new { StudentId = id });
            }
            return RedirectToAction("Blagajna", "Uprava");

        }

        //[Route("/uprava/{id}/listaStudenata")]
        public IActionResult ListaStudenata()
        {
            List<Student> studenti = GetStudents();

            ViewBag.ListaStudenata = studenti;

            return View();
        }

        [HttpPost]
        public IActionResult SortStudenti(IFormCollection forma)
        {
            if (forma["dlSort"].Equals("12"))
                return RedirectToAction("ListaStudenataFakultetSort", "Uprava");
            else
                return RedirectToAction("ListaStudenataKantonSort", "Uprava");
        }

        public IActionResult ListaStudenataFakultetSort()
        {
            List<Student> studenti = GetStudents();

            studenti.Sort((Student s1, Student s2) => string.Compare(s1.SkolovanjeInfo.Fakultet, s2.SkolovanjeInfo.Fakultet));
            ViewBag.ListaStudenata = studenti;
            
            return View();
        }

        public IActionResult ListaStudenataKantonSort()
        {
            List<Student> studenti = GetStudents();

            studenti.Sort((Student s1, Student s2) => string.Compare(s1.PrebivalisteInfo.Kanton, s2.PrebivalisteInfo.Kanton));
            ViewBag.ListaStudenata = studenti;

            return View();
        }

        private bool UpravaExists(int id)
        {
            return _context.Uprava.Any(e => e.Id == id);
        }

        private List<Student> GetStudents()
        {
            List<Korisnik> korisnici = _context.Korisnik.Where(k => k is Student).ToList();
            List<Student> studenti = new List<Student>();
            korisnici.ForEach(k => {
                Student s = k as Student;
                s.PrebivalisteInfo = _context.PrebivalisteInfo.Find(s.PrebivalisteInfoId);
                s.SkolovanjeInfo = _context.SkolovanjeInfo.Find(s.SkolovanjeInfoId);
                s.LicniPodaci = _context.LicniPodaci.Find(s.LicniPodaciId);
                s.Soba = _context.Soba.Find(s.SobaId);
                s.Soba.Paviljon = _context.Paviljon.Find(s.Soba.PaviljonId);

                studenti.Add(s);
            });

            return studenti;
        }

        private void SetStudentsSoba(int paviljonId, int sobaId)
        {
            List<Korisnik> korisnici = _context.Korisnik.Where(k => k is Student).ToList();
            if (studentiSoba == null)
                studentiSoba = new List<Student>();

            studentiSoba.Clear();
            korisnici.ForEach(k => {
                Student s = k as Student;

                if (s.SobaId == sobaId)
                {
                    s.Soba = _context.Soba.Find(s.SobaId);

                    if (s.Soba.PaviljonId == paviljonId)
                    {
                        s.PrebivalisteInfo = _context.PrebivalisteInfo.Find(s.PrebivalisteInfoId);
                        s.SkolovanjeInfo = _context.SkolovanjeInfo.Find(s.SkolovanjeInfoId);
                        s.LicniPodaci = _context.LicniPodaci.Find(s.LicniPodaciId);
                        s.Soba.Paviljon = _context.Paviljon.Find(s.Soba.PaviljonId);

                        studentiSoba.Add(s);
                    }

                }
            });
        }
    }
}
