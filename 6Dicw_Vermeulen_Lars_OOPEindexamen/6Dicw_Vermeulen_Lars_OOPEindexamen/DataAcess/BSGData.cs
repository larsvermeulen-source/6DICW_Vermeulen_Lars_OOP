using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace DataAcess
{
    public class BSGData
    {
        private String _connString;
        private MySqlConnection _mySqlConnection;

        //In de constructor worden velden gemaakt die we nodig zullen hebben voor de DB connectie
        public BSGData()
        {
            _connString = "server=localhost;user id=root;Password=Leerling123;database=cylondetector";
            _mySqlConnection = new MySqlConnection(_connString);
        }

        // Er word een connectie gemaakt met de DB van de personages en deze word ingeladen
        public List<Personage> ReadTablePersonages()
        {
            List<Personage> lijst = new List<Personage>();

            String sql = "SELECT * FROM personages";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                Personage personage = new Personage(
                    (int)mySqlDataReader["Id"],
                    mySqlDataReader["Naam"].ToString(),
                    (int)mySqlDataReader["PlaneetId"],
                    (int)mySqlDataReader["SchipId"],
                    (bool)mySqlDataReader["IsCylon"],
                    mySqlDataReader["Rol"].ToString(),
                    (int)mySqlDataReader["Leeftijd"]
                );

                lijst.Add(personage);
            }

            mySqlDataReader.Close();
            _mySqlConnection.Close();

            return lijst;
        }
        
        // Er word een connectie gemaakt met de DB van de vloot en deze word ingeladen
        public List<Schip> ReadTableVloot()
        {
            List<Schip> lijst = new List<Schip>();
            String sql = "SELECT * FROM Vloot";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                Schip schip = new Schip(
                    (int)mySqlDataReader["Id"],
                    mySqlDataReader["Naam"].ToString(),
                    mySqlDataReader["Type"].ToString(),
                    (int)mySqlDataReader["Bouwjaar"],
                    (int)mySqlDataReader["AantalBemanning"],
                    mySqlDataReader["Status"].ToString()
                );

                lijst.Add(schip);
            }

            mySqlDataReader.Close();
            _mySqlConnection.Close();

            return lijst;
        }
        
        // Er word een connectie gemaakt met de DB van de personages en deze word ingeladen
        public List<Planeet> ReadTableplaneten()
        {
            List<Planeet> lijst = new List<Planeet>();
            String sql = "SELECT * FROM Planeten";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                Planeet planeet = new Planeet(
                    (int)mySqlDataReader["Id"],
                    mySqlDataReader["Naam"].ToString(),
                    mySqlDataReader["Zonnestelsel"].ToString(),
                    (int)mySqlDataReader["WaterLiters"],
                    (bool)mySqlDataReader["Bewoonbaar"]
                ); //error bij inladen --> waterliters is het verkeerde type

                lijst.Add(planeet);
            }

            mySqlDataReader.Close();
            _mySqlConnection.Close();

            return lijst;
        }
        
        //Bonus:  
        //Er is een extra knop die beschikbaar wordt als je via "Detect Cyclon" een cyclon vindt
        //De row van de geselecteerd cyclon geven we mee als parameter
        //We halen het personage met deze parameter uit de Data Base van personages
        public void DeleteCyclon(int id)
        {
            String sql = "DELETE FROM Personages WHERE (Id = @ID);";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@ID", id);

            _mySqlConnection.Open();
            mySqlCommand.ExecuteNonQuery();
            _mySqlConnection.Close(); 
        }

    }
}