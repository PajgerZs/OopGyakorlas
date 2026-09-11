using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGyakorlas
{
    public class Hallgato : Szemely
    {
        // 8. Feladat: Privát háttérmező
        private string neptunKod;

        // 8. Feladat: NeptunKod property ellenőrzéssel (max. 6 karakter)
        public string NeptunKod
        {
            get { return neptunKod; }
            set
            {
                if (value != null && value.Length <= 6)
                {
                    neptunKod = value;
                }
                else
                {
                    Console.WriteLine("Hiba: A Neptun-kód legfeljebb 6 karakter hosszú lehet!");
                }
            }
        }

        public Hallgato(string nev, int kor, string neptunKod) : base(nev, kor)
        {
            // A property-t állítjuk be, hogy lefusson a 6 karakteres ellenőrzés
            NeptunKod = neptunKod;
        }

        public void HallgatoInfo()
        {
            Console.WriteLine($"[Hallgató adatai] Név: {Nev}, Életkor: {Kor}, Neptun-kód: {NeptunKod}");
        }
    }
}