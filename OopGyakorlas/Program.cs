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
            // 2. Feladat: Példányosítás konstruktor segítségével
            Szemely sz1 = new Szemely("Kovács Péter", 20);

            Console.WriteLine($"Név: {sz1.Nev}, Életkor: {sz1.Eletkor}");
        }
    }
}
