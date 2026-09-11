using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGyakorlas
{
    public class Dolgozo : Szemely
    {
        // 10. Feladat: Ber adattag
        public int Ber;

        public Dolgozo(string nev, int kor, int ber) : base(nev, kor)
        {
            Ber = ber;
        }

        // 10. Feladat: Eltérő viselkedés a dolgozó esetén
        public override void Bemutatkozas()
        {
            Console.WriteLine($"Dolgozó vagyok. Név: {Nev}, Életkor: {Kor}, Havi bér: {Ber} Ft.");
        }
    }
}
