using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Planeet
    {
        private int _id;
        private String _name;
        private String _zonnenstelsel;
        private int _waterLiters;
        private Boolean _isBewoonBaar;

        //Contstructor van Planeet die alle velden een waarde geeft uit de parameter
        public Planeet(int id, String name, String _zonnenstelsel, int waterLiters, Boolean isBewoonBaar)
        {
            this._id = id;
            this._name = name;
            this._zonnenstelsel = zonnenstelsel;
            this._waterLiters = waterLiters;
            this._isBewoonBaar = isBewoonBaar;
        }

        // Hieronder onder staan alle properties van de velden
        public int id { get { return _id; } set { _id = value; } }
        public String name { get { return _name; } set { _name = value; } }
        public String zonnenstelsel { get { return _zonnenstelsel; } set { _zonnenstelsel = value; } }
        public int waterLiters { get { return _waterLiters; } set { _waterLiters = value; } }
        public Boolean isBewoonBaar { get { return _isBewoonBaar; } set {_isBewoonBaar = value; } }
    }
}
