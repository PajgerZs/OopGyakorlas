using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGyakorlas
{
    // A kettőspont jelzi az öröklődést: a Hallgato az ősosztály (Szemely) gyermeke
    public class Hallgato : Szemely
    {
        // 6. Feladat: Saját adattag
        public string neptunKod;

        // A konstruktor a 'base' kulcsszóval hívja meg az ősosztály (Szemely) konstruktorát
        public Hallgato(string nev, int kor, string neptunKod) : base(nev, kor)
        {
            this.neptunKod = neptunKod;
        }
    }
}
