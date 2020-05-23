using StudentskiDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Controllers
{
    public class ZahtjevZaUpis : Zahtjev
    {
        private LicniPodaci licniPodaci;

        public LicniPodaci LicniPodaci
        {
            get { return licniPodaci; }
            set { licniPodaci = value; }
        }

        private PrebivalisteInfo prebivaliste;

        public PrebivalisteInfo Prebivaliste
        {
            get { return prebivaliste; }
            set { prebivaliste = value; }
        }

        private SkolovanjeInfo skolovanje;

        public SkolovanjeInfo Skolovanje
        {
            get { return skolovanje; }
            set { skolovanje = value; }
        }

        public ZahtjevZaUpis(LicniPodaci licniPodaci, PrebivalisteInfo prebivaliste, SkolovanjeInfo skolovanje, DateTime datum)
            : base(datum)
        {
            LicniPodaci = licniPodaci;
            Prebivaliste = prebivaliste;
            Skolovanje = skolovanje;
        }
    }
}
