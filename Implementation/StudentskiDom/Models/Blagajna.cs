using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Blagajna : AzurirajStanjeBonova
    {
        private double stanjeBudgeta;
        private IStudent trenutniStudent;

        public double StanjeBudgeta { get { return stanjeBudgeta; } set { stanjeBudgeta = value; } }
        public IStudent TrenutniStudent { get { return trenutniStudent; } set { trenutniStudent = value; } }

        public Blagajna()
        {
            UcitajStanjeBudzeta();
        }

        private bool ProvjeriId(int id)
        {
            return true;
        }

        public void UplatiDomZaOdabraniMjesec()
        {

        }

        private void UcitajStanjeBudzeta()
        {

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
