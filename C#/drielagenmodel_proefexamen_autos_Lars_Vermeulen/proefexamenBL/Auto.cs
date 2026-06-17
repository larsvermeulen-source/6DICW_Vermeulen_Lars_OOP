using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proefexamenBL
{
    public class Auto
    {
        private int _id;
        private String _merk;
        private String _model;
        private decimal _prijs;
        private String _landVanHerkomst;


        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        public string Merk {
            get { return _merk; }
            set { _merk = value; }
        }
        public string Model {
            get { return _model; }
            set { _model = value; }
        }
        public decimal Prijs {
            get { return _prijs; }
            set { _prijs = value; }
        }
        public string LandVanHerkomst {
            get { return _landVanHerkomst; }
            set { _landVanHerkomst = value; }
        }
    }
}
