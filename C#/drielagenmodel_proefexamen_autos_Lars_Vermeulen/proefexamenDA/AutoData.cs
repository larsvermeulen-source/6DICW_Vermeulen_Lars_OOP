using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proefexamenBL;

namespace proefexamenDA
{
    public class AutoData
    {
        private String _connString;
        private MySqlConnection _mySqlConnection;

        public AutoData()
        {
             // connectiestring voor de MySQL-databank wandelroutes
             _connString = "server=localhost;user id=root;Password=Leerling123;database=showroomdb"; 
             // initialiseer de connectie op basis van de connectiestring
             _mySqlConnection = new MySqlConnection(_connString); 
        }

        public List<Auto> GeefAutosLijst()
        {
            List<Auto> lijst = new List<Auto>();
            
            //sorteren op merk, klopt dit?
            String sql = "SELECT * FROM autos;";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                // nieuwe auto maken met de actieve record in mySqlDataReader 
                Auto auto =
                     new Auto()
                     {
                         Id = (int)(mySqlDataReader["id"]),
                         Merk = mySqlDataReader["merk"].ToString(),
                         Model = mySqlDataReader["model"].ToString(),
                         Prijs = Convert.ToDecimal(mySqlDataReader["prijs"]),
                         LandVanHerkomst = mySqlDataReader["land_van_herkomst"].ToString()
                     };

                // voeg de auto toe aan de lijst 
                lijst.Add(auto);
            }

            mySqlDataReader.Close();
            // de connectie met de databank terug sluiten 
            _mySqlConnection.Close();

            // lijst met alle autos retourneren 
            return lijst;
        }

        public void WijzigAuto(Auto auto)
        {
                // SQL-statement om een auto te updaten  
                String sql = "UPDATE autos SET merk = @Merk, model = @Model, prijs = @Prijs, land_van_herkomst = @LandVanHerkomst WHERE(id = @ID); "; 
                // SQL-commando aanmaken op basis van ons SQL-statement 
                 MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

                mySqlCommand.Parameters.AddWithValue("@Merk", auto.Merk);
                mySqlCommand.Parameters.AddWithValue("@Model", auto.Model);
                mySqlCommand.Parameters.AddWithValue("@Prijs", auto.Prijs);
                mySqlCommand.Parameters.AddWithValue("@LandVanHerkomst", auto.LandVanHerkomst);
                mySqlCommand.Parameters.AddWithValue("@ID", auto.Id);
                
                _mySqlConnection.Open();
                // ExecuteNonQuery om een MySqlCommand te starten dat GEEN gegevens leest 
                mySqlCommand.ExecuteNonQuery();
                // de connectie met de databank terug sluiten 
                _mySqlConnection.Close();
        }

        public void VerwijderAuto(int id)
        {
            // SQL-statement om een auto te wissen 
            String sql = "DELETE FROM autos WHERE (id = @ID);";
            // SQL-commando aanmaken op basis van ons SQL-statement 
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@ID", id);

            _mySqlConnection.Open();
            // ExecuteNonQuery om een MySqlCommand te starten dat geen gegevens inleest 
            mySqlCommand.ExecuteNonQuery();
            // de connectie met de databank terug sluiten 
            _mySqlConnection.Close();
        }

        public void VoegAutoToe(Auto auto)
        {
            // SQL-statement om een auto toe te voegen  
            String sql =
            "INSERT INTO autos(merk, model, prijs, land_van_herkomst)VALUES(@Merk, @Model, @Prijs, @LandVanHerkomst); "; 
            // SQL-commando aanmaken op basis van ons SQL-statement 
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@Merk", auto.Merk);
            mySqlCommand.Parameters.AddWithValue("@Model", auto.Model);
            mySqlCommand.Parameters.AddWithValue("@Prijs", auto.Prijs);
            mySqlCommand.Parameters.AddWithValue("@LandVanHerkomst", auto.LandVanHerkomst);
            // de connectie met de databank openen 
            _mySqlConnection.Open();
            // ExecuteNonQuery om een MySqlCommand te starten dat geen gegevens inleest 
            mySqlCommand.ExecuteNonQuery();
            // de connectie met de databank terug sluiten 
            _mySqlConnection.Close();
        }
    }
}
