using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Soba : ISoba
    {
        public int SobaId { get; set; }
        public int BrojSobe { get; set; }
        public int Kapacitet { get; set; }
        //public List<Student> Studenti { get; set; }
        public int PaviljonId { get; set; }

        // Veze sa ostalim klasama
        public virtual ICollection<Student> Students { get; set; }
        public virtual Paviljon Paviljon { get; set; }
        public virtual ZahtjevZaPremjestanje Soba1 { get; set; }
        public virtual ZahtjevZaPremjestanje Soba2 { get; set; }
        public virtual ZahtjevZaCimeraj ZahtjevZaCimeraj { get; set; }

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
            return Studenti.Count < Kapacitet;
        }

        public ISoba Clone()
        {
            throw new NotImplementedException();
        }
    }
}
