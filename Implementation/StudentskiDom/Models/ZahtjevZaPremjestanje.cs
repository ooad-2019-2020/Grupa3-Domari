using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class ZahtjevZaPremjestanje : ZahtjevStudenta
    {
        public int ZahtjevZaPremjestanjeId { get; set; }
        public Paviljon TrenutniPaviljon { get; set; }
        public Soba TrenutnaSoba { get; set; }
        public Paviljon NoviPaviljon { get; set; }
        public Soba NovaSoba { get; set; }
        public string RazlogPremjestanja { get; set; }

        // Veze sa ostalim klasama
        public virtual Soba Soba1 { get; set; }
        public virtual Soba Soba2 { get; set; }
        public virtual Paviljon Paviljon { get; set; }
        public virtual ZahtjevStudenta ZahtjevStudenta { get; set; }

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
