using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class MonopolyStraat
    {
        private String _straat;
        private String _stad;
        private int _aantalHuizen;
        private int _aantalHotels;
        private int _huurOnbebouwd;
        private int _huur1Huis;
        private int _huur2Huizen;
        private int _huur3Huizen;
        private int _huur4Huizen;
        private int _huur1Hotel;

        public MonopolyStraat(String straat, String stad, int huurOnbebouwd, int huur1Huis, int huur2Huizen, int huur3Huizen, int huur4Huizen, int huur1Hotel)
        {
            _straat = straat;
            _stad = stad;
            _aantalHuizen = 0;
            _aantalHotels = 0;
            _huurOnbebouwd = huurOnbebouwd;
            _huur1Huis = huur1Huis;
            _huur2Huizen = huur2Huizen;
            _huur3Huizen = huur3Huizen;
            _huur4Huizen = huur4Huizen;
            _huur1Hotel = huur1Hotel;
        }

        public String Straat
        {
            get { return _straat; }
        }

        public String Stad
        {
            get { return _stad; }
        }

        public int AantalHuizen
        {
            get { return _aantalHuizen; }
        }

        public int AantalHotels
        {
            get { return _aantalHotels; }
        }

        public void KoopHuis()
        {
            if (_aantalHotels == 0 && _aantalHuizen < 4)
            {
                _aantalHuizen++;
            }
        }

        public void KoopHotel()
        {
            if (_aantalHotels == 0 && _aantalHuizen == 4)
            {
                _aantalHotels = 1;
                _aantalHuizen = 0;
            }
        }

        public int GeefHuur()
        {
            int huur = 0;

            switch (_aantalHuizen)
            {
                case 0:
                    if (_aantalHotels == 1)
                    {
                        huur = _huur1Hotel;
                    }
                    else
                    {
                        huur = _huurOnbebouwd;
                    }
                    break;
                case 1:
                    huur = _huur1Huis;
                    break;
                case 2:
                    huur = _huur2Huizen;
                    break;
                case 3:
                    huur = _huur3Huizen;
                    break;
                case 4:
                    huur = _huur4Huizen;
                    break;
            }

            return huur;
        }
    }
}
