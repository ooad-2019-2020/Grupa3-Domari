using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class StavkaNarudzbe
    {
        private string namirnica;

        public string Namirnica
        {
            get { return namirnica; }
            set { namirnica = value; }
        }

        private double kolicina;

        public double Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }

        public StavkaNarudzbe(string namirnica, double kolicina)
        {
            Namirnica = namirnica;
            Kolicina = kolicina;
        }
    }
}
