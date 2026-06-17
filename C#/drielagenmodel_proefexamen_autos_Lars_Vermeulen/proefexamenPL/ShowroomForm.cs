using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proefexamenBL;
using proefexamenDA;

namespace proefexamenPL
{
    public partial class ShowroomForm : Form
    {
        private List<Auto> autos = new List<Auto>();
        private AutoData _autoData;
        public ShowroomForm()
        {
            InitializeComponent();

            _autoData = new AutoData();
            autos = _autoData.GeefAutosLijst(); // data laden bij opstarten van het formulier

            BouwGridKolommen();
            ToonLijstInGrid(); // data tonen bij opstarten van het formulier
        }
        public void BouwGridKolommen() //Nodig omdat DGR meerdere kolommen heeft.
        {
            if (!dgvAutos.Columns.Contains("Id"))
            {
                dgvAutos.Columns.Add("Id", "Id");
                dgvAutos.Columns.Add("Merk", "Merk");
                dgvAutos.Columns.Add("Model", "Model");
                dgvAutos.Columns.Add("Prijs", "Prijs");
                dgvAutos.Columns.Add("LandVanHerkomst", "Land van herkomst");
            }
        }

        private void ToonLijstInGrid() //functie voor bij de buttons
        {
            dgvAutos.Rows.Clear();
            foreach (Auto auto in autos)
            {
                dgvAutos.Rows.Add(auto.Id, auto.Merk, auto.Model, auto.Prijs, auto.LandVanHerkomst);
            }
        }

        private void btnLaadAutos_Click(object sender, EventArgs e)
        {
            autos = _autoData.GeefAutosLijst();
            ToonLijstInGrid();
        }

        private void btnToonDuitse_Click(object sender, EventArgs e)
        {
            autos = _autoData.GeefAutosLijst();

            autos = autos.FindAll(a => a.LandVanHerkomst == "DEU"); //wat is hier a? --> mini foreach
            ToonLijstInGrid();  // FIX 1: Vergeet de grid niet te vernieuwen!
        }

        private void btnOpenToevoegen_Click(object sender, EventArgs e)
        {
            DetailsForm formulier = new DetailsForm();

            // FIX 2: Vang het DialogResult op. Als er op opslaan is geklikt, verversen we direct!
            if (formulier.ShowDialog() == DialogResult.OK)
            {
                autos = _autoData.GeefAutosLijst();
                ToonLijstInGrid();
            }
        }

        private void btnOpenWijzigen_Click(object sender, EventArgs e)
        {
            //DetailsForm formulier = new DetailsForm(); formulier.ShowDialog();

            // FIX 3: Controleer of er wel een rij geselecteerd is in de DataGridView
            if (dgvAutos.CurrentRow != null)
            {
                // Haal de index op van de geselecteerde auto in onze List<>
                int geselecteerdeIndex = dgvAutos.CurrentRow.Index;
                Auto gekozenAuto = autos[geselecteerdeIndex];

                // Geef de auto mee aan de tweede constructor van DetailsForm!
                DetailsForm formulier = new DetailsForm(gekozenAuto);
                if (formulier.ShowDialog() == DialogResult.OK)
                {
                    autos = _autoData.GeefAutosLijst();
                    ToonLijstInGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een auto uit de lijst.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            //DetailsForm formulier = new DetailsForm(); formulier.ShowDialog();

            // FIX 4: Wissen gebeurt direct in dit scherm, zonder het DetailsForm te openen!
            if (dgvAutos.CurrentRow != null)
            {
                int geselecteerdeIndex = dgvAutos.CurrentRow.Index;
                Auto gekozenAuto = autos[geselecteerdeIndex];

                DialogResult result = MessageBox.Show($"Ben je zeker dat je de {gekozenAuto.Merk} wilt wissen?", "Bevestig", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    _autoData.VerwijderAuto(gekozenAuto.Id); // Roep je DA-methode aan!
                    autos = _autoData.GeefAutosLijst(); // Lijst opnieuw ophalen
                    ToonLijstInGrid(); // Grid verversen
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een auto om te wissen.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}   
