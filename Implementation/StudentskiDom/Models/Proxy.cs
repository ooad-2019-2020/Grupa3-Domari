using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Proxy
    {
        private int nivoPristupa;
        private IStudentskiDom studentskiDom;
        private Korisnik korisnik;

        public int NivoPristupa { get { return nivoPristupa; } set { nivoPristupa = value; } }
        public IStudentskiDom StudentskiDom { get { return studentskiDom; } set { studentskiDom = value; } }
        public Korisnik Korisnik { get { return korisnik; } set { korisnik = value; } }

        public void Pristup(Korisnik korisnik)
        {

        }

    }
}
