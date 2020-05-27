using System;
using System.Collections.Generic;
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
            return View();
        }

        public IActionResult PregledZahtjeva()
        {
            return View();
        }

        

        private bool ZahtjevExists(int id)
        {
            return _context.Zahtjev.Any(e => e.ZahtjevId == id);
        }
    }
}
