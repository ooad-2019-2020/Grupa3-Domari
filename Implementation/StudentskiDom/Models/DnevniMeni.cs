using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class DnevniMeni:AzurirajMeni
    {
        private List<string> listaRucaka;
        private List<string> listaVecera;

        public List<string> ListaRucaka { get { return listaRucaka; } set { listaRucaka = value; } }
        public List<string> ListaVecera { get { return listaVecera; } set { listaVecera = value; } }

        public DnevniMeni()
        {
        }

        public DnevniMeni(List<string> listaRucaka, List<string> listaVecera)
        {
            this.listaRucaka = listaRucaka;
            this.listaVecera = listaVecera;
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
