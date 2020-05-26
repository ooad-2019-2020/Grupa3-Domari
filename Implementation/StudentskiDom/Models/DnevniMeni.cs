using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class DnevniMeni : AzurirajMeni
    {
        public int DnevniMeniId { get; set; }
        //public List<string> ListaRucaka { get; set; }
        //public List<string> ListaVecera { get; set; }

        // Veze sa ostalim klasama
        //public virtual Restoran Restoran { get; set; }
        public virtual ICollection<Rucak> Rucak { get; set; }
        public virtual ICollection<Vecera> Vecera { get; set; }


        public DnevniMeni()
        {
        }


        public DnevniMeni(List<string> listaRucaka, List<string> listaVecera)
        {
            //this.ListaRucaka = listaRucaka;
            //this.ListaVecera = listaVecera;
        }

        public void DodajRucak(string rucak)
        {
            throw new NotImplementedException();
        }

        public void DodajVeceru(string vecera)
        {
            throw new NotImplementedException();
        }

        public void IzbaciRucak(string rucak)
        {
            throw new NotImplementedException();
        }

        public void IzbaciVeceru(string vecera)
        {
            throw new NotImplementedException();
        }
    }
}
