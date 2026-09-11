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
        public int Eletkor;

        // 2. Feladat: Konstruktor a név és az életkor beállítására
        public Szemely(string nev, int eletkor)
        {
            Nev = nev;
            Eletkor = eletkor;
        }
    }
}