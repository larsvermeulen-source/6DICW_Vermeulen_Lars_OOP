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
    public partial class DetailsForm : Form
    {
        private AutoData datalaag = new AutoData();
        private Auto bestaandeAuto = null; 
        private bool isWijziging;
        public DetailsForm() //constructor voor toevoegen van een nieuwe auto
        {
            InitializeComponent();
            isWijziging = false;
        }
        public DetailsForm(Auto a) // constructor voor wijziging van een bestaande auto
        {
            InitializeComponent();
            isWijziging = true;
            bestaandeAuto = a;
            VulVeldenIn(); // de textboxen invullen
        }
        public void VulVeldenIn()
        {
            txtMerk.Text = bestaandeAuto.Merk;
            txtModel.Text = bestaandeAuto.Model;
            txtPrijs.Text = bestaandeAuto.Prijs.ToString();
            txtLand.Text = bestaandeAuto.LandVanHerkomst;
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; //wat doet dit nu weer? --> pop-up venster
            this.Close();
        }

        private void btnOpslaan_Click(object sender, EventArgs e) //alle txtboxen overlopen, en DB aanpassen 
        {
            if (string.IsNullOrWhiteSpace(txtMerk.Text) || string.IsNullOrWhiteSpace(txtModel.Text) || string.IsNullOrWhiteSpace(txtLand.Text))
            {
                MessageBox.Show("Vul alle velden in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrijs.Text, out decimal prijs))
            {
                MessageBox.Show("Voer een geldige prijs in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isWijziging)
            {
                // GEBRUIK CRUD: WijzigAuto(Auto a)
                bestaandeAuto.Merk = txtMerk.Text;
                bestaandeAuto.Model = txtModel.Text;
                bestaandeAuto.Prijs = prijs;
                bestaandeAuto.LandVanHerkomst = txtLand.Text;

                datalaag.WijzigAuto(bestaandeAuto);
            }
            else
            {
                Auto nieuweAuto = new Auto
                {
                    Merk = txtMerk.Text,
                    Model = txtModel.Text,
                    Prijs = prijs,
                    LandVanHerkomst = txtLand.Text,
                };
                datalaag.VoegAutoToe(nieuweAuto);
            }

         this.DialogResult = DialogResult.OK; //zelfde als die cancel waar staat dit en wat doet dit nu weer?
         this.Close();
        }
    }
}
