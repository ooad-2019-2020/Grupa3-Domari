using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class PrebivalisteInfo
    {
        private string adresa;

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        private string kanton;

        public string Kanton
        {
            get { return kanton; }
            set { kanton = value; }
        }

        private string opcina;

        public string Opcina
        {
            get { return opcina; }
            set { opcina = value; }
        }

        public PrebivalisteInfo(string adresa, string kanton, string opcina)
        {
            Adresa = adresa;
            Kanton = kanton;
            Opcina = opcina;
        }
    }
}
