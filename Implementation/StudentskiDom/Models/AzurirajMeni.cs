using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public interface AzurirajMeni
    {
        void DodajRucak(string rucak);
        void DodajVeceru(string vecera);
        void IzbaciRucak(string rucak);
        void IzbaciVeceru(string vecera);
    }
}
