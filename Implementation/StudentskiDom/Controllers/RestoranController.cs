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
    public class RestoranController : Controller
    {
        private readonly StudentskiDomContext _context;

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
            return View();
        }

        public IActionResult Restoran()
        {
            return View();
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
