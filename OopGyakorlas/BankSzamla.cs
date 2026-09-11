using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGyakorlas
{
    public class BankSzamla
    {
        // 5. Feladat: Privát adattag (az egységbezárás alapja)
        private double egyenleg;

        // Csak olvasható property, hogy kívülről le lehessen kérdezni az egyenleget
        public double Egyenleg
        {
            get { return egyenleg; }
        }

        // Konstruktor (alapértelmezetten 0 kezdőegyenleggel)
        public BankSzamla(double kezdoEgyenleg = 0)
        {
            if (kezdoEgyenleg >= 0)
            {
                egyenleg = kezdoEgyenleg;
            }
            else
            {
                Console.WriteLine("A kezdő egyenleg nem lehet negatív! 0 Ft-tal jön létre.");
                egyenleg = 0;
            }
        }

        // Betesz metódus: csak pozitív összeget engedünk hozzáadni
        public void Betesz(double osszeg)
        {
            if (osszeg > 0)
            {
                egyenleg += osszeg;
                Console.WriteLine($"{osszeg} Ft sikeresen befizetve. Új egyenleg: {egyenleg} Ft");
            }
            else
            {
                Console.WriteLine("Hiba: Csak pozitív összeget lehet befizetni!");
            }
        }

        // Kivesz metódus: nem engedi, hogy az egyenleg negatívba menjen
        public void Kivesz(double osszeg)
        {
            if (osszeg <= 0)
            {
                Console.WriteLine("Hiba: Csak pozitív összeget lehet felvenni!");
            }
            else if (osszeg > egyenleg)
            {
                Console.WriteLine($"Hiba: Nincs elegendő fedezet a kivételhez! Jelenlegi egyenleg: {egyenleg} Ft (nem lehet negatív)");
            }
            else
            {
                egyenleg -= osszeg;
                Console.WriteLine($"{osszeg} Ft sikeresen felvéve. Új egyenleg: {egyenleg} Ft");
            }
        }
    }
}