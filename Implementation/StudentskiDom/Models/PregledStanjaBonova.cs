using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public interface PregledStanjaBonova
    {
        int DajBrojRucakaZaStudenta(int id);
        int DajBrojVeceraZaStudenta(int id);
    }
}
