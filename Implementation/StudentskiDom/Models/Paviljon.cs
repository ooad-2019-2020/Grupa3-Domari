using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Paviljon
    {
        public int PaviljonId { get; set; }
        public string Naziv { get; set; }
        //public List<ISoba> Sobe { get; set; }
        public int Kapacitet { get; set; }
        public int BrojStudenata { get; set; }

        // Veze sa ostalim klasama
        public virtual ZahtjevZaCimeraj ZahtjevZaCimeraj { get; set; }
        public virtual ZahtjevZaPremjestanje ZahtjevZaPremjestanje { get; set; }
        public virtual ICollection<Soba> Sobe { get; set; }

        public Paviljon(string naziv, List<ISoba> sobe, int kapacitet, int brojStudenata)
        {
            Naziv = naziv;
            Sobe = sobe;
            Kapacitet = kapacitet;
            BrojStudenata = brojStudenata;
        }

        public bool DaLiImaMjesta()
        {
            return BrojStudenata < Kapacitet;
        }

        public int BrojSlobodnihMjesta()
        {
            return Kapacitet - BrojStudenata;
        }
    }
}
