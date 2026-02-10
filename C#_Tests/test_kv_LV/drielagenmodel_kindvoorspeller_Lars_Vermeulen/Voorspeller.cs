using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drielagenmodel_kindvoorspeller_Lars_Vermeulen
{
    internal class Voorspeller
    {
        private double _LengteVrouw;
        private double _LengteMan;
        private int _AantalVoorspellingen;
        public Voorspeller()
            {
                _LengteVrouw = 0;
                _LengteMan = 0;
                _AantalVoorspellingen = 0;
            }
        public void add(double lengte1, double lengte2)
            {
                _LengteVrouw = 0;
                _LengteMan = 0;
                
                // Zorgen dat de lengte niet steeds groter wordt
                if (lengte1 < 5) //niemand is kleiner dan 5 cm, dus zal dit bedoeld zijn als meter
                {
                    lengte1 = lengte1 * 100;
                }
                if (lengte2 < 5) //niemand is kleiner dan 5 cm, dus zal dit bedoeld zijn als meter
            {
                 lengte2 = lengte2 * 100;
                }
                _LengteVrouw += lengte1;
                _LengteMan += lengte2;
            }
        public double GemiddeldeOuders()
            {
                return ( _LengteMan + _LengteVrouw) / 2;
            }
        public double BerekenDochter()
            {
                _AantalVoorspellingen++;
                return GemiddeldeOuders() - 6.5;
            }
        public double BerekenZoon()
        {
            _AantalVoorspellingen++;
            return GemiddeldeOuders() + 6.5;
        }
        public int AantalVoorspellingen
        {
            get {  return _AantalVoorspellingen;}
        }
    }
}
