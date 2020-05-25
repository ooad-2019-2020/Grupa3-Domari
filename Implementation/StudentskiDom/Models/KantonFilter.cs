using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class KantonFilter : Algoritam
    {
        public string Kanton { get; set; }

        public KantonFilter(string kanton)
        {
            this.Kanton = kanton;
        }

        public override List<Student> Filtriraj(List<Student> studenti)
        {
            //implementovati
            return studenti;
        }
    }
}
