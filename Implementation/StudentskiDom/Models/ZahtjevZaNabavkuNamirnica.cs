using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class ZahtjevZaNabavkuNamirnica : ZahtjevRestorana
    {
        private List<string> listNamirnica;

        public List<string> ListNamirnica
        {
            get { return listNamirnica; }
            set { listNamirnica = value; }
        }

        private List<StavkaNarudzbe> narudzba;

        public List<StavkaNarudzbe> Narudzba
        {
            get { return narudzba; }
            set { narudzba = value; }
        }

        public ZahtjevZaNabavkuNamirnica(List<string> listNamirnica, List<StavkaNarudzbe> narudzba, 
            Korisnik podnosilacZahtjeva, DateTime datum) : base((Restoran) podnosilacZahtjeva, datum)
        {
            ListNamirnica = listNamirnica;
            Narudzba = narudzba;
        }
    }
}
