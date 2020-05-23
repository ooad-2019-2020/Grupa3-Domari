using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class KantonFilter : Algoritam
    {
        private string kanton;

        public KantonFilter(string kanton)
        {
            this.kanton = kanton;
        }

        public override List<Student> Filtriraj(List<Student> studenti)
        {
            //implementovati
            return studenti;
        }
    }
}
