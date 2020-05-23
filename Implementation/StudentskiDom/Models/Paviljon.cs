using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Paviljon
    {
        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        private List<ISoba> sobe;

        public List<ISoba> Sobe
        {
            get { return sobe; }
            set { sobe = value; }
        }

        private int kapacitet;

        public int Kapacitet
        {
            get { return kapacitet; }
            set { kapacitet = value; }
        }

        private int brojStudenata;

        public int BrojStudenata
        {
            get { return brojStudenata; }
            set { brojStudenata = value; }
        }

        public Paviljon(string naziv, List<ISoba> sobe, int kapacitet, int brojStudenata)
        {
            Naziv = naziv;
            Sobe = sobe;
            Kapacitet = kapacitet;
            BrojStudenata = brojStudenata;
        }

        public bool DaLiImaMjesta()
        {
            return brojStudenata < kapacitet;
        }

        public int BrojSlobodnihMjesta()
        {
            return kapacitet - brojStudenata;
        }
    }
}
