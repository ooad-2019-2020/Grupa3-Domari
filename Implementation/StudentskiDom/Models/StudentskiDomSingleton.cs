using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class StudentskiDomSingleton : IStudentskiDom
    {
        private List<Student> studenti;
        private Uprava uprava;
        private Restoran restoran;
        private List<Zahtjev> zahtjevi;
        private List<Paviljon> paviljoni;
        private IRaspored strategy;
        private static StudentskiDomSingleton instance;
        private readonly string apiUrl = "https://studentskidomapi2020.azurewebsites.net";
        public static StudentskiDomContext Context { get; set; }

        public List<Student> Studenti { get { return studenti; } set { studenti = value; } }
        public List<Zahtjev> Zahtjevi { get { return zahtjevi; } set { zahtjevi = value; } }
        public List<Paviljon> Paviljoni { get { return paviljoni; } set { paviljoni = value; } }
        public Uprava Uprava { get { return uprava; } set { uprava = value; } }
        public Restoran Restoran { get { return restoran; } set { restoran = value; } }
        public IRaspored Strategy { get { return strategy; } set { strategy = value; } }
        public void DodajZahtjev(Zahtjev zahtjev)
        {
            zahtjevi.Add(zahtjev);
        }
        public bool DaLiImaMjesta()
        {
            return true;
        }
        public Student NadjiStudentaPoIDu(int id)
        {
            return null;
        }

        private StudentskiDomSingleton()
        {
         
        }

        public static StudentskiDomSingleton getInstance()
        {
            if (instance == null)
            { 
                instance = new StudentskiDomSingleton();
            }

            return instance;
        }

        public void PostaviStrategiju(IRaspored strategy)
        {

        }

        public List<Student> FiltrirajPoKantonu(List<Student> studenti, string kanton)
        {
            return studenti;
        }

        public List<Student> SortirajPoGodiniStudija(List<Student> studenti, bool desc)
        {
            return studenti;
        }

        public void UpisiStudenta(Student student)
        {
            throw new NotImplementedException();
        }

        public void BrisiStudenta(Student student)
        {
            throw new NotImplementedException();
        }

        public void ObradiZahtjev(Zahtjev zahtjev)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> RefreshStudentsAsync()
        {

            List<Student> studenti = new List<Student>();

            using (var client = new HttpClient())
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
                        s.PrebivalisteInfo = Context.PrebivalisteInfo.Find(s.PrebivalisteInfoId);
                        s.SkolovanjeInfo = Context.SkolovanjeInfo.Find(s.SkolovanjeInfoId);
                        s.LicniPodaci = Context.LicniPodaci.Find(s.LicniPodaciId);
                        s.Soba = Context.Soba.Find(s.SobaId);
                        s.Soba.Paviljon = Context.Paviljon.Find(s.Soba.PaviljonId);
                    }
                }
            }
            Studenti = studenti;

            return studenti;
        }

        public async Task<List<Zahtjev>> RefreshZahtjeviAsync(){
            List<Zahtjev> zahtjevi = new List<Zahtjev>();

            zahtjevi = Context.Zahtjev.ToList();

            List<Zahtjev> zahtjeviCasted = new List<Zahtjev>();

            foreach(Zahtjev z in zahtjevi)
            {
                if(z is ZahtjevZaUpis)
                {
                    ZahtjevZaUpis zahtjevZaUpis = z as ZahtjevZaUpis;

                    zahtjevZaUpis.PrebivalisteInfo = Context.PrebivalisteInfo.Find(zahtjevZaUpis.PrebivalisteInfoId);
                    zahtjevZaUpis.SkolovanjeInfo = Context.SkolovanjeInfo.Find(zahtjevZaUpis.SkolovanjeInfoId);
                    zahtjevZaUpis.LicniPodaci = Context.LicniPodaci.Find(zahtjevZaUpis.LicniPodaciId);

                    zahtjeviCasted.Add(zahtjevZaUpis);
                }else if(z is ZahtjevZaCimeraj)
                {
                    ZahtjevZaCimeraj zahtjevZaCimeraj = z as ZahtjevZaCimeraj;

                    zahtjevZaCimeraj.Soba = Context.Soba.Find(zahtjevZaCimeraj.SobaId);
                    zahtjevZaCimeraj.Paviljon = Context.Paviljon.Find(zahtjevZaCimeraj.PaviljonId);
                    //zahtjevZaCimeraj.Cimer1 = _context.Student.Find(zahtjevZaCimeraj.Cimer1Id);
                    zahtjevZaCimeraj.Cimer1 = await GetStudentAsync(zahtjevZaCimeraj.Cimer1Id);
                    zahtjevZaCimeraj.Cimer1.LicniPodaci = Context.LicniPodaci.Find(zahtjevZaCimeraj.Cimer1.LicniPodaciId);

                    //zahtjevZaCimeraj.Cimer2 = _context.Student.Find(zahtjevZaCimeraj.Cimer2Id);
                    zahtjevZaCimeraj.Cimer2 = await GetStudentAsync(zahtjevZaCimeraj.Cimer2Id);
                    zahtjevZaCimeraj.Cimer2.LicniPodaci = Context.LicniPodaci.Find(zahtjevZaCimeraj.Cimer2.LicniPodaciId);

                    zahtjevZaCimeraj.Student = await GetStudentAsync(zahtjevZaCimeraj.StudentId);

                    zahtjevZaCimeraj.Student.LicniPodaci = Context.LicniPodaci.Find(zahtjevZaCimeraj.Student.LicniPodaciId);

                    zahtjeviCasted.Add(zahtjevZaCimeraj);
                }else if(z is ZahtjevZaPremjestanje)
                {
                    ZahtjevZaPremjestanje zahtjevZaPremjestanje = z as ZahtjevZaPremjestanje;

                    zahtjevZaPremjestanje.Soba1 = Context.Soba.Find(zahtjevZaPremjestanje.Soba1Id);
                    zahtjevZaPremjestanje.Soba2 = Context.Soba.Find(zahtjevZaPremjestanje.Soba2Id);
                    zahtjevZaPremjestanje.Paviljon1 = Context.Paviljon.Find(zahtjevZaPremjestanje.Paviljon1Id);
                    zahtjevZaPremjestanje.Paviljon2 = Context.Paviljon.Find(zahtjevZaPremjestanje.Paviljon2Id);

                    //zahtjevZaPremjestanje.Student = _context.Student.Find(zahtjevZaPremjestanje.StudentId);
                    zahtjevZaPremjestanje.Student = await GetStudentAsync(zahtjevZaPremjestanje.StudentId);

                    zahtjevZaPremjestanje.Student.LicniPodaci = Context.LicniPodaci.Find(zahtjevZaPremjestanje.Student.LicniPodaciId);

                    zahtjeviCasted.Add(zahtjevZaPremjestanje);
                }else if(z is ZahtjevZaNabavkuNamirnica)
                {
                    ZahtjevZaNabavkuNamirnica zahtjevZaNabavkuNamirnica = z as ZahtjevZaNabavkuNamirnica;

                    zahtjevZaNabavkuNamirnica.StavkeNadruzbe = Context.StavkaNarudzbe.Where(sn => sn.ZahtjevZaNabavkuNamirnicaId == zahtjevZaNabavkuNamirnica.ZahtjevId).ToList();

                    zahtjeviCasted.Add(zahtjevZaNabavkuNamirnica);
                }
            }


            Zahtjevi = zahtjeviCasted;
            return zahtjeviCasted;
        }

        public void SetContext(StudentskiDomContext context)
        {
            Context = context;
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
                    s.PrebivalisteInfo = Context.PrebivalisteInfo.Find(s.PrebivalisteInfoId);
                    s.SkolovanjeInfo = Context.SkolovanjeInfo.Find(s.SkolovanjeInfoId);
                    s.LicniPodaci = Context.LicniPodaci.Find(s.LicniPodaciId);
                    s.Soba = Context.Soba.Find(s.SobaId);
                    s.Soba.Paviljon = Context.Paviljon.Find(s.Soba.PaviljonId);
                }
            }
            return s;
        }

        public async Task<Uprava> RefreshUpravaAsync()
        {
            Uprava uprava = Context.Uprava.FirstOrDefault();

            uprava.Blagajna = Context.Blagajna.FirstOrDefault(b => b.UpravaId == uprava.Id);

            Uprava = uprava;

            return uprava;
        }

        public async Task<List<Paviljon>> RefreshPaviljonAsync()
        {
            List<Paviljon> paviljoni = new List<Paviljon>();

            StudentskiDomSingleton studentskiDom = StudentskiDomSingleton.getInstance();

            paviljoni = Context.Paviljon.ToList();

            foreach(Paviljon p in paviljoni)
            {
                p.Sobe = Context.Soba.Where(s => s.PaviljonId == p.PaviljonId).ToList();
            }

            Paviljoni = paviljoni;
            
            return paviljoni;
        }

        public async Task<Restoran> RefreshRestoranAsync()
        {
            Restoran restoran = Context.Restoran.FirstOrDefault();

            restoran.DnevniMeni = Context.DnevniMeni.FirstOrDefault(dm => dm.DnevniMeniId == restoran.DnevniMeniId);
            restoran.DnevniMeni.Rucak = Context.Rucak.Where(r => r.DnevniMeniId == restoran.DnevniMeniId).ToList();
            restoran.DnevniMeni.Vecera = Context.Vecera.Where(v => v.DnevniMeniId == restoran.DnevniMeniId).ToList();

            Restoran = restoran;

            return restoran;
        }
    }
}
