using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace StudentskiDom.Models
{
    public class Student : Korisnik
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private LicniPodaci licniPodaci;

        public LicniPodaci LicniPodaci
        {
            get { return licniPodaci; }
            set { licniPodaci = value; }
        }

        private PrebivalisteInfo prebivalisteInfo;

        public PrebivalisteInfo PrebivalisteInfo
        {
            get { return prebivalisteInfo; }
            set { prebivalisteInfo = value; }
        }

        private SkolovanjeInfo skolovanjeInfo;

        public SkolovanjeInfo SkolovanjeInfo
        {
            get { return skolovanjeInfo; }
            set { skolovanjeInfo = value; }
        }

        private Soba soba;

        public Soba Soba
        {
            get { return soba; }
            set { soba = value; }
        }

        private int brojRucaka;

        public int BrojRucaka
        {
            get { return brojRucaka; }
            set { brojRucaka = value; }
        }

        private int brojVecera;

        public int BrojVecera
        {
            get { return brojVecera; }
            set { brojVecera = value; }
        }

        public Student(int id, LicniPodaci podaci, PrebivalisteInfo prebivaliste, SkolovanjeInfo skolovanje,
            Soba soba, int brojRucaka, int brojVecera)
        {
            Id = id;
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
