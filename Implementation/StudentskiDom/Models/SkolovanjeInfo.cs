using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class SkolovanjeInfo
    {
        private string fakultet;

        public string Fakultet
        {
            get { return fakultet; }
            set { fakultet = value; }
        }

        private int brojIndeksa;

        public int BrojIndeksa
        {
            get { return brojIndeksa; }
            set { brojIndeksa = value; }
        }

        private int ciklusStudija;

        public int CiklusStudija
        {
            get { return ciklusStudija; }
            set { ciklusStudija = value; }
        }

        private int godinaStudija;

        public int GodinaStudija
        {
            get { return godinaStudija; }
            set { godinaStudija = value; }
        }

        public SkolovanjeInfo(string fakultet, int brojIndeksa, int ciklusStudija, int godinaStudija)
        {
            Fakultet = fakultet;
            BrojIndeksa = brojIndeksa;
            CiklusStudija = ciklusStudija;
            GodinaStudija = godinaStudija;
        }
    }
}
