using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpDeWeegschaal
{
    public class WeightWatcher
    {
        private int _gewicht;
        private double _grootte;
        public WeightWatcher(int gewicht, double grootte)
        {
            _gewicht = gewicht;
            _grootte = grootte;
        }
        public int gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }
        public double grootte
        {
            get { return _grootte; }
        }
        public double GeefBMI()
        {
            double BMI = gewicht / (grootte * grootte);
            return BMI;
        }
        public String GeeftStatus()
        {
            double BMI = GeefBMI();
            if (BMI < 20) {
                return "ondergewicht";
            }
            else if (BMI < 25) {
                return "ok";
            }
            else if (BMI < 30) {
                return "overgewicht";
            }
            else{
                return "obees";
            }
        }
    }
}
