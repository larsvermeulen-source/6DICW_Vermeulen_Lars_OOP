using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Karakter
    {
        private String _naam;
        private int _sterkte;

        public Karakter(String naam, int sterkte)
        {
            _naam = naam;
            _sterkte = sterkte;
        }
        public String Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public int Sterkte
        {
            get { return _sterkte; }
            set { _sterkte = value; }
        }
        public override string ToString()
        {
            //
        }
    }
}
