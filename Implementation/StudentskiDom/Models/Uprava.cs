using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Uprava
    {
        private Blagajna blagajna;

        public Blagajna Blagajna { get { return blagajna; } set { blagajna = value; } }

        public Uprava()
        {
        }
    }
}
