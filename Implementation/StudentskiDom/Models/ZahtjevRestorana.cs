using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class ZahtjevRestorana : Zahtjev
    {
        private Restoran podnosilacZahtjeva;

        public Restoran PodnosilacZahtjeva
        {
            get { return podnosilacZahtjeva; }
            set { podnosilacZahtjeva = value; }
        }

        public ZahtjevRestorana(Restoran podnosilacZahtjeva, DateTime datum) : base(datum)
        {
            this.podnosilacZahtjeva = podnosilacZahtjeva;
        }
    }
}
