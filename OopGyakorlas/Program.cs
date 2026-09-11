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
            Console.WriteLine("--- 8. Feladat: Neptun-kód validáció tesztelése ---");
            Hallgato h1 = new Hallgato("Nagy Anna", 21, "ABC123");
            h1.HallgatoInfo();

            // Teszt: Próbáljunk beállítani 6 karakternél hosszabbat
            Console.WriteLine("\nKísérlet 6 karakternél hosszabb kód beállítására:");
            h1.NeptunKod = "TULHOSSZUKOD"; // Hibaüzenetet kell dobnia

            // Ellenőrzés: Az eredeti kód marad érvényben
            h1.HallgatoInfo();
        }
    }
}