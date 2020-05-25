using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Namirnica
    {
        public int NamirnicaId { get; set; }
        public string Naziv { get; set; }

        // Baza
        public int ZahtjevZaNabavkuNamirnicaId { get; set; }

        // Veze sa ostalim klasama
        public virtual ZahtjevZaNabavkuNamirnica ZahtjevZaNabavkuNamirnica { get; set; }


        public Namirnica(int namirnicaId, string naziv)
        {
            NamirnicaId = namirnicaId;
            Naziv = naziv;
        }
    }
}
