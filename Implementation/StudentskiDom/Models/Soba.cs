using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Soba : ISoba
    {
        private int brojSobe;

        public int BrojSobe
        {
            get { return brojSobe; }
            set { brojSobe = value; }
        }

        private int kapacitet;

        public int Kapacitet
        {
            get { return kapacitet; }
            set { kapacitet = value; }
        }

        private List<Student> studenti;

        public List<Student> Studenti
        {
            get { return studenti; }
            set { studenti = value; }
        }

        public Soba(int brojSobe, int kapacitet, List<Student> studenti)
        {
            BrojSobe = brojSobe;
            Kapacitet = kapacitet;
            Studenti = studenti;
        }

        public void DodajStudentaUSobu(Student student)
        {
            Studenti.Add(student);
        }

        public void IzbaciStudentaIzSobe(Student student)
        {
            Studenti.Remove(student);
        }

        public bool DaLiImaMjesta()
        {
            return Studenti.Count < kapacitet;
        }

        public ISoba Clone()
        {
            throw new NotImplementedException();
        }
    }
}
