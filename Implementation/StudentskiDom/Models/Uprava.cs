using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Uprava
    {
        public int UpravaId { get; set; }
        public Blagajna Blagajna { get; set; }

        // Veze sa ostalim klasama
        public virtual Korisnik Korisnik { get; set; }
        public virtual Blagajna Blagajna { get; set; }

        public Uprava()
        {
        }
    }
}
