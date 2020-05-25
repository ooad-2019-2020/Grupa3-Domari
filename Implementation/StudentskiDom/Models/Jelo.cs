using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Jelo
    {
        public int JeloId { get; set; }
        public string Naziv { get; set; }
        // Baza
        public int DnevniMeniId { get; set; }

        // Veze sa ostalim klasama
        public virtual DnevniMeni DnevniMeni { get; set; }

        public Jelo(int jeloId, string naziv)
        {
            JeloId = jeloId;
            Naziv = naziv;
        }

    }
}
