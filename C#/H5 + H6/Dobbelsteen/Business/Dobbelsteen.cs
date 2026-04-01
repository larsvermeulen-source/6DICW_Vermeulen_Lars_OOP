using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Dobbelsteen
    {
        private int _aantalZijden; // aantal zijden op de dobbelsteen
        private Random _getalGenerator; // om willekeurige getallen te maken
        public Dobbelsteen(int aantalZijden)
        {
            _aantalZijden = aantalZijden;
            _getalGenerator = new Random();
        }
        public int AantalZijden
        {
            get { return _aantalZijden; }
        }
        public int Werp()
        {
            // retourneer willekeurige zijde op de dobbelsteen
            return _getalGenerator.Next(_aantalZijden) + 1;
        }
    }
}
