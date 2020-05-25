using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class ZahtjevZaPremjestanje : ZahtjevStudenta
    {
        private Paviljon trenutniPaviljon;

        public Paviljon TrenutniPaviljon
        {
            get { return trenutniPaviljon; }
            set { trenutniPaviljon = value; }
        }

        private Soba trenutnaSoba;

        public Soba TrenutnaSoba
        {
            get { return trenutnaSoba; }
            set { trenutnaSoba = value; }
        }

        private Paviljon noviPaviljon;

        public Paviljon NoviPaviljon
        {
            get { return noviPaviljon; }
            set { noviPaviljon = value; }
        }

        private Soba novaSoba;

        public Soba NovaSoba
        {
            get { return novaSoba; }
            set { novaSoba = value; }
        }

        private string razlogPremjestanja;

        public string RazlogPremjestanja
        {
            get { return razlogPremjestanja; }
            set { razlogPremjestanja = value; }
        }

        public ZahtjevZaPremjestanje(Paviljon trenutniPaviljon, Soba trenutnaSoba, Paviljon noviPaviljon, Soba novaSoba, 
            string razlogPremjestanja, Korisnik podnosilacZahtjeva, DateTime datum) : base((Student)podnosilacZahtjeva, datum)
        {
            TrenutniPaviljon = trenutniPaviljon;
            TrenutnaSoba = trenutnaSoba;
            NoviPaviljon = noviPaviljon;
            NovaSoba = novaSoba;
            RazlogPremjestanja = razlogPremjestanja;
        }
    }
}
