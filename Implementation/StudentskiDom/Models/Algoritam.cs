using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public abstract class Algoritam
    {
        public List<Student> TemplateMethod(List<Student> studenti) {
            return studenti;
        }

        public virtual List<Student> Sortiraj(List<Student> studenti)
        {
            return studenti;
        } 

        public virtual List<Student>  Filtriraj(List<Student> studenti)
        {
            return studenti;
        }


    }
}
