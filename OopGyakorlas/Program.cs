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
            // 5. Feladat tesztelése: BankSzamla
            Console.WriteLine("--- 5. Feladat: BankSzámla tesztelése ---");
            BankSzamla szamla = new BankSzamla(10000);

            szamla.Betesz(5000);   // Egyenleg: 15000 Ft lesz
            szamla.Kivesz(3000);   // Egyenleg: 12000 Ft lesz
            szamla.Kivesz(20000);  // Hibaüzenet, mert az egyenleg nem lehet negatív!

            Console.WriteLine($"Végső egyenleg: {szamla.Egyenleg} Ft");
        }
    }
}

