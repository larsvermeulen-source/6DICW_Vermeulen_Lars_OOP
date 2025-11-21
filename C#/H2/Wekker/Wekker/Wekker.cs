using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wekker
{
    public class Wekker
    {
        private int _uur;
        private int _minuut;

        public Wekker()
        {
            _uur = 0;
            _minuut = 0;
        }

        public int GetUur()
        {
            return _uur;
        }
        
        public int GetMinuut()
        {
            return _minuut;
        }

        public void SetUur(int uur)
        {
            this._uur = uur;
        }

        public void SetMinuut(int minuut)
        {
            this._minuut = minuut;
        }

        public void UrenPlus()
        {
            _uur++;
            if (_uur > 23)
            {
                _uur = _uur - 24;
            }
        }

        public void UrenMin()
        {
            _uur--;
            if (_uur < 0)
            {
                _uur = _uur + 24;
            }
        }

        public void MinutenPlus()
        {
            _minuut++;
            if (_minuut > 59)
            {
                _minuut = _minuut - 60;
            }
        }

        public void MinutenMin()
        {
            _minuut--;
            if (_minuut < 0)
            {
                _minuut = _minuut + 60;
            }
        }

        public String AlarmOm()
        {
            String minuutString;
            String uurString;

            minuutString = DisplayTweeCijfers(_minuut);
            uurString = DisplayTweeCijfers(_uur);

            return uurString + ":" + minuutString;
        }

        private String DisplayTweeCijfers(int getal)
        {
            String displayString;

            if (getal < 10)
            {
                displayString = "0" + getal.ToString();
            }
            else
            {
                displayString = getal.ToString();
            }

            return displayString;
        }
    }
}
