using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class BordForm : Form
    {
        public BordForm()
        {
            InitializeComponent();
        }

        private void vak23Button_Click(object sender, EventArgs e) // Kortrijksestr. Gent
        {
            StraatForm formulier = new StraatForm("Kortrijksestr.", "Gent", 18, 90, 250, 700, 875, 1050,Color.Red);
            formulier.Show();
        }
        private void vak29Button_Click(object sender, EventArgs e) // Veldstraat Gent
        {
            StraatForm formulier = new StraatForm("Veldstraat","Gent", 22, 120, 360, 850, 1025, 1200,Color.Yellow);
            formulier.Show();
        }

        private void vak32Button_Click(object sender, EventArgs e) //Vlaanderenstr. Gent
        {
            StraatForm formulier = new StraatForm("Vlaanderenstr.", "Gent", 26, 130, 390, 900, 1100, 1275,Color.Green);
            formulier.Show();
        }
    }
}
