using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class LicniPodaci
    {
        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string mjestoRodjenja;

        public string MjestoRodjenja
        {
            get { return mjestoRodjenja; }
            set { mjestoRodjenja = value; }
        }

        private Pol pol;

        public Pol Pol
        {
            get { return pol; }
            set { pol = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private long jmbg;

        public long Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        private DateTime datumRodjenja;

        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }

        private int mobitel;

        public int Mobitel
        {
            get { return mobitel; }
            set { mobitel = value; }
        }

        private string slika;

        public String Slika
        {
            get { return slika; }
            set { slika = value; }
        }

        public LicniPodaci(string prezime, string ime, string mjestoRodjenja, Pol pol, string email,
            long jmbg, DateTime datumRodjenja, int mobitel, string slika)
        {
            Prezime = prezime;
            Ime = ime;
            MjestoRodjenja = mjestoRodjenja;
            Pol = pol;
            Email = email;
            Jmbg = jmbg;
            DatumRodjenja = datumRodjenja;
            Mobitel = mobitel;
            Slika = slika;
        }
    }
}
