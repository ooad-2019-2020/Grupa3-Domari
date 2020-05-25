using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Proxy
    {
        public int NivoPristupa { get; set; }
        public IStudentskiDom StudentskiDom { get; set; }
        public Korisnik Korisnik { get; set; }

        public void Pristup(Korisnik korisnik)
        {

        }

    }
}
