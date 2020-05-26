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

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}
