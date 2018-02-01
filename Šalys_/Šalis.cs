using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Šalys_
{
    class Šalis
    {
        public string Pavadinimas { get; set; }
        public string Žemynas { get; private set; }
        public List<Miestas> Miestai { get; private set; }

        public Šalis(string failas)
        {
            var tekstas= File.ReadAllLines(failas);

            Pavadinimas = tekstas[0];
            Žemynas = tekstas[1];
            for (int i = 2; i < tekstas.Length; i++)
            {
                var Miestas = new Miestas(tekstas[i]);
                Miestai.Add(Miestas);
            }
        }
    }
}
