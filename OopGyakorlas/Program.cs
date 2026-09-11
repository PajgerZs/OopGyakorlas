using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 7. Feladat: Protected adattag tesztelése ---");
            Hallgato h1 = new Hallgato("Nagy Anna", 21, "ABC123");

            // A hallgato.Nev közvetlen elérése itt most fordítási hibát adna (mert protected),
            // de a Hallgato osztály belső metódusa gond nélkül eléri:
            h1.HallgatoInfo();
        }
    }
}
