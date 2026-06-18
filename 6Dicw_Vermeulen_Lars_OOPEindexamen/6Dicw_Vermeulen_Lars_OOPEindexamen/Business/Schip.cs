using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Schip
    {
        private int _id;
        private String _name;
        private String _type;
        private int _bouwjaar;
        private int _aantalBemanning;
        private String _status;

        //Contstructor van Schip die alle velden een waarde geeft uit de parameter
        public Schip(int id, String name, String type, int bouwjaar, int aantalbemanning, String status)
        {
            this._id = id;
            this._name = name;
            this.type = type;
            this.bouwjaar = bouwjaar;
            this.aantalBemanning = aantalbemanning;
            this.status = status;
        }

        // Hier onder staan alle properties van de velden
        public int id { get { return _id; } set { _id = value; } }
        public String name { get { return _name; } set { _name = value; } }
        public String type { get { return _type; } set { _type = value; } }
        public int bouwjaar { get { return _bouwjaar; } set { _bouwjaar = value; } }
        public int aantalBemanning { get { return _aantalBemanning; } set { _aantalBemanning = value; } }
        public String status { get { return _status; } set { _status = value; } }
    }
}
