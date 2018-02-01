using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Šalys_
{
    class Pasaulis
    {

        public List<Šalis> Šalys { get; } = new List<Šalis>();

        public Miestas DaugiausiaiGyventoju()
        {
            var gyv = Šalys.First().Miestai.First();

            foreach (var šalis in Šalys)
            {
                foreach (var miestas in šalis.Miestai)
                {
                    if (miestas.Gyventoju_Skaicius>gyv.Gyventoju_Skaicius)
                    {
                        gyv = miestas;
                    }
                }
            }
            return gyv;
        }

    }
}
