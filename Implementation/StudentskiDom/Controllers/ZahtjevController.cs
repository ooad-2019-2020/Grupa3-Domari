using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using StudentskiDom.Models;

namespace SD.Controllers
{
    [Authorize(Roles ="Uprava")]
    public class ZahtjevController : Controller
    {
        private readonly StudentskiDomContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly string apiUrl = "https://studentskidomapi2020.azurewebsites.net";

        public ZahtjevController(StudentskiDomContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            StudentskiDomSingleton.getInstance().SetContext(context);
            this.userManager = userManager;
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

            ViewBag.Soba = "/";
            ViewBag.Paviljon = "/";
            ViewBag.Ime = zahtjevZaUpis.LicniPodaci.Ime;
            ViewBag.Prezime = zahtjevZaUpis.LicniPodaci.Prezime;
            ViewBag.Slika = zahtjevZaUpis.LicniPodaci.Slika;
   

            string fakultet = DajSkracenicuZaFakultet(zahtjevZaUpis.SkolovanjeInfo.Fakultet);
            ViewBag.Fakultet = fakultet;

            string kanton = DajSkracenicuZaKanton(zahtjevZaUpis.PrebivalisteInfo.Kanton);
            ViewBag.Kanton = kanton;
            
            ViewBag.ID = zahtjevZaUpis.SkolovanjeInfo.BrojIndeksa;


            return View();
        }

