using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentskiDom.Models;

namespace SD.Controllers
{
    public class ZahtjevController : Controller
    {
        private readonly StudentskiDomContext _context;

        public ZahtjevController(StudentskiDomContext context)
        {
            _context = context;
        }

        // GET: Zahtjevs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zahtjev.ToListAsync());
        }

        // GET: Zahtjevs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjev = await _context.Zahtjev
                .FirstOrDefaultAsync(m => m.ZahtjevId == id);
            if (zahtjev == null)
            {
                return NotFound();
            }

            return View(zahtjev);
        }

        // GET: Zahtjevs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zahtjevs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ZahtjevId,Datum,Odobren")] Zahtjev zahtjev)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zahtjev);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zahtjev);
        }

        // GET: Zahtjevs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjev = await _context.Zahtjev.FindAsync(id);
            if (zahtjev == null)
            {
                return NotFound();
            }
            return View(zahtjev);
        }

        // POST: Zahtjevs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ZahtjevId,Datum,Odobren")] Zahtjev zahtjev)
        {
            if (id != zahtjev.ZahtjevId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zahtjev);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZahtjevExists(zahtjev.ZahtjevId))
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
            return View(zahtjev);
        }

        // GET: Zahtjevs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjev = await _context.Zahtjev
                .FirstOrDefaultAsync(m => m.ZahtjevId == id);
            if (zahtjev == null)
            {
                return NotFound();
            }

            return View(zahtjev);
        }

        // POST: Zahtjevs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zahtjev = await _context.Zahtjev.FindAsync(id);
            _context.Zahtjev.Remove(zahtjev);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult StudentskaKartica()
        {
            ViewBag.Soba = 1;
            ViewBag.Paviljon = 2;
            ViewBag.Ime = "Tarik";
            ViewBag.Prezime = "Mehulić";
            ViewBag.Kanton = "SBK";
            ViewBag.Fakultet = "ETF";
            ViewBag.ID = 18349;
            return View();
        }

        public IActionResult PregledZahtjeva()
        {
            ICollection<Zahtjev> zahtjevi = new Collection<Zahtjev>();

            foreach(Zahtjev z in _context.Zahtjev)
            {
                if(z is ZahtjevZaUpis)
                {
                    ZahtjevZaUpis zahtjevZaUpis = z as ZahtjevZaUpis;

                    zahtjevZaUpis.PrebivalisteInfo = _context.PrebivalisteInfo.Where(p => p.PrebivalisteInfoId == zahtjevZaUpis.PrebivalisteInfoId).FirstOrDefault();
                    zahtjevZaUpis.SkolovanjeInfo = _context.SkolovanjeInfo.Where(p => p.SkolovanjeInfoId == zahtjevZaUpis.SkolovanjeInfoId).FirstOrDefault();
                    zahtjevZaUpis.LicniPodaci = _context.LicniPodaci.Where(p => p.LicniPodaciId == zahtjevZaUpis.LicniPodaciId).FirstOrDefault();

                    zahtjevi.Add(z);
                }

                
            }

            ViewBag.Zahtjevi = zahtjevi;

            return View();
        }

        public IActionResult PregledUpis()
        {
            return View();
        }

        public IActionResult PregledPremjestanje()
        {
            return View();
        }

        public IActionResult PregledCimeraj()
        {
            return View();
        }

        public IActionResult PregledNabavka()
        {
            return View();
        }


        private bool ZahtjevExists(int id)
        {
            return _context.Zahtjev.Any(e => e.ZahtjevId == id);
        }
    }
}
