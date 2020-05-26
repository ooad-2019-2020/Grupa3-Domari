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
    public class PrebivalisteInfoesController : Controller
    {
        private readonly StudentskiDomContext _context;

        public PrebivalisteInfoesController(StudentskiDomContext context)
        {
            _context = context;
        }

        // GET: PrebivalisteInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.PrebivalisteInfo.ToListAsync());
        }

        // GET: PrebivalisteInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prebivalisteInfo = await _context.PrebivalisteInfo
                .FirstOrDefaultAsync(m => m.PrebivalisteInfoId == id);
            if (prebivalisteInfo == null)
            {
                return NotFound();
            }

            return View(prebivalisteInfo);
        }

        // GET: PrebivalisteInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PrebivalisteInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PrebivalisteInfoId,Adresa,Kanton,Opcina")] PrebivalisteInfo prebivalisteInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prebivalisteInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prebivalisteInfo);
        }

        // GET: PrebivalisteInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prebivalisteInfo = await _context.PrebivalisteInfo.FindAsync(id);
            if (prebivalisteInfo == null)
            {
                return NotFound();
            }
            return View(prebivalisteInfo);
        }

        // POST: PrebivalisteInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PrebivalisteInfoId,Adresa,Kanton,Opcina")] PrebivalisteInfo prebivalisteInfo)
        {
            if (id != prebivalisteInfo.PrebivalisteInfoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prebivalisteInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrebivalisteInfoExists(prebivalisteInfo.PrebivalisteInfoId))
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
            return View(prebivalisteInfo);
        }

        // GET: PrebivalisteInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prebivalisteInfo = await _context.PrebivalisteInfo
                .FirstOrDefaultAsync(m => m.PrebivalisteInfoId == id);
            if (prebivalisteInfo == null)
            {
                return NotFound();
            }

            return View(prebivalisteInfo);
        }

        // POST: PrebivalisteInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prebivalisteInfo = await _context.PrebivalisteInfo.FindAsync(id);
            _context.PrebivalisteInfo.Remove(prebivalisteInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrebivalisteInfoExists(int id)
        {
            return _context.PrebivalisteInfo.Any(e => e.PrebivalisteInfoId == id);
        }
    }
}
