using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Restoran : AzurirajMeni, AzurirajStanjeBonova, PregledStanjaBonova
    {
        private DnevniMeni dnevniMeni;
        private int idTrenutnogStudenta;

        public DnevniMeni DnevniMeni { get { return dnevniMeni; } set { dnevniMeni = value; } }

        public int IdTrenutnogStudenta { get { return idTrenutnogStudenta; } set { idTrenutnogStudenta = value; } }

        public void AzurirajDnevniMeni(List<string> listRucaka, List<string> listVecera)
        {

        }

        public Restoran()
        {

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

        public void AzurirajStanjeRucaka(int id)
        {
            throw new NotImplementedException();
        }

        public void AzurirajStanjeVecera(int id)
        {
            throw new NotImplementedException();
        }

        public int DajBrojRucakaZaStudenta(int id)
        {
            throw new NotImplementedException();
        }

        public int DajBrojVeceraZaStudenta(int id)
        {
            throw new NotImplementedException();
        }
    }
}
