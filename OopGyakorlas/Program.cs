using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace OopGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 10. Feladat: Polimorfizmus tesztelése ---");

            // Az ősosztály (Szemely) típusú listába mindkét leszármazott elhelyezhető:
            List<Szemely> resztvevok = new List<Szemely>()
            {
                new Hallgato("Kovács Péter", 20, "KOV123"),
                new Dolgozo("Szabó István", 42, 550000),
                new Hallgato("Nagy Anna", 21, "NAG456"),
                new Dolgozo("Kiss Eszter", 35, 620000)
            };

            // Ugyanazt a metódust hívjuk meg minden elemen, mégis eltérően viselkednek:
            foreach (Szemely szemely in resztvevok)
            {
                szemely.Bemutatkozas();
            }
        }
    }
}