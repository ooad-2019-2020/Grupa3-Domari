using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;
using StudentskiDom.Models;

namespace SD.Controllers
{
    //[Authorize(Roles = "Restoran")]
    public class RestoranController : Controller
    {
        private readonly StudentskiDomContext _context;
        public static int IdTrenutnogStudenta = -1;

        private Restoran model { get; set; }

        public RestoranController(StudentskiDomContext context)
        {
            _context = context;
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
            ViewBag.rucak = _context.Rucak.Where(r => r.DnevniMeniId == 1);
            ViewBag.vecera = _context.Vecera.Where(v => v.DnevniMeniId == 1);
            return View();
        }

        public IActionResult PregledDnevniMeni()
        {
            ViewBag.rucak = _context.Rucak.Where(r => r.DnevniMeniId == 1);
            ViewBag.vecera = _context.Vecera.Where(v => v.DnevniMeniId == 1);
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
            _context.Rucak.Add(rucak);
            _context.SaveChanges();
            return RedirectToAction("DnevniMeni", "Restoran");
        }

        public IActionResult DodajVeceru(string jelo)
        {
            Vecera vecera = new Vecera(jelo, 1);
            _context.Vecera.Add(vecera);
            _context.SaveChanges();
            return RedirectToAction("DnevniMeni", "Restoran");
        }

        public IActionResult IzbaciRucak()
        {
            Rucak rucak = _context.Rucak.Where(r => r.DnevniMeniId == 1).ToList().FindLast(r => r.RucakId > 0);
            if (rucak != null)
            {
                _context.Rucak.Remove(rucak);
                _context.SaveChanges();
            }
            return RedirectToAction("DnevniMeni", "Restoran");
        }

        public IActionResult IzbaciVeceru()
        {
            Vecera vecera = _context.Vecera.Where(v => v.DnevniMeniId == 1).ToList().FindLast(v => v.VeceraId > 0);
            if (vecera != null)
            {
                _context.Vecera.Remove(vecera);
                _context.SaveChanges();
            }
            return RedirectToAction("DnevniMeni", "Restoran");
        }

        public IActionResult IzbaciSve()
        {
            _context.Rucak.RemoveRange(_context.Rucak.Where(r => r.DnevniMeniId == 1));
            _context.Vecera.RemoveRange(_context.Vecera.Where(v => v.DnevniMeniId == 1));
            _context.SaveChanges();
            return RedirectToAction("DnevniMeni", "Restoran");
        }


        public IActionResult Restoran(int? StudentId)
        {
            //naci blagajnu iz uprava id, a kao parametar nek se prima student
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
                Student student = _context.Korisnik.FirstOrDefault(k => k.Id == StudentId) as Student;
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

        public ActionResult SkiniRucak()
        {
            if(IdTrenutnogStudenta==-1)
                return RedirectToAction("Restoran", "Restoran");

            Student student = _context.Korisnik.Find(IdTrenutnogStudenta) as Student;
            if (student.BrojRucaka == 0)
                throw new Exception("Nedovoljno bonova");
            student.BrojRucaka = student.BrojRucaka - 1;

            _context.Student.Update(student);
            _context.SaveChanges();

            return RedirectToAction("Restoran", "Restoran", new { StudentId = IdTrenutnogStudenta });
        }

        public ActionResult SkiniVeceru()
        {
            if (IdTrenutnogStudenta == -1)
                return RedirectToAction("Restoran", "Restoran");

            Student student = _context.Korisnik.Find(IdTrenutnogStudenta) as Student;
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
            return View();
        }

        private bool RestoranExists(int id)
        {
            return _context.Restoran.Any(e => e.Id == id);
        }
    }
}
