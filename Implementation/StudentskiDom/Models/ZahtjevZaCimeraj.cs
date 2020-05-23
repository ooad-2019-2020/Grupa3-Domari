using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class ZahtjevZaCimeraj : ZahtjevStudenta
    {
        private Paviljon paviljon;

        public Paviljon Paviljon
        {
            get { return paviljon; }
            set { paviljon = value; }
        }

        private Soba soba;

        public Soba Soba
        {
            get { return soba; }
            set { soba = value; }
        }

        private Student prviCimer;

        public Student PrviCimer
        {
            get { return prviCimer; }
            set { prviCimer = value; }
        }

        private Student drugiCimer;

        public Student DrugiCimer
        {
            get { return drugiCimer; }
            set { drugiCimer = value; }
        }

        private string dodatneNapomene;

        public string DodatneNapomene
        {
            get { return dodatneNapomene; }
            set { dodatneNapomene = value; }
        }

        public ZahtjevZaCimeraj(Paviljon paviljon, Soba soba, Student prviCimer, Student drugiCimer, string dodatneNapomene,
            Korisnik podnosilacZahtjeva, DateTime datum) : base(podnosilacZahtjeva, datum)
        {
            Paviljon = paviljon;
            Soba = soba;
            PrviCimer = prviCimer;
            DrugiCimer = drugiCimer;
            DodatneNapomene = dodatneNapomene;
        }
    }
}
