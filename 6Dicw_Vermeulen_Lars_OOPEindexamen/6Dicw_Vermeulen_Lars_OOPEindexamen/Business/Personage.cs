using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Personage 
    {
        private int _id;
        private String _name;
        private int _planeetId;
        private int _schipId;
        private Boolean _isCylon;
        private String _rol;
        private int _leeftijd;

        // Contstructor van Personages die alle velden een waarde geeft uit de parameter
        public Personage(int id, String name, int planeetID, int schipId, Boolean isCyclon, String rol, int leeftijd)
        {
            this._id = id;
            this._name = name;
            this._planeetId = planeetID;
            this._schipId = schipId;
            this.isCyclon = isCyclon;
            this._rol = rol;
            this._leeftijd = leeftijd;
        }

        // Hier onder staan alle properties van de velden
        public int id { get { return _id; } set { _id = value; } }
        public String name { get { return _name; } set { _name = value; } }
        public int plaanedId { get { return _planeetId; } set { _planeetId = value; } }
        public int schipId { get { return _schipId; } set { _schipId = value; } }
        public Boolean isCyclon { get { return _isCylon; } set { _isCylon = value; } }
        public String rol { get { return _rol; } set { _rol = value; } }
        public int leeftijd { get { return _leeftijd; } set { _leeftijd = value; } }    

    }
}
