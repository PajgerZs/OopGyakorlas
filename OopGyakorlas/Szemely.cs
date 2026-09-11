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

        // 3. Feladat: Privát háttérmező (backing field)
        private int eletkor;

        // 3. Feladat: Kor property ellenőrzéssel
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

        // A konstruktorban érdemes a Kor property-t beállítani, 
        // így a kezdeti értékadáskor is lefut az ellenőrzés
        public Szemely(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }
    }
}