using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Showroom
{
    public class PartnerTepee
    {
        private bool _autoradio;
        private bool _airco;
        private bool _klapdeurenAchteraan;
        private bool _schuifdeurLinks;
        private bool _cruiseControl;

        public PartnerTepee()
        {
            _autoradio = false;
            _airco = false;
            _klapdeurenAchteraan = false;
            _schuifdeurLinks = false;
            _cruiseControl = false;
        }

        public bool Autoradio
        {
            get { return _autoradio; }
            set { _autoradio = value; }
        }

        public bool Airco
        {
            get { return _airco; }
            set { _airco = value; }
        }

        public bool KlapdeurenAchteraan
        {
            get { return _klapdeurenAchteraan; }
            set { _klapdeurenAchteraan = value; }
        }

        public bool SchuifdeurLinks
        {
            get { return _schuifdeurLinks; }
            set { _schuifdeurLinks = value; }
        }

        public bool CruiseControl
        {
            get { return _cruiseControl; }
            set { _cruiseControl = value; }
        }

        public double GeefPrijs()
        {
            //basisprijs zonder opties is 13904
            double prijs = 13904;
 
            if (_autoradio == true)
            {
                prijs += 450;
            }

            if (_airco == true)
            {
                prijs += 1280;
            }

            if (_klapdeurenAchteraan == true)
            {
                prijs += 150;
            }

            if (_schuifdeurLinks == true)
            {
                prijs += 480;
            }

            if (_cruiseControl == true)
            {
                prijs += 250;
            } 

            return prijs;
        }
    }
}
