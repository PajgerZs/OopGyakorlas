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
            // 4. Feladat: ToString() metódus tesztelése
            Szemely sz1 = new Szemely("Kovács Péter", 20);

            // A Console.WriteLine automatikusan meghívja a ToString()-et:
            Console.WriteLine(sz1);
        }
    }
}
