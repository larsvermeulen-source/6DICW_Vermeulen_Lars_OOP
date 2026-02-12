using ProjectZonderNaam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZonderNaam
{
    public class Naam
    {
        private String _voornaam;
        private String _familienaam;

        public Naam(String voornaam, String familienaam)
        {
            _voornaam = voornaam;
            _familienaam = familienaam;
        }

        public String Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public String Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value; }
        }

        public String Volledigenaam(bool formeel)
        {
            String naam;

            if (formeel == true)
            {
                naam = _familienaam + " " + _voornaam;
            }
            else
            {
                naam = _voornaam + " " + _familienaam;
            }

            return naam;
        }
        public String Initialen()
        {
            return _voornaam.Substring(1) + _familienaam.Substring(1);
        }
        public String AlfaVoornaam()
        {
            String tekst = (_voornaam).ToLower();
            tekst = tekst.Replace(" ", "");
            tekst = tekst.Replace("-", "");
            tekst = tekst.Replace("é", "e");
            tekst = tekst.Replace("è", "e");
            return tekst;
        }
        public String AlfaFamilienaam()
        {
            String tekst = (_familienaam).ToLower();
            tekst = tekst.Replace(" ", "");
            tekst = tekst.Replace("-", "");
            tekst = tekst.Replace("é", "e");
            tekst = tekst.Replace("è", "e");
            return tekst;
        }
        public String AlfaVolledigNaam()
        {
            String tekst = (_voornaam + " " + _familienaam).ToLower();
            tekst = tekst.Replace(" ", "");
            tekst = tekst.Replace("-", "");
            tekst = tekst.Replace("é", "e");
            tekst = tekst.Replace("è", "e");
            return tekst;
        }
    }
}
