using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace StudentskiDom.Models
{
    public class Student : Korisnik
    {
        public int StudentId { get; set; }
        public LicniPodaci LicniPodaci { get; set; }
        public PrebivalisteInfo PrebivalisteInfo { get; set; }
        public SkolovanjeInfo SkolovanjeInfo { get; set; }
        public Soba Soba { get; set; }
        public int BrojRucaka { get; set; }
        public int BrojVecera { get; set; }

        // Veze sa ostalim klasama
        public virtual Korisnik Korisnik { get; set; }
        public virtual PrebivalisteInfo PrebivalisteInfo { get; set; }
        public virtual LicniPodaci LicniPodaci { get; set; }
        public virtual SkolovanjeInfo SkolovanjeInfo { get; set; }
        public virtual Restoran Restoran { get; set; }
        public virtual Blagajna Blagajna { get; set; }
        public virtual Soba Soba { get; set; }
        public virtual ZahtjevZaCimeraj ZahtjevZaCimeraj1 { get; set; }
        public virtual ZahtjevZaCimeraj ZahtjevZaCimeraj2 { get; set; }


        public Student(int id, LicniPodaci podaci, PrebivalisteInfo prebivaliste, SkolovanjeInfo skolovanje,
            Soba soba, int brojRucaka, int brojVecera)
        {
            StudentId = id;
            LicniPodaci = podaci;
            PrebivalisteInfo = prebivaliste;
            SkolovanjeInfo = skolovanje;
            Soba = soba;
            BrojRucaka = brojRucaka;
            BrojVecera = brojVecera;
        }

        public void azurirajLicnePodatke(string prezime, string ime, string mjestoRodjenja, Pol pol, string email,
            long jmbg, DateTime datumRodjenja, int mobitel, string slika)
        {
            LicniPodaci = new LicniPodaci(prezime, ime, mjestoRodjenja, pol, email, jmbg, datumRodjenja, mobitel, slika);
        }

        public void azurirajSkolovanje(string fakultet, int brojIndeksa, int ciklusStudija, int godinaStudija)
        {
            SkolovanjeInfo = new SkolovanjeInfo(fakultet, brojIndeksa, ciklusStudija, godinaStudija);   
        }
    }
}
