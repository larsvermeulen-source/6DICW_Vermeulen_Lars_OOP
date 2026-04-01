using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailBar
{
    internal class Ingredient
    {
        private String _naam;
        private int _hoeveelheid;
        private double _alcoholpercentage;

        public Ingredient(String naam, int hoeveelheid, double alcoholpercentage)
        {
            _naam = naam;
            _hoeveelheid = hoeveelheid;
            _alcoholpercentage = alcoholpercentage;
        }
        public String Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public int Hoeveelheid
        {
            get { return _hoeveelheid; }
            set { _hoeveelheid = value; }
        }
        public double Alcoholpercentage
        {
            get { return _alcoholpercentage; }
            set { _alcoholpercentage = value; }
        }
        public bool IsAlcoholisch()
        {
            return _alcoholpercentage > 0;
        }
    }
}
