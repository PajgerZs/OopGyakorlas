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
            // 6. Feladat: Hallgató példányosítása és öröklött tagok elérése
            Console.WriteLine("--- 6. Feladat: Hallgató tesztelése ---");
            Hallgato hallgato = new Hallgato("Nagy Anna", 21, "ABC123");

            // Az örökölt tulajdonságok (Nev, Kor) és a saját adattag (neptunKod) kiírása
            Console.WriteLine($"Név: {hallgato.Nev}, Kor: {hallgato.Kor}, Neptun-kód: {hallgato.neptunKod}");
        }
    }
}
