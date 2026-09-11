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
            // 1. Feladat: Példányosítás és kiírás
            Szemely sz1 = new Szemely();
            sz1.Nev = "Kovács Péter";
            sz1.Eletkor = 20;

            Console.WriteLine($"Név: {sz1.Nev}, Életkor: {sz1.Eletkor}");
        }
    }
}
