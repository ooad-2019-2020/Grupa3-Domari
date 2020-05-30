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

        public IActionResult StudentskaKartica(int id)
        {
            Zahtjev z = _context.Zahtjev.Find(id);

            ZahtjevZaUpis zahtjevZaUpis = z as ZahtjevZaUpis;
            zahtjevZaUpis.PrebivalisteInfo = _context.PrebivalisteInfo.Find(zahtjevZaUpis.PrebivalisteInfoId);
            zahtjevZaUpis.SkolovanjeInfo = _context.SkolovanjeInfo.Find(zahtjevZaUpis.SkolovanjeInfoId);
            zahtjevZaUpis.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaUpis.LicniPodaciId);

            ViewBag.Soba = "?";
            ViewBag.Paviljon = "?";
            ViewBag.Ime = zahtjevZaUpis.LicniPodaci.Ime;
            ViewBag.Prezime = zahtjevZaUpis.LicniPodaci.Prezime;

            string fakultet = DajSkracenicuZaFakultet(zahtjevZaUpis.SkolovanjeInfo.Fakultet);
            ViewBag.Fakultet = fakultet;

            string kanton = DajSkracenicuZaKanton(zahtjevZaUpis.PrebivalisteInfo.Kanton);
            ViewBag.Kanton = kanton;
            
            ViewBag.ID = zahtjevZaUpis.SkolovanjeInfo.BrojIndeksa;


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

                    zahtjevZaUpis.PrebivalisteInfo = _context.PrebivalisteInfo.Find(zahtjevZaUpis.PrebivalisteInfoId);
                    zahtjevZaUpis.SkolovanjeInfo = _context.SkolovanjeInfo.Find(zahtjevZaUpis.SkolovanjeInfoId);
                    zahtjevZaUpis.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaUpis.LicniPodaciId);

                    zahtjevi.Add(z);
                }else if(z is ZahtjevZaCimeraj)
                {
                    ZahtjevZaCimeraj zahtjevZaCimeraj = z as ZahtjevZaCimeraj;

                    zahtjevZaCimeraj.Soba = _context.Soba.Find(zahtjevZaCimeraj.SobaId);
                    zahtjevZaCimeraj.Paviljon = _context.Paviljon.Find(zahtjevZaCimeraj.PaviljonId);
                    zahtjevZaCimeraj.Cimer1 = _context.Student.Find(zahtjevZaCimeraj.Cimer1Id);
                    zahtjevZaCimeraj.Cimer2 = _context.Student.Find(zahtjevZaCimeraj.Cimer2Id);

                    zahtjevZaCimeraj.Student = _context.Student.Find(zahtjevZaCimeraj.StudentId);

                    zahtjevZaCimeraj.Student.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaCimeraj.Student.LicniPodaciId);

                    zahtjevi.Add(z);
                }else if(z is ZahtjevZaPremjestanje)
                {
                    ZahtjevZaPremjestanje zahtjevZaPremjestanje = z as ZahtjevZaPremjestanje;

                    zahtjevZaPremjestanje.Soba1 = _context.Soba.Find(zahtjevZaPremjestanje.Soba1Id);
                    zahtjevZaPremjestanje.Soba2 = _context.Soba.Find(zahtjevZaPremjestanje.Soba2Id);

                    zahtjevZaPremjestanje.Paviljon1 = _context.Paviljon.Find(zahtjevZaPremjestanje.Paviljon1Id);
                    zahtjevZaPremjestanje.Paviljon2 = _context.Paviljon.Find(zahtjevZaPremjestanje.Paviljon2Id);

                    zahtjevZaPremjestanje.Student = _context.Student.Find(zahtjevZaPremjestanje.StudentId);

                    zahtjevZaPremjestanje.Student.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaPremjestanje.Student.LicniPodaciId);

                    zahtjevi.Add(zahtjevZaPremjestanje);
                }

                
            }

            ViewBag.Zahtjevi = zahtjevi;

            return View();
        }

        public IActionResult PregledUpis(int id)
        {
            Zahtjev z = _context.Zahtjev.Find(id);

            ZahtjevZaUpis zahtjevZaUpis = z as ZahtjevZaUpis;
            zahtjevZaUpis.PrebivalisteInfo = _context.PrebivalisteInfo.Find(zahtjevZaUpis.PrebivalisteInfoId);
            zahtjevZaUpis.SkolovanjeInfo = _context.SkolovanjeInfo.Find(zahtjevZaUpis.SkolovanjeInfoId);
            zahtjevZaUpis.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaUpis.LicniPodaciId);

            ViewBag.ZahtjevZaUpis = zahtjevZaUpis;

            return View();
        }

        public IActionResult PrihvatiZahtjevZaUpis(int id)
        {
            Zahtjev z = _context.Zahtjev.Find(id);

            _context.Zahtjev.Remove(z);

            ZahtjevZaUpis zahtjevZaUpis = z as ZahtjevZaUpis;
            zahtjevZaUpis.PrebivalisteInfo = _context.PrebivalisteInfo.Find(zahtjevZaUpis.PrebivalisteInfoId);
            zahtjevZaUpis.SkolovanjeInfo = _context.SkolovanjeInfo.Find(zahtjevZaUpis.SkolovanjeInfoId);
            zahtjevZaUpis.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaUpis.LicniPodaciId);

            Student student = new Student();

            student.Username = GenerisiUsernamePremaZahtjevu(zahtjevZaUpis);
            student.Password = zahtjevZaUpis.LicniPodaci.Jmbg.ToString();

            student.BrojRucaka = 0;
            student.BrojVecera = 0;
            student.LicniPodaci = zahtjevZaUpis.LicniPodaci;
            student.PrebivalisteInfo = zahtjevZaUpis.PrebivalisteInfo;
            student.SkolovanjeInfo = zahtjevZaUpis.SkolovanjeInfo;

            student.Soba = NadjiSobu(student);

            _context.Student.Add(student);
            _context.SaveChanges();

            return RedirectToAction("PregledZahtjeva", "Zahtjev");
        }


        public IActionResult OdbijZahtjev(int id)
        {
            Zahtjev zaBrisanje = _context.Zahtjev.Find(id);

            _context.Zahtjev.Remove(zaBrisanje);

            PrebivalisteInfo zaBrisanjeP = new PrebivalisteInfo();
            zaBrisanjeP.PrebivalisteInfoId = zaBrisanjeP.PrebivalisteInfoId;
            _context.PrebivalisteInfo.Remove(zaBrisanjeP);

            SkolovanjeInfo zaBrisanjeS = new SkolovanjeInfo("",0,0,0);
            zaBrisanjeS.SkolovanjeInfoId = zaBrisanjeS.SkolovanjeInfoId;
            _context.SkolovanjeInfo.Remove(zaBrisanjeS);

            LicniPodaci zaBrisanjeL = new LicniPodaci();
            zaBrisanjeL.LicniPodaciId = zaBrisanjeL.LicniPodaciId;
            _context.LicniPodaci.Remove(zaBrisanjeL);

            _context.SaveChanges();

            return RedirectToAction("PregledZahtjeva","Zahtjev");
        }

        public IActionResult PregledPremjestanje(int id)
        {
            ZahtjevZaPremjestanje zahtjevZaPremjestanje = _context.ZahtjevZaPremjestanje.Find(id);

            zahtjevZaPremjestanje.Soba1 = _context.Soba.Find(zahtjevZaPremjestanje.Soba1Id);
            zahtjevZaPremjestanje.Soba2 = _context.Soba.Find(zahtjevZaPremjestanje.Soba2Id);
            zahtjevZaPremjestanje.Paviljon1 = _context.Paviljon.Find(zahtjevZaPremjestanje.Paviljon1Id);
            zahtjevZaPremjestanje.Paviljon2 = _context.Paviljon.Find(zahtjevZaPremjestanje.Paviljon2Id);

            zahtjevZaPremjestanje.Student = _context.Student.Find(zahtjevZaPremjestanje.StudentId);

            zahtjevZaPremjestanje.Student.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaPremjestanje.Student.LicniPodaciId);

            ViewBag.ZahtjevZaPremjestanje = zahtjevZaPremjestanje;

            return View();
        }

        public IActionResult OdobriPremjestanje(int id)
        {
            ZahtjevZaPremjestanje z = _context.ZahtjevZaPremjestanje.Find(id);

            Student s = _context.Student.Find(z.Student.Id);

            // Ostalo da implementiram

            return RedirectToAction("PregledZahtjeva", "Zahtjev");
        }

        public IActionResult OdbijPremjestanje(int id)
        {
            Zahtjev zaBrisanje = _context.Zahtjev.Find(id);

            _context.Zahtjev.Remove(zaBrisanje);
            _context.SaveChanges();

            return RedirectToAction("PregledZahtjeva", "Zahtjev");
        }

        public IActionResult PregledCimeraj(int id)
        {
            ZahtjevZaCimeraj zahtjevZaCimeraj = _context.ZahtjevZaCimeraj.Find(id);

            zahtjevZaCimeraj.Soba = _context.Soba.Find(zahtjevZaCimeraj.SobaId);
            zahtjevZaCimeraj.Paviljon = _context.Paviljon.Find(zahtjevZaCimeraj.PaviljonId);
            zahtjevZaCimeraj.Cimer1 = _context.Student.Find(zahtjevZaCimeraj.Cimer1Id);
            zahtjevZaCimeraj.Cimer1.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaCimeraj.Cimer1.LicniPodaciId);

            zahtjevZaCimeraj.Cimer2 = _context.Student.Find(zahtjevZaCimeraj.Cimer2Id);
            zahtjevZaCimeraj.Cimer2.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaCimeraj.Cimer2.LicniPodaciId);

            zahtjevZaCimeraj.Student = _context.Student.Find(zahtjevZaCimeraj.StudentId);

            zahtjevZaCimeraj.Student.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaCimeraj.Student.LicniPodaciId);

            ViewBag.ZahtjevZaCimeraj = zahtjevZaCimeraj;

            return View();
        }

        public IActionResult OdobriCimeraj(int id)
        {
            return RedirectToAction("PregledZahtjeva", "Zahtjev");
        }

        public IActionResult OdbijCimeraj(int id)
        {
            Zahtjev zaBrisanje = _context.Zahtjev.Find(id);

            _context.Zahtjev.Remove(zaBrisanje);
            _context.SaveChanges();

            return RedirectToAction("PregledZahtjeva", "Zahtjev");
        }

        public IActionResult PregledNabavka(int id)
        {
            return View();
        }

        private Soba NadjiSobu(Student student)
        {
            foreach(Soba s in _context.Soba)
            {
                List<Student> studenti =_context.Student.Where(st => st.SobaId == s.SobaId).ToList();
                if(studenti.Count < s.Kapacitet)
                {
                    studenti.Add(student);
                    s.Students = studenti;

                    _context.Soba.Update(s);

                    return s;
                }
            }

            throw new Exception("Dom je popunjen");
        }

        private string GenerisiUsernamePremaZahtjevu(ZahtjevZaUpis z)
        {
            string korijen = z.LicniPodaci.Ime.Substring(0, 1).ToLower() + z.LicniPodaci.Prezime.ToLower();

            List<Student> studenti = _context.Student.ToList();


            int i = 1;
            string username = korijen + i;

            while (true)
            {
                bool ok = true;
                foreach (Student s in studenti)
                {
                    if (s.Username.Equals(username))
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok)
                {
                    break;
                }
                else
                {
                    i++;
                    username = korijen + i;
                }
            }

            return username;
        }

        private string DajSkracenicuZaKanton(string kanton)
        {
            string skracenica = "???";

            if (kanton.Equals("Unsko-sanski kanton"))
            {
                skracenica = "USK";
            }else if(kanton.Equals("Posavski kanton"))
            {
                skracenica = "PK";
            }else if(kanton.Equals("Tuzlanski kanton"))
            {
                skracenica = "TK";
            }else if(kanton.Equals("Zeničko-dobojski kanton"))
            {
                skracenica = "ZDK";
            }else if(kanton.Equals("Bosansko-podrinjski kanton"))
            {
                skracenica = "BPK";
            }else if(kanton.Equals("Srednjobosanski kanton"))
            {
                skracenica = "SBK";
            }else if(kanton.Equals("Hercegovačko-neretvanski kanton"))
            {
                skracenica = "HNK";
            }else if(kanton.Equals("Zapadnohercegovački kanton"))
            {
                skracenica = "ZHK";
            }else if(kanton.Equals("Kanton Sarajevo"))
            {
                skracenica = "KS";
            }
            else if(kanton.Equals("Kanton 10"))
            {
                skracenica = "K10";
            }

            return skracenica;
        }

        private string DajSkracenicuZaFakultet(string fakultet)
        {
            string skracenica = "???";

            if(fakultet.Equals("Elektrotehnički fakultet"))
            {
                skracenica = "ETF";
            }else if(fakultet.Equals("Medicinski fakultet"))
            {
                skracenica = "MF";
            }else if(fakultet.Equals("Mašinski fakultet"))
            {
                skracenica = "MEF";
            }else if(fakultet.Equals("Građevinski fakultet"))
            {
                skracenica = "GF";
            }else if(fakultet.Equals("Arhitektonski fakultet"))
            {
                skracenica = "AF";
            }else if(fakultet.Equals("Fakultet za kriminalistiku"))
            {
                skracenica = "FKN";
            }else if(fakultet.Equals("Prirodnomatematički fakultet"))
            {
                skracenica = "PMF";
            }else if(fakultet.Equals("Ekonomski fakultet"))
            {
                skracenica = "EF";
            }else if(fakultet.Equals("Pravni fakultet"))
            {
                skracenica = "PF";
            }else if(fakultet.Equals("Filozofski fakultet"))
            {
                skracenica = "FF";
            }

            return skracenica;
        }

        private bool ZahtjevExists(int id)
        {
            return _context.Zahtjev.Any(e => e.ZahtjevId == id);
        }
    }
}
