using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using StudentskiDom.Models;

namespace SD.Controllers
{
    public class UpravaController : Controller
    {
        private readonly StudentskiDomContext _context;

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

        public IActionResult Blagajna(int? id)
        {
            Blagajna blagajna = _context.Blagajna.Find(1);
            ViewBag.Blagajna = blagajna;
            return View();
        }

        public IActionResult Uprava()
        {
            return View();
        }

        public IActionResult ListaStudenata()
        {
            List<Student> studenti = new List<Student>();

            foreach(Korisnik k in _context.Korisnik.Where(k => k is Student)){
                Student s = k as Student;
                s.PrebivalisteInfo = _context.PrebivalisteInfo.Find(s.PrebivalisteInfoId);
                s.SkolovanjeInfo = _context.SkolovanjeInfo.Find(s.SkolovanjeInfoId);
                s.LicniPodaci = _context.LicniPodaci.Find(s.LicniPodaciId);
                s.Soba = _context.Soba.Find(s.SobaId);
                s.Soba.Paviljon = _context.Paviljon.Find(s.Soba.PaviljonId);

                studenti.Add(s);
            }

            ViewBag.ListaStudenata = studenti;

            return View();
        }

        protected void dlSortAction(object sender, EventArgs e)
        {
            // LAFO JA NEKI LISTENER POKUSAO STAVITI
            // NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! 
            // NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! 
            // NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! 
            // NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! 
            // NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! NE RADI ! 

            List<Student> studenti = ViewBag.ListaStudenata;
            
            if(studenti.Count>1)
                studenti.Sort((Student s1, Student s2) => string.Compare(s1.PrebivalisteInfo.Kanton, s2.PrebivalisteInfo.Kanton));
            else
                studenti.Sort((Student s1, Student s2) => string.Compare(s1.SkolovanjeInfo.Fakultet, s2.SkolovanjeInfo.Fakultet));
            
            ViewBag.ListaStudenata = studenti;
            
            RedirectToAction("ListaStudenata", "Uprava");
        }

        private bool UpravaExists(int id)
        {
            return _context.Uprava.Any(e => e.Id == id);
        }
    }
}
