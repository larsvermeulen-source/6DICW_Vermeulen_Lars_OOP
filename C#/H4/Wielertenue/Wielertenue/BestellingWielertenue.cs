using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wielertenue
{
    class BestellingWielertenue
    {
        private int _aantal;  // hoeveel stuks bestel je
        private bool _waterdichtZakje;  // is er in het truitje een waterdicht GSM-opbergzakje voorzien
        private bool _broek;  // neem je ook de wielerbroek (of anders enkel het wielertruitje)
        private bool _superZeem; // is de wielerbroek voorzien van een zeem met hogere kwaliteit

        public BestellingWielertenue(int aantal, bool waterdichtZakje, bool broek, bool superZeem)
        {
            _aantal = aantal;
            _waterdichtZakje = waterdichtZakje;
            _broek = broek;
            _superZeem = superZeem;
        }
        public int aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }
        public bool waterdichtZakje
        {
            get { return _waterdichtZakje; }
            set { _waterdichtZakje = value; }
        }
        public bool broek
        {
            get { return broek; }
            set { _broek = value; }
        }
        public bool superZeem
        {
            get { return _superZeem; }
            set { _superZeem = value; }
        }
        public decimal GeefPrijs()
        {
            double som = 0;
            som += 45.00;
            if (_waterdichtZakje)
            {
                som += 3.50;
            }
            if (_broek)
            {
                som += 80.00;
                if (_superZeem)
                {
                    som += 5.50;
                }
            }
            if (_aantal > 5) //korting
            {
                som += -(som * 10 / 100);
            }
            return (decimal)(aantal*som);
        }
    }
}
