using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class GodinaStudijaSort: Algoritam
    {
        private bool desc;

        public bool Desc { get { return desc; } set { desc = value; } }


        public GodinaStudijaSort(bool desc)
        {
            this.desc = desc;
        }

        public override List<Student> Sortiraj(List<Student> studenti)
        {
            return studenti;
        }
    }
}
