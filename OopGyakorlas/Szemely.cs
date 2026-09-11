using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGyakorlas
{
    public class Szemely
    {
        protected string Nev;
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

        public override string ToString()
        {
            return $"Személy -> Név: {Nev}, Életkor: {Kor} év";
        }

        // 10. Feladat: Virtuális metódus a polimorfizmushoz
        public virtual void Bemutatkozas()
        {
            Console.WriteLine($"Személy vagyok, a nevem: {Nev}.");
        }
    }
}