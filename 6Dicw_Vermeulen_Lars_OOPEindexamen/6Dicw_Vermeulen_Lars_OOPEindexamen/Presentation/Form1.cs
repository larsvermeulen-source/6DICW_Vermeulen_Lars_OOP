using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAcess;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private BSGData _dataLaag = new BSGData();
        // Dit is zodat we aan de DB kunnen en de DA methodes
        public Form1()
        {
            InitializeComponent();

            btnDeleteCyclon.Visible = false; 
            // Bonus: de delete button verbegen, deze wordt visable zodra er een cyclon is gevonden
        }
        // Een functie die alle 3 die DGV's refresht
        public void HerlaadAlleData()
        {
            dgvPersonages.DataSource = null;
            dgvPersonages.DataSource = _dataLaag.ReadTablePersonages();

            dgvVloot.DataSource = null;
            dgvVloot.DataSource = _dataLaag.ReadTableVloot();

            dgvPlaneten.DataSource = null;
            dgvPlaneten.DataSource = _dataLaag.ReadTableplaneten();
        }

        // Als deze button wordt ingedrukt word de DGV van de vloot ingeladen
        private void btnLaatVloot_Click(object sender, EventArgs e)
        {
            dgvVloot.DataSource = null; // Refresht de DGV
            dgvVloot.DataSource = _dataLaag.ReadTableVloot();
        }

        //Als deze button wordt ingedrukt word de DGV van de personages ingeladen
        private void btnLaatPersonages_Click(object sender, EventArgs e)
        {
            //personages ophalen

            dgvPersonages.DataSource = null;
            dgvPersonages.DataSource = _dataLaag.ReadTablePersonages();
        }

        // Als deze button wordt ingedrukt word de DGV van de planeten ingeladen
        private void btnLaadPlaneten_Click(object sender, EventArgs e)
        {
            //planeten ophalen

            dgvPlaneten.DataSource = null;
            dgvPlaneten.DataSource = _dataLaag.ReadTableplaneten();
        }

        // Als deze button wordt ingedrukt wordt de geselecteerde row van DGV personages opgehaald
        // En wordt er gecontroleerd of het geselecteerde personage een cyclon is
        // Als deze een cyclon is moet de titel van kleur veranderen
        // Cyclon --> rood & Human --> groen
        // Bonus: als de selected row een cyclon is moet de delete button visable worden
        private void btnDetectCyclon_Click(object sender, EventArgs e)
        {
            int currentrow = dgvPersonages.CurrentRow.Index; 
            //error als er niks is selected --> niet kunnen uithalen, helaas
            Personage personage = (Personage)dgvPersonages.CurrentRow.DataBoundItem;

            if (personage != null)
            {
                if (personage.isCyclon)// kijken of het cyclon is )
                {
                    lblDetectorTest.ForeColor = Color.Red;
                    btnDeleteCyclon.Visible = true; // Bonus verwijder knop
                }
                else
                {
                    lblDetectorTest.ForeColor = Color.Green;
                    btnDeleteCyclon.Visible = false; //Bonus verwijder knop
                }

              }
        }

        // Laad de GRV van alle 3
        // En maakt de titel weer wit tekst
        private void btnHerlaadData_Click(object sender, EventArgs e)
        {
            HerlaadAlleData();

            // Bonus; titel weer op wit & de button weer laten onzichtbaar
            lblDetectorTest.ForeColor = Color.White;
            btnDeleteCyclon.Visible = false;
        }

        //Bonus: als deze wordt ingedrukt moet de geselecteerde row worden verwijderd uit de DGV personages
        private void btnDeleteCyclon_Click(object sender, EventArgs e)
        {
            int currentrow = dgvPersonages.CurrentRow.Index;
            Personage personage = (Personage)dgvPersonages.CurrentRow.DataBoundItem;
            // Ik heb dit nog eens opgehaald in het geval dat de tussen detetc en verwijder iets anders selecteren

            if (personage != null)
            {
                if (personage.isCyclon)
                {

                    _dataLaag.DeleteCyclon(personage.id);

                    //aangepast DGV weer laden
                    btnLaatPersonages_Click(sender, e);

                    // Alles terug naar normaal
                    lblDetectorTest.ForeColor = Color.White;
                    btnDeleteCyclon.Visible = false;
                }
            }
        }
    }
}
