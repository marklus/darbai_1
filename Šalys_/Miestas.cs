using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Šalys_
{
    public class Miestas
    {
        public string Pavadinimas { get; private set; }
        public int Gyventoju_Skaicius { get; private set; }
        public int Plotas_kv_km { get; private set; }

        public Miestas(string pavadinimas, int gyventoju_skaicius,int plotas_kv_km)
        {
            Pavadinimas = pavadinimas;
            Gyventoju_Skaicius = gyventoju_skaicius;
            Plotas_kv_km = plotas_kv_km;
        }


        public Miestas(string eilute)
        {
            string[] isskaidyta = eilute.Split(';');
            Pavadinimas = isskaidyta[0];
            Gyventoju_Skaicius = Convert.ToInt32(isskaidyta[1]);
            Plotas_kv_km = Convert.ToInt32(isskaidyta[2]);
        }


    }
}
