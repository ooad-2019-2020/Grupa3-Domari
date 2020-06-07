using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class RasporedFakultet : IRaspored
    {
        public Soba RasporediStudenta(Student student)
        {
            Soba slobonda = null;
            foreach (Paviljon p in StudentskiDomSingleton.getInstance().Paviljoni)
            {
                foreach (Soba s in p.Sobe)
                {
                    if (s.DaLiImaMjesta())
                    {
                        if (slobonda == null && s.Students.Count == 0)
                            slobonda = s;
                        else
                        {
                            foreach (Student st in s.Students)
                            {
                                if (st.SkolovanjeInfo.Fakultet.Equals(student.SkolovanjeInfo.Fakultet))
                                    return s;
                            }
                        }
                    }
                }
            }
            return slobonda;
        }
    }
    }
}
