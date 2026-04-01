using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reizen
{
    public class JaarboekReizen
    {
        private int _jaar;
        private List<Reis> _reizen;

        public JaarboekReizen(int jaar)
        {
            _jaar = jaar;
            _reizen = new List<Reis>();
        }

        public int Jaar
        {
            get { return _jaar; }
        }
        public List<Reis> Reizen
        {
            get { return _reizen; }
        }
        public void VoegReisToe(Reis reis)
        {
            _reizen.Add(reis);
        }
        public int GeefAantalReizen()
        {
            return _reizen.Count;
        }
        public Reis GeefReis (int number)
        {
            if (number >= 0 && number < _reizen.Count)
            {
                return _reizen[number];
            }
            else { return null; }
        }
        public decimal TotaleKostprijs()
        {
            decimal totaal = 0;
            foreach (Reis reis in _reizen)
            {
                totaal += reis.Kostprijs;
            }
            return totaal;
        }
        public int aantalDagenInLand(String land)
        {
            int totaalDagen = 0;
            foreach (Reis reis in _reizen)
            {
                if (reis.Land == land)
                {
                    totaalDagen += reis.AantalDagen;
                }
            }
            return totaalDagen;
        }
        public void VerwijderReis(int number)
        {
            if (number >= 0 && number < _reizen.Count)
            {
                _reizen.RemoveAt(number);
            }
        }
        public void VerwijderReis2(Reis reis)
        {
            _reizen.Remove(reis);
        }
        public void WisReizenLand(String land)
        {
            for (int i = _reizen.Count - 1; i >= 0; i--)
            {
                if (_reizen[i].Land == land)
                {
                    _reizen.RemoveAt(i);
                }
            }
        }
    }
}
