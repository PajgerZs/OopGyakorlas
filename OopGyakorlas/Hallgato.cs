using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGyakorlas
{
    public class Hallgato : Szemely
    {
        public string neptunKod;

        public Hallgato(string nev, int kor, string neptunKod) : base(nev, kor)
        {
            this.neptunKod = neptunKod;
        }

        // 7. Feladat: A védett 'Nev' mező közvetlen elérése a leszármazott osztályban
        public void HallgatoInfo()
        {
            Console.WriteLine($"[Hallgató adatai] Név: {Nev}, Életkor: {Kor}, Neptun-kód: {neptunKod}");
        }
    }
}