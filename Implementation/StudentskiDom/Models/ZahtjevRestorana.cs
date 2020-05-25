using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class ZahtjevRestorana : Zahtjev
    {
        public int ZahtjevRestoranaId { get; set; }
        //public Restoran PodnosilacZahtjeva { get; set; }
        
        // Baza
        public int RestoranId { get; set; }

        // Veze sa ostlalim klasama
        public virtual Restoran Restoran { get; set; }
        public virtual ZahtjevZaNabavkuNamirnica ZahtjevZaNabavkuNamirnica { get; set; }
        public virtual Zahtjev Zahtjev { get; set; }

        public ZahtjevRestorana(Restoran podnosilacZahtjeva, DateTime datum) : base(datum)
        {
            PodnosilacZahtjeva = podnosilacZahtjeva;
        }
    }
}
