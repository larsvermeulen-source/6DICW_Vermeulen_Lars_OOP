using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wekker
{
    public partial class WekkerForm : Form
    {
        private Wekker _wekker; // het veld _wekker declareren
        public WekkerForm()
        {
            InitializeComponent();
            // het veld _wekker initialiseren als een nieuw Wekker-object
            _wekker = new Wekker();
            // tijdstip van de wekker in het tekstvak zetten
            UpdateWekkerInFormulier();
        }
        private void uurOmhoogButton_Click(object sender, EventArgs e)
        {
            _wekker.UrenPlus();
            // tijdstip in het tekstvak updaten
            UpdateWekkerInFormulier();
        }
        private void uurOmlaagButton_Click(object sender, EventArgs e)
        {
            _wekker.UrenMin();
            // tijdstip in het tekstvak updaten
            UpdateWekkerInFormulier();
        }
        private void minuutOmhoogButton_Click(object sender, EventArgs e)
        {
            _wekker.MinutenPlus();
            // tijdstip in het tekstvak updaten
            UpdateWekkerInFormulier();
        }
        private void minuutOmlaagButton_Click(object sender, EventArgs e)
        {
            _wekker.MinutenMin();
            // tijdstip in het tekstvak updaten
            UpdateWekkerInFormulier();
        }
        private void UpdateWekkerInFormulier()
        {
            // tijdstip in het tekstvak updaten
            alarmOmTextBox.Text = _wekker.AlarmOm();
        }  
    }
}

