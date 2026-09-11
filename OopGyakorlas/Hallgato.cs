using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGyakorlas
{
    public class Hallgato : Szemely
    {
        private string neptunKod;

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

        public new string Nev => base.Nev;

        public Hallgato(string nev, int kor, string neptunKod) : base(nev, kor)
        {
            NeptunKod = neptunKod;
        }

        public void HallgatoInfo()
        {
            Console.WriteLine($"[Hallgató adatai] Név: {Nev}, Életkor: {Kor}, Neptun-kód: {NeptunKod}");
        }

        // 10. Feladat: Eltérő viselkedés a hallgató esetén
        public override void Bemutatkozas()
        {
            Console.WriteLine($"Hallgató vagyok. Név: {Nev}, Életkor: {Kor}, Neptun-kód: {NeptunKod}.");
        }
    }
}