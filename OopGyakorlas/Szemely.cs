using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGyakorlas
{
    public class Szemely
    {
        public string Nev;
        private int eletkor;

        public int Kor
        {
            get { return eletkor; }
            set
            {
                if (value >= 0)
                {
                    eletkor = value;
                }
                else
                {
                    Console.WriteLine("Hiba: Az életkor nem lehet negatív!");
                }
            }
        }

        public Szemely(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }

        // 4. Feladat: ToString felüldefiniálása (override)
        public override string ToString()
        {
            return $"Személy -> Név: {Nev}, Életkor: {Kor} év";
        }
    }
}