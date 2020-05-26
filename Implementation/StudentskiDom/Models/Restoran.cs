using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Restoran : Korisnik, AzurirajMeni, AzurirajStanjeBonova, PregledStanjaBonova
    {
        public int RestoranId { get; set; }
        //public DnevniMeni DnevniMeni { get; set; }
        //public int IdTrenutnogStudenta { get; set; }

        // Baza
        public int DnevniMeniId { get; set; }
        public int StudentId { get; set; }

        // Veze sa ostalim klasama
        public virtual Student Student { get; set; }
        public virtual DnevniMeni Meni { get; set; }
        public virtual Korisnik Korisnik { get; set; }

        public void AzurirajDnevniMeni(List<string> listRucaka, List<string> listVecera)
        {
            throw new NotImplementedException();
        }

        public Restoran()
        {
            //IdTrenutnogStudenta = -1;
            // Treba postaviti useranme i password za Restoran
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
