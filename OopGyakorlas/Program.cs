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
            Console.WriteLine("--- 9. Feladat: Hallgatók listája ---");

            // Lista létrehozása és feltöltése több Hallgato példánnyal
            List<Hallgato> hallgatok = new List<Hallgato>()
            {
                new Hallgato("Kovács Péter", 20, "KOV123"),
                new Hallgato("Nagy Anna", 21, "NAG456"),
                new Hallgato("Tóth Balázs", 22, "TOT789")
            };

            // Végigiterálunk a listán és kiírjuk a hallgatók nevét
            foreach (Hallgato hallgato in hallgatok)
            {
                Console.WriteLine($"Hallgató neve: {hallgato.Nev}");
            }
        }
    }
}