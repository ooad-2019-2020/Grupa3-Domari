using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Blagajna : AzurirajStanjeBonova
    {
        public int BlagajnaId { get; set; }
        public double StanjeBudgeta { get; set; }
        //public IStudent TrenutniStudent { get; set; }
        // Baza
        public int UpravaId { get; set; }

        // Veze sa ostalim klasama
        public virtual Uprava Uprava { get; set; }

        public Blagajna()
        {
            //UcitajStanjeBudzeta();
        }

        private bool ProvjeriId(int id)
        {
            return true;
        }

        public void UplatiDomZaOdabraniMjesec()
        {
            throw new NotImplementedException();
        }

        private void UcitajStanjeBudzeta()
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
    }
}
