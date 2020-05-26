using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class StudentskiDomSingleton : IStudentskiDom
    {
        private List<Student> studenti;
        private Uprava uprava;
        private Restoran restoran;
        private List<Zahtjev> zahtjevi;
        private List<Paviljon> paviljoni;
        private IRaspored strategy;
        private static StudentskiDomSingleton instance;

        public List<Student> Studenti { get { return studenti; } set { studenti = value; } }
        public List<Zahtjev> Zahtjevi { get { return zahtjevi; } set { zahtjevi = value; } }
        public List<Paviljon> Paviljoni { get { return paviljoni; } set { paviljoni = value; } }
        public Uprava Uprava { get { return uprava; } set { uprava = value; } }
        public Restoran Restoran { get { return restoran; } set { restoran = value; } }
        public IRaspored Strategy { get { return strategy; } set { strategy = value; } }
        public void DodajZahtjev(Zahtjev zahtjev)
        {
            zahtjevi.Add(zahtjev);
        }
        public bool DaLiImaMjesta()
        {
            return true;
        }
        public Student NadjiStudentaPoIDu(int id)
        {
            return null;
        }
        
        private StudentskiDomSingleton()
        {

        }

        public static StudentskiDomSingleton getInstance()
        {
            return instance;
        }

        public void PostaviStrategiju(IRaspored strategy)
        {

        }

        public List<Student> FiltrirajPoKantonu(List<Student> studenti, string kanton)
        {
            return studenti;
        }

        public List<Student> SortirajPoGodiniStudija(List<Student> studenti, bool desc)
        {
            return studenti;
        }

        public void UpisiStudenta(Student student)
        {
            throw new NotImplementedException();
        }

        public void BrisiStudenta(Student student)
        {
            throw new NotImplementedException();
        }

        public void ObradiZahtjev(Zahtjev zahtjev)
        {
            throw new NotImplementedException();
        }
    }
}
