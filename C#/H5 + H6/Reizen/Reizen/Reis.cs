using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reizen
{
    public class Reis
    {
        private String _land;
        private int _aantalDagen;
        private decimal _kostprijs;
        
        public Reis(String land, int aantalDagen, decimal kostprijs)
        {
            _land = land;
            _aantalDagen = aantalDagen;
            _kostprijs = kostprijs;
        }
   
        public String Land
        {
            get { return _land; }
            set { _land = value; }
        }

        public int AantalDagen
        {
            get { return _aantalDagen; }
            set { _aantalDagen = value; }
        }

        public decimal Kostprijs
        {
            get { return _kostprijs; }
            set { _kostprijs = value; }
        }

        public String Omschrijving()
        {
            String uitvoer = "";
            
            if (_aantalDagen == 1)
            {
                uitvoer = "1 dag naar " + _land + " voor " + _kostprijs.ToString("C") + ".";
            }
            else 
            {
                uitvoer = _aantalDagen.ToString() + " dagen naar " + _land + " voor " + _kostprijs.ToString("C") + ".";
            }

            return uitvoer;
        }
        
    }
}
