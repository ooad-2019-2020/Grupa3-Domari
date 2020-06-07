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
using Microsoft.AspNetCore.Authorization;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Identity;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace SD.Controllers
{
    
    [Authorize(Roles = "Uprava")]
    public class UpravaController : Controller
    {
        private readonly string apiUrl = "https://studentskidomapi2020.azurewebsites.net";
        private readonly StudentskiDomContext _context;
        public static List<Student> studentiSoba;
        public static List<Soba> sobe;
        public static List<Paviljon> paviljoni;
        public static int IdTrenutnogStudenta = -1;
        public static int UpravaId = 2;

        public UpravaController(StudentskiDomContext context)
        {
            _context = context;
            StudentskiDomSingleton.getInstance().SetContext(context);
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


        public async Task<IActionResult> BlagajnaAsync(int? StudentId)
        {
            //naci blagajnu iz uprava id, a kao parametar nek se prima student

            Blagajna blagajna = StudentskiDomSingleton.getInstance().Uprava.Blagajna;           

            ViewBag.Blagajna = blagajna;
            ViewBag.mjeseci = new List<String>();
            if (StudentId == null)
            {
                return View();
            }
            else
            {
                Student s=new Student();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = await client.GetAsync("api/student/" + StudentId);


                    if (Res.IsSuccessStatusCode)
                    {
                        var response = Res.Content.ReadAsStringAsync().Result;

                        s = JsonConvert.DeserializeObject<Student>(response);
                        s.PrebivalisteInfo = _context.PrebivalisteInfo.Find(s.PrebivalisteInfoId);
                        s.SkolovanjeInfo = _context.SkolovanjeInfo.Find(s.SkolovanjeInfoId);
                        s.LicniPodaci = _context.LicniPodaci.Find(s.LicniPodaciId);
                        s.Soba = _context.Soba.Find(s.SobaId);
                        s.Soba.Paviljon = _context.Paviljon.Find(s.Soba.PaviljonId);
                    }
                }

                if (s == null)
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
                    s.Soba = _context.Soba.Find(s.SobaId);
                    s.SkolovanjeInfo = _context.SkolovanjeInfo.Find(s.SkolovanjeInfoId);
                    s.PrebivalisteInfo = _context.PrebivalisteInfo.Find(s.PrebivalisteInfoId);
                    s.LicniPodaci = _context.LicniPodaci.Find(s.LicniPodaciId);
                    s.Mjesec = _context.Mjesec.Where(m => m.StudentId== s.Id).ToList();
                    ViewBag.Ime = s.LicniPodaci.Ime;
                    ViewBag.Prezime = s.LicniPodaci.Prezime;
                    ViewBag.Fakultet = s.SkolovanjeInfo.Fakultet;
                    ViewBag.Kanton = s.PrebivalisteInfo.Kanton;
                    ViewBag.Soba = s.Soba.BrojSobe;
                    ViewBag.mjeseci = s.Mjesec;
                    return View();
                }
            }
        }

        [HttpPost]
        public IActionResult UplatiMjesec(IFormCollection forma)
        {
            string mjesec = forma["dlMjesec"];
            if(IdTrenutnogStudenta!=-1 && !mjesec.Equals(""))
            {
                Mjesec m = _context.Mjesec.Find(Int32.Parse(mjesec));
                _context.Mjesec.Remove(m);

                int dodajUBudzet = 158;
                if (m.Naziv.Equals("Septembar") || m.Naziv.Equals("Juli"))
                    dodajUBudzet /= 2;

                Blagajna blagajna = StudentskiDomSingleton.getInstance().Uprava.Blagajna;
                blagajna.StanjeBudgeta += dodajUBudzet;

                _context.Blagajna.Update(blagajna);
                _context.SaveChanges();
            }

            Debug.WriteLine("Hocel nekad nesta da se desi - "  + mjesec + " - " + IdTrenutnogStudenta);

            return RedirectToAction("Blagajna", "Uprava");
        }


        public IActionResult Uprava(int? id)
        {
            Uprava uprava = StudentskiDomSingleton.getInstance().Uprava;
            UpravaId = (int) id;
            ViewBag.id = id;
            return View();
        }

        public async Task<IActionResult> SmjestajniKapacitetAsync()
        {
            StudentskiDomSingleton studentskiDom = StudentskiDomSingleton.getInstance();
            await studentskiDom.RefreshPaviljonAsync();

            ViewBag.paviljoni = studentskiDom.Paviljoni;
            ViewBag.sobe = _context.Soba.ToList();
            ViewBag.id = UpravaId;
            if (studentiSoba == null)
            {
                await SetStudentsSobaAsync(_context.Paviljon.FirstOrDefault().PaviljonId, _context.Soba.FirstOrDefault().SobaId);
            }
            ViewBag.studentiSoba = studentiSoba;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DajKpacitetAsync(IFormCollection forma)
        {
            int paviljonId = Int32.Parse(forma["dlPaviljon"]);
            int sobaId = Int32.Parse(forma["dlSoba"]);
            await SetStudentsSobaAsync(paviljonId, sobaId);
            return RedirectToAction("SmjestajniKapacitet", "Uprava");
        }


        [HttpPost]
        public async Task<ActionResult> ProvjeriIDAsync(IFormCollection forma)
        {
            if (forma["fldStudentId"].Equals(""))
            {
                IdTrenutnogStudenta = -1;
                return RedirectToAction("Blagajna", "Uprava");
            }
            
            
            IdTrenutnogStudenta = Int32.Parse(forma["fldStudentId"].ToString());
           
            Student student = new Student();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/student/" + IdTrenutnogStudenta);

                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;

                    student = JsonConvert.DeserializeObject<Student>(response);
                    student.PrebivalisteInfo = _context.PrebivalisteInfo.Find(student.PrebivalisteInfoId);
                    student.SkolovanjeInfo = _context.SkolovanjeInfo.Find(student.SkolovanjeInfoId);
                    student.LicniPodaci = _context.LicniPodaci.Find(student.LicniPodaciId);
                    student.Soba = _context.Soba.Find(student.SobaId);
                    student.Soba.Paviljon = _context.Paviljon.Find(student.Soba.PaviljonId);
                }
            }

            if (student == null)
            {
                //error neki
            }
            else
            {
                return RedirectToAction("Blagajna", "Uprava", new { StudentId = IdTrenutnogStudenta });
            }
            return RedirectToAction("Blagajna", "Uprava");
          
        }


        public async Task<IActionResult> ListaStudenata()
        {

            StudentskiDomSingleton studentskiDom = StudentskiDomSingleton.getInstance();
            await studentskiDom.RefreshStudentsAsync();

            List<Student> studenti = studentskiDom.Studenti;

            ViewBag.ListaStudenata = studenti;
            ViewBag.id = UpravaId;

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

        public async Task<IActionResult> ListaStudenataFakultetSort()
        {
            List<Student> studenti = StudentskiDomSingleton.getInstance().Studenti;

            studenti.Sort((Student s1, Student s2) => string.Compare(s1.SkolovanjeInfo.Fakultet, s2.SkolovanjeInfo.Fakultet));
            ViewBag.ListaStudenata = studenti;
            ViewBag.id = UpravaId;

            return View();
        }

        public async Task<IActionResult> ListaStudenataKantonSortAsync()
        {
            List<Student> studenti = StudentskiDomSingleton.getInstance().Studenti;

            studenti.Sort((Student s1, Student s2) => string.Compare(s1.PrebivalisteInfo.Kanton, s2.PrebivalisteInfo.Kanton));
            ViewBag.ListaStudenata = studenti;
            ViewBag.id = UpravaId;

            return View();
        }

        private bool UpravaExists(int id)
        {
            return _context.Uprava.Any(e => e.Id == id);
        }

        private async Task<List<Student>> GetStudentsAsync()
        {
            
            List<Student> studenti = new List<Student>();
            
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/student/");

                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;
                    studenti = JsonConvert.DeserializeObject<List<Student>>(response);
                    foreach (Student s in studenti)
                    {
                        s.PrebivalisteInfo = _context.PrebivalisteInfo.Find(s.PrebivalisteInfoId);
                        s.SkolovanjeInfo = _context.SkolovanjeInfo.Find(s.SkolovanjeInfoId);
                        s.LicniPodaci = _context.LicniPodaci.Find(s.LicniPodaciId);
                        s.Soba = _context.Soba.Find(s.SobaId);
                        s.Soba.Paviljon = _context.Paviljon.Find(s.Soba.PaviljonId);
                    }
                }                
            }
            return studenti;
        }

        private async Task SetStudentsSobaAsync(int paviljonId, int sobaId)
        {

            List<Student> studenti = await GetStudentsAsync();
            if (studentiSoba == null)
            {
                studentiSoba = new List<Student>();
            }
                
            studentiSoba.Clear();

            foreach(Student s in studenti)
            {
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
            }
        }              
    }
}
