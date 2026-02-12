using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wielertenue
{
    public partial class BestellingForm : Form
    {
        private BestellingWielertenue _bestellingen;

        public BestellingForm()
        {
            InitializeComponent();
            _bestellingen = new BestellingWielertenue(1,false,false,false);
            prijsTextBox.Text = _bestellingen.GeefPrijs().ToString();
        }

        private void prijsTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void superzeemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (superzeemCheckBox.Checked)
            {
                _bestellingen.superZeem = true;
                _bestellingen.superZeem = true;
            }
            else
            {
                _bestellingen.superZeem = false;
            }
                prijsTextBox.Text = _bestellingen.GeefPrijs().ToString();
        }

        private void broekCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (broekCheckBox.Checked)
            {
                superzeemCheckBox.Visible =true;
                _bestellingen.broek = true;
                wielertenuePictureBox.Visible = true;
            }
            else
            {
                superzeemCheckBox.Visible = false;
                _bestellingen.broek = false;
               wielertenuePictureBox.Visible = false;
               superzeemCheckBox.Checked= false;
            }
            prijsTextBox.Text = _bestellingen.GeefPrijs().ToString();
        }

        private void waterdichtZakjeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (waterdichtZakjeCheckBox.Checked)
            {
                _bestellingen.waterdichtZakje = true;
            }
            else
            {
                _bestellingen.waterdichtZakje = false;
            }
            prijsTextBox.Text = _bestellingen.GeefPrijs().ToString();
        }

        private void wielertenuePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void aantalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _bestellingen.aantal = (int)aantalNumericUpDown.Value;
            prijsTextBox.Text = _bestellingen.GeefPrijs().ToString();
        }
    }
}
