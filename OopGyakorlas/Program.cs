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
            // 3. Feladat: Példányosítás és a Kor property tesztelése
            Szemely sz1 = new Szemely("Kovács Péter", 20);
            Console.WriteLine($"Név: {sz1.Nev}, Kor: {sz1.Kor}");

            // Próbáljuk meg negatív értékre állítani:
            sz1.Kor = -5; // Kiírja a hibaüzenetet, és nem módosul
            Console.WriteLine($"Módosítási kísérlet utáni kor: {sz1.Kor}");
        }
    }
}