        public async Task<IActionResult> PregledZahtjevaAsync()
        {
            ICollection<Zahtjev> zahtjevi = new Collection<Zahtjev>();

            StudentskiDomSingleton studentskiDom = StudentskiDomSingleton.getInstance();
            await studentskiDom.RefreshZahtjeviAsync();

            foreach(Zahtjev z in studentskiDom.Zahtjevi)
            {
                if(z is ZahtjevZaUpis)
                {
                    ZahtjevZaUpis zahtjevZaUpis = z as ZahtjevZaUpis;

                    //zahtjevZaUpis.PrebivalisteInfo = _context.PrebivalisteInfo.Find(zahtjevZaUpis.PrebivalisteInfoId);
                    //zahtjevZaUpis.SkolovanjeInfo = _context.SkolovanjeInfo.Find(zahtjevZaUpis.SkolovanjeInfoId);
                    //zahtjevZaUpis.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaUpis.LicniPodaciId);

                    zahtjevi.Add(z);
                }else if(z is ZahtjevZaCimeraj)
                {
                    ZahtjevZaCimeraj zahtjevZaCimeraj = z as ZahtjevZaCimeraj;

                    //zahtjevZaCimeraj.Soba = _context.Soba.Find(zahtjevZaCimeraj.SobaId);
                    //zahtjevZaCimeraj.Paviljon = _context.Paviljon.Find(zahtjevZaCimeraj.PaviljonId);
                    ////zahtjevZaCimeraj.Cimer1 = _context.Student.Find(zahtjevZaCimeraj.Cimer1Id);
                    ////zahtjevZaCimeraj.Cimer2 = _context.Student.Find(zahtjevZaCimeraj.Cimer2Id);
                    //
                    ////zahtjevZaCimeraj.Student = _context.Student.Find(zahtjevZaCimeraj.StudentId);
                    //
                    //zahtjevZaCimeraj.Cimer1 = await GetStudentAsync(zahtjevZaCimeraj.Cimer1Id);
                    //zahtjevZaCimeraj.Cimer2 = await GetStudentAsync(zahtjevZaCimeraj.Cimer2Id);
                    //
                    //zahtjevZaCimeraj.Student = await GetStudentAsync(zahtjevZaCimeraj.StudentId);
                    //
                    //zahtjevZaCimeraj.Student.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaCimeraj.Student.LicniPodaciId);

                    zahtjevi.Add(z);
                }else if(z is ZahtjevZaPremjestanje)
                {
                    ZahtjevZaPremjestanje zahtjevZaPremjestanje = z as ZahtjevZaPremjestanje;

                    //zahtjevZaPremjestanje.Soba1 = _context.Soba.Find(zahtjevZaPremjestanje.Soba1Id);
                    //zahtjevZaPremjestanje.Soba2 = _context.Soba.Find(zahtjevZaPremjestanje.Soba2Id);
                    //
                    //zahtjevZaPremjestanje.Paviljon1 = _context.Paviljon.Find(zahtjevZaPremjestanje.Paviljon1Id);
                    //zahtjevZaPremjestanje.Paviljon2 = _context.Paviljon.Find(zahtjevZaPremjestanje.Paviljon2Id);
                    //
                    ////zahtjevZaPremjestanje.Student = _context.Student.Find(zahtjevZaPremjestanje.StudentId);
                    //zahtjevZaPremjestanje.Student= await GetStudentAsync(zahtjevZaPremjestanje.StudentId);
                    //
                    //zahtjevZaPremjestanje.Student.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaPremjestanje.Student.LicniPodaciId);

                    zahtjevi.Add(zahtjevZaPremjestanje);
                }else if(z is ZahtjevZaNabavkuNamirnica)
                {
                    ZahtjevZaNabavkuNamirnica zahtjevZaNabavkuNamirnica = z as ZahtjevZaNabavkuNamirnica;

                    if(z.ZahtjevId == 39)
                    {
                        continue;
                    }

                    zahtjevi.Add(zahtjevZaNabavkuNamirnica);
                }

                
            }

            ViewBag.Zahtjevi = zahtjevi;
            ViewBag.id = UpravaController.UpravaId;

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

        public async Task<IActionResult> PrihvatiZahtjevZaUpis(int id)
        {
            Zahtjev z = _context.Zahtjev.Find(id);

            _context.Zahtjev.Remove(z);

            ZahtjevZaUpis zahtjevZaUpis = z as ZahtjevZaUpis;
            zahtjevZaUpis.PrebivalisteInfo = _context.PrebivalisteInfo.Find(zahtjevZaUpis.PrebivalisteInfoId);
            zahtjevZaUpis.SkolovanjeInfo = _context.SkolovanjeInfo.Find(zahtjevZaUpis.SkolovanjeInfoId);
            zahtjevZaUpis.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaUpis.LicniPodaciId);

            Student student = new Student();

            student.Username = GenerisiUsernamePremaZahtjevu(zahtjevZaUpis);
            //student.Password = zahtjevZaUpis.LicniPodaci.Jmbg.ToString();
            student.Password = student.Username + "123";

            student.BrojRucaka = 0;
            student.BrojVecera = 0;
            
            student.LicniPodaci = zahtjevZaUpis.LicniPodaci;
            student.PrebivalisteInfo = zahtjevZaUpis.PrebivalisteInfo;
            student.SkolovanjeInfo = zahtjevZaUpis.SkolovanjeInfo;

            //student.Soba = NadjiSobu(student);

            IRaspored strategija = new RasporedKanton();
            
            student.Soba = strategija.RasporediStudenta(student);
            
            if(student.Soba == null || student.Soba.Students.Count()==0)
            {
                strategija = new RasporedFakultet();
                student.Soba = strategija.RasporediStudenta(student);
            
                if(student.Soba == null)
                {
                    student.Soba = NadjiSobu(student);
                }
                else
                {
                    List<Student> studenti = _context.Student.Where(st => st.SobaId == student.Soba.SobaId).ToList();
                    if (studenti.Count < student.Soba.Kapacitet)
                    {
                        studenti.Add(student);
                        student.Soba.Students = studenti;

                        _context.Soba.Update(student.Soba);
                    }
                }
            }
            else
            {
                List<Student> studenti = _context.Student.Where(st => st.SobaId == student.Soba.SobaId).ToList();
                if (studenti.Count < student.Soba.Kapacitet)
                {
                    studenti.Add(student);
                    student.Soba.Students = studenti;

                    _context.Soba.Update(student.Soba);
                }
            }

            var user = new IdentityUser { UserName = student.Username };
            var result = await userManager.CreateAsync(user, student.Password);
            await userManager.AddToRoleAsync(user, "Student");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(student,Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });

                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

                HttpResponseMessage Res = await client.PostAsync("api/student/", stringContent);


                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;
                    Debug.WriteLine("ez");
                }
            }

            StudentskiDomSingleton.Context.Mjesec.Add(new Mjesec("Septembar", student.Id));
            StudentskiDomSingleton.Context.Mjesec.Add(new Mjesec("Oktobar", student.Id));
            StudentskiDomSingleton.Context.Mjesec.Add(new Mjesec("Novembar", student.Id));
            StudentskiDomSingleton.Context.Mjesec.Add(new Mjesec("Decembar", student.Id));
            StudentskiDomSingleton.Context.Mjesec.Add(new Mjesec("Januar", student.Id));
            StudentskiDomSingleton.Context.Mjesec.Add(new Mjesec("Februar", student.Id));
            StudentskiDomSingleton.Context.Mjesec.Add(new Mjesec("Mart", student.Id));
            StudentskiDomSingleton.Context.Mjesec.Add(new Mjesec("April", student.Id));
            StudentskiDomSingleton.Context.Mjesec.Add(new Mjesec("Maj", student.Id));
            StudentskiDomSingleton.Context.Mjesec.Add(new Mjesec("Juni", student.Id));
            StudentskiDomSingleton.Context.Mjesec.Add(new Mjesec("Juli", student.Id));
            StudentskiDomSingleton.Context.SaveChanges();

            return RedirectToAction("PregledZahtjeva", "Zahtjev");
        }

        
        public IActionResult OdbijZahtjev(int id)
        {
            ZahtjevZaUpis zaBrisanje = _context.ZahtjevZaUpis.Find(id);

            _context.Zahtjev.Remove(zaBrisanje);

            PrebivalisteInfo zaBrisanjeP = _context.PrebivalisteInfo.Find(zaBrisanje.PrebivalisteInfoId);
            _context.PrebivalisteInfo.Remove(zaBrisanjeP);

            SkolovanjeInfo zaBrisanjeS = _context.SkolovanjeInfo.Find(zaBrisanje.SkolovanjeInfoId);
            _context.SkolovanjeInfo.Remove(zaBrisanjeS);

            LicniPodaci zaBrisanjeL = _context.LicniPodaci.Find(zaBrisanje.LicniPodaciId);
            _context.LicniPodaci.Remove(zaBrisanjeL);

            _context.SaveChanges();

            return RedirectToAction("PregledZahtjeva","Zahtjev");
        }

        public async Task<IActionResult> PregledPremjestanjeAsync(int id)
        {
            ZahtjevZaPremjestanje zahtjevZaPremjestanje = _context.ZahtjevZaPremjestanje.Find(id);

            zahtjevZaPremjestanje.Soba1 = _context.Soba.Find(zahtjevZaPremjestanje.Soba1Id);
            zahtjevZaPremjestanje.Soba2 = _context.Soba.Find(zahtjevZaPremjestanje.Soba2Id);
            zahtjevZaPremjestanje.Paviljon1 = _context.Paviljon.Find(zahtjevZaPremjestanje.Paviljon1Id);
            zahtjevZaPremjestanje.Paviljon2 = _context.Paviljon.Find(zahtjevZaPremjestanje.Paviljon2Id);

            //zahtjevZaPremjestanje.Student = _context.Student.Find(zahtjevZaPremjestanje.StudentId);
            zahtjevZaPremjestanje.Student= await GetStudentAsync(zahtjevZaPremjestanje.StudentId);

            zahtjevZaPremjestanje.Student.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaPremjestanje.Student.LicniPodaciId);

            ViewBag.ZahtjevZaPremjestanje = zahtjevZaPremjestanje;

            return View();
        }

        public async Task<IActionResult> OdobriPremjestanjeAsync(int id)
        {
            ZahtjevZaPremjestanje z = _context.ZahtjevZaPremjestanje.Find(id);

            Student s = _context.Student.Find(z.StudentId);
            //Student s= await GetStudentAsync(z.StudentId);

            z.Soba2Id = z.Soba2Id + (z.Paviljon2Id-1)*25;

            Soba soba = _context.Soba.Find(z.Soba2Id);

            List<Student> studentiUSobi = _context.Student.Where(s => s.SobaId == z.Soba2Id).ToList();

            if(studentiUSobi.Count >= soba.Kapacitet)
            {
                throw new Exception("Nema mjesta u sobi u koju student želi da se premjeti");
            }

            _context.Zahtjev.Remove(z);

            s.SobaId = z.Soba2Id;

            _context.Student.Update(s);
            _context.SaveChanges();

            return RedirectToAction("PregledZahtjeva", "Zahtjev");
        }

        public IActionResult OdbijPremjestanje(int id)
        {
            Zahtjev zaBrisanje = _context.Zahtjev.Find(id);

            _context.Zahtjev.Remove(zaBrisanje);
            _context.SaveChanges();

            return RedirectToAction("PregledZahtjeva", "Zahtjev");
        }

        public async Task<IActionResult> PregledCimerajAsync(int id)
        {
            ZahtjevZaCimeraj zahtjevZaCimeraj = _context.ZahtjevZaCimeraj.Find(id);

            zahtjevZaCimeraj.Soba = _context.Soba.Find(zahtjevZaCimeraj.SobaId);
            zahtjevZaCimeraj.Paviljon = _context.Paviljon.Find(zahtjevZaCimeraj.PaviljonId);
            //zahtjevZaCimeraj.Cimer1 = _context.Student.Find(zahtjevZaCimeraj.Cimer1Id);
            zahtjevZaCimeraj.Cimer1= await GetStudentAsync(zahtjevZaCimeraj.Cimer1Id);
            zahtjevZaCimeraj.Cimer1.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaCimeraj.Cimer1.LicniPodaciId);

            //zahtjevZaCimeraj.Cimer2 = _context.Student.Find(zahtjevZaCimeraj.Cimer2Id);
            zahtjevZaCimeraj.Cimer2 = await GetStudentAsync(zahtjevZaCimeraj.Cimer2Id);
            zahtjevZaCimeraj.Cimer2.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaCimeraj.Cimer2.LicniPodaciId);

            zahtjevZaCimeraj.Student = _context.Student.Find(zahtjevZaCimeraj.StudentId);

            zahtjevZaCimeraj.Student.LicniPodaci = _context.LicniPodaci.Find(zahtjevZaCimeraj.Student.LicniPodaciId);

            ViewBag.ZahtjevZaCimeraj = zahtjevZaCimeraj;

            return View();
        }

        public async Task<IActionResult> OdobriCimerajAsync(int id)
        {
            ZahtjevZaCimeraj zahtjevZaCimeraj = _context.ZahtjevZaCimeraj.Find(id);

            ZahtjevZaCimeraj zahtjevPrvogCimera = _context.ZahtjevZaCimeraj.FirstOrDefault(z => z.StudentId == zahtjevZaCimeraj.Cimer1Id); ;
            ZahtjevZaCimeraj zahtjevDrugogCimera = _context.ZahtjevZaCimeraj.FirstOrDefault(z => z.StudentId == zahtjevZaCimeraj.Cimer2Id);

            int potrebnoMjesta = 3;

            if (zahtjevZaCimeraj.Cimer1Id == 0)
            {
                zahtjevPrvogCimera = zahtjevDrugogCimera;
                zahtjevDrugogCimera = null;
                potrebnoMjesta--;
            }

            if (zahtjevZaCimeraj.Cimer2Id == 0)
            {
                potrebnoMjesta--;
            }

            if (potrebnoMjesta == 1)
            {
                throw new Exception("Student nije naveo cimere");
            }

            if (zahtjevPrvogCimera == null || zahtjevZaCimeraj.Cimer2Id != 0 && zahtjevDrugogCimera == null)
            {
                throw new Exception("Svi cimeri moraju postati zahtjev za cimeraj");
            }

            if (potrebnoMjesta == 2)
            {
                if (zahtjevPrvogCimera.Cimer1Id == zahtjevZaCimeraj.StudentId || zahtjevPrvogCimera.Cimer2Id == zahtjevZaCimeraj.StudentId)
                {
                    provjeriSobe(zahtjevZaCimeraj, zahtjevPrvogCimera);
                }
                else
                {
                    throw new Exception("Svi cimeri moraju poslati zahtjev za cimeraj");
                }
            }
            else
            {
                if((zahtjevZaCimeraj.StudentId == zahtjevPrvogCimera.Cimer1Id || zahtjevZaCimeraj.StudentId == zahtjevPrvogCimera.Cimer2Id) &&
                    (zahtjevZaCimeraj.StudentId == zahtjevDrugogCimera.Cimer1Id || zahtjevZaCimeraj.StudentId == zahtjevDrugogCimera.Cimer2Id))
                {
                    provjeriSobe(zahtjevZaCimeraj, zahtjevPrvogCimera);
                    provjeriSobe(zahtjevZaCimeraj, zahtjevDrugogCimera);
                }
                else
                {
                    throw new Exception("Svi cimeri moraju poslati zahtjev za cimeraj");
                }
            }

            Soba soba = _context.Soba.Find(zahtjevZaCimeraj.SobaId);

            List<Student> studentiUSobi = _context.Student.Where(s => s.SobaId == soba.SobaId).ToList();

            if (studentiUSobi.Count + potrebnoMjesta > soba.Kapacitet)
            {
                throw new Exception("Nema dovoljno mjesta u sobi u koju student sa cimerima želi da bude");
            }

            Student student = _context.Student.Find(zahtjevZaCimeraj.StudentId);
            student.SobaId = soba.SobaId;
            _context.Student.Update(student);

            if (zahtjevZaCimeraj.Cimer1Id != 0)
            {
                Student student1 = await GetStudentAsync(zahtjevZaCimeraj.Cimer1Id);
                student1.SobaId = soba.SobaId;
                _context.Student.Update(student1);
            }

            if (zahtjevZaCimeraj.Cimer2Id != 0)
            {
                //Student student2 = _context.Student.Find(zahtjevZaCimeraj.Cimer2Id);
                Student student2 = await GetStudentAsync(zahtjevZaCimeraj.Cimer2Id);
                student2.SobaId = soba.SobaId;
                _context.Student.Update(student2);
            }

            _context.Zahtjev.Remove(zahtjevZaCimeraj);
            _context.Zahtjev.Remove(zahtjevPrvogCimera);
            if(zahtjevDrugogCimera == null)
            {
                _context.Zahtjev.Remove(zahtjevDrugogCimera);
            }

            _context.SaveChanges();

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
            ZahtjevZaNabavkuNamirnica zahtjevZaNabavkuNamirnica = _context.ZahtjevZaNabavkuNamirnica.Find(id);

            zahtjevZaNabavkuNamirnica.StavkeNadruzbe = _context.StavkaNarudzbe.Where(sn => sn.ZahtjevZaNabavkuNamirnicaId == zahtjevZaNabavkuNamirnica.ZahtjevId).ToList();

            ViewBag.ZahtjevZaNabavkuNamirnica = zahtjevZaNabavkuNamirnica;

            return View();
        }

        public IActionResult OdobriNamirnice(int id)
        {
            ZahtjevZaNabavkuNamirnica zahtjevZaNabavkuNamirnica = _context.ZahtjevZaNabavkuNamirnica.Find(id);

            foreach (StavkaNarudzbe sn in _context.StavkaNarudzbe.Where(sn => sn.ZahtjevZaNabavkuNamirnicaId == zahtjevZaNabavkuNamirnica.ZahtjevId).ToList())
            {
                _context.StavkaNarudzbe.Remove(sn);
            }

            _context.ZahtjevZaNabavkuNamirnica.Remove(zahtjevZaNabavkuNamirnica);
            _context.SaveChanges();

            return RedirectToAction("PregledZahtjeva", "Zahtjev");
        }

        public IActionResult OdbijNamirnice(int id)
        {
            ZahtjevZaNabavkuNamirnica zahtjevZaNabavkuNamirnica = _context.ZahtjevZaNabavkuNamirnica.Find(id);

            foreach(StavkaNarudzbe sn in _context.StavkaNarudzbe.Where(sn => sn.ZahtjevZaNabavkuNamirnicaId == zahtjevZaNabavkuNamirnica.ZahtjevId).ToList())
            {
                _context.StavkaNarudzbe.Remove(sn);
            }

            _context.ZahtjevZaNabavkuNamirnica.Remove(zahtjevZaNabavkuNamirnica);
            _context.SaveChanges();

            return RedirectToAction("PregledZahtjeva", "Zahtjev");
        }

        public IActionResult PregledPodataka(int id)
        {
            ZahtjevZaUpis zahtjevZaUpis = _context.ZahtjevZaUpis.Find(id);

            zahtjevZaUpis.LicniPodaci = _context.LicniPodaci.FirstOrDefault(lp => lp.LicniPodaciId == zahtjevZaUpis.LicniPodaciId);

            ViewBag.Id = id;
            ViewBag.Username = GenerisiUsernamePremaZahtjevu(zahtjevZaUpis);
            ViewBag.Password = ViewBag.Username + "123";

            return View();
        }

        private void provjeriSobe(ZahtjevZaCimeraj zahtjevZaCimeraj, ZahtjevZaCimeraj zahtjevPrvogCimera)
        {
            if(zahtjevZaCimeraj.PaviljonId != zahtjevPrvogCimera.PaviljonId || zahtjevZaCimeraj.SobaId != zahtjevPrvogCimera.SobaId)
            {
                throw new Exception("Sobe moraju biti iste u svim zahtjevima");
            }
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

            StringBuilder builder = new StringBuilder(korijen);

            for(int i=0; i<builder.Length; i++)
            {
                if (builder[i] == 'č' || builder[i] == 'ć')
                {
                    builder[i] = 'c';
                }else if(builder[i] == 'š')
                {
                    builder[i] = 's';
                }else if(builder[i] == 'ž')
                {
                    builder[i] = 'z';
                }else if(builder[i] == 'đ')
                {
                    builder[i] = 'd';
                }
            }

            korijen = builder.ToString();

            List<Student> studenti = _context.Student.ToList();


            int k = 1;
            string username = korijen + k;

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
                    k++;
                    username = korijen + k;
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

        private async Task<Student> GetStudentAsync(int id)
        {
            Student s = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/student/" + id);


                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;

                    s = JsonConvert.DeserializeObject<Student>(response);
                    s.PrebivalisteInfo = _context.PrebivalisteInfo.Find(s.PrebivalisteInfoId);
                    s.SkolovanjeInfo = _context.SkolovanjeInfo.Find(s.SkolovanjeInfoId);
                    s.LicniPodaci = _context.LicniPodaci.Find(s.LicniPodaciId);
                    s.Soba = _context.Soba.Find(s.SobaId);
                    s.Soba.Paviljon = _context.Paviljon.Find(s.Soba.PaviljonId);
                    s.Mjesec = _context.Mjesec.Where(m => m.StudentId == s.Id).ToList();
                }
            }
            return s;
        }
    }
}
