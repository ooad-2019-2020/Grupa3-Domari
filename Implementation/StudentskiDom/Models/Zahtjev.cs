using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Zahtjev
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime datum;
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        private bool odobren;
        public bool Odobren
        {
            get { return odobren; }
            set { odobren = value; }
        }

        public Zahtjev(DateTime datum)
        {
            Datum = datum;
            Odobren = false;
        }

        public void PosaljiZahtjev() 
        {
            throw new NotImplementedException();
        }
    }
}
