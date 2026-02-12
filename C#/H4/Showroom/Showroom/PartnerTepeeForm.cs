using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Showroom
{
    public partial class PartnerTepeeForm : Form
    {
        private PartnerTepee _wagen;

        public PartnerTepeeForm()
        {
            InitializeComponent();

            _wagen = new PartnerTepee();
            _wagen.Autoradio = autoradioCheckBox.Checked;
            _wagen.Airco = aircoCheckBox.Checked;
            _wagen.KlapdeurenAchteraan = klapdeurenCheckBox.Checked;
            _wagen.SchuifdeurLinks = schuifdeurCheckBox.Checked;
            _wagen.CruiseControl = cruiseControlCheckBox.Checked;

            prijsTextBox.Text = _wagen.GeefPrijs().ToString("C");
        }

        private void autoradioCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (autoradioCheckBox.Checked == true)
            {
                autoradioPictureBox.Visible = true;
                _wagen.Autoradio = true;
            }
            else
            {
                autoradioPictureBox.Visible = false;
                _wagen.Autoradio = false;
            }

            prijsTextBox.Text = _wagen.GeefPrijs().ToString("C");
        }

        private void aircoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (aircoCheckBox.Checked == true)
            {
                aircoPictureBox.Visible = true;
                _wagen.Airco = true;
            }
            else
            {
                aircoPictureBox.Visible = false;
                _wagen.Airco = false;
            }

            prijsTextBox.Text = _wagen.GeefPrijs().ToString("C");
        }

        private void klapdeurenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (klapdeurenCheckBox.Checked == true)
            {
                klapdeurenPictureBox.Visible = true;
                _wagen.KlapdeurenAchteraan = true;
            }
            else
            {
                klapdeurenPictureBox.Visible = false;
                _wagen.KlapdeurenAchteraan = false;
            }

            prijsTextBox.Text = _wagen.GeefPrijs().ToString("C");
        }

        private void schuifdeurCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (schuifdeurCheckBox.Checked == true)
            {
               schuifdeurPictureBox.Visible = true;
                _wagen.SchuifdeurLinks = true;
            }
            else
            {
                schuifdeurPictureBox.Visible = false;
                _wagen.SchuifdeurLinks = false;
            }

            prijsTextBox.Text = _wagen.GeefPrijs().ToString("C");
        }

        private void cruiseControlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cruiseControlCheckBox.Checked == true)
            {
                cruiseControlPictureBox.Visible = true;
                _wagen.CruiseControl = true;
            }
            else
            {
                cruiseControlPictureBox.Visible = false;
                _wagen.CruiseControl = false;
            }

            prijsTextBox.Text = _wagen.GeefPrijs().ToString("C");
        }


    }
}
