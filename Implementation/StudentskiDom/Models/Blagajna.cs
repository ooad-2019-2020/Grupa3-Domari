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
        public Student TrenutniStudentD { get; set; }
        // Baza
        public int UpravaId { get; set; }

        // Veze sa ostalim klasama
        public virtual Uprava Uprava { get; set; }

        public Blagajna()
        {
            //UcitajStanjeBudzeta();
        }

        public async Task<bool> ProvjeriIdAsync(int id)
        {
            if (TrenutniStudentD == null || TrenutniStudentD.Id != id)
            {
                Student student = await StudentskiDomSingleton.getInstance().NadjiStudentaPoIDu(id);

                if (student == null)
                    return false;
                else
                    TrenutniStudentD = student;
            }
            return true;
        }

        public void UplatiDomZaOdabraniMjesec(Mjesec mjesec)
        {
            TrenutniStudentD.uplatiDom(mjesec);
            AzurirajStanjeRucakaAsync(TrenutniStudentD.Id);
            AzurirajStanjeVeceraAsync(TrenutniStudentD.Id);
            StudentskiDomSingleton.Context.Student.Update(TrenutniStudentD);
            StudentskiDomSingleton.Context.SaveChanges();
        }

        private void UcitajStanjeBudzeta()
        {
            throw new NotImplementedException();
        }

        public void AzurirajStanjeRucakaAsync(int id)
        {
            TrenutniStudentD.BrojRucaka += 25;
        }

        public void AzurirajStanjeVeceraAsync(int id)
        {
            TrenutniStudentD.BrojVecera += 25;
        }
    }
}
