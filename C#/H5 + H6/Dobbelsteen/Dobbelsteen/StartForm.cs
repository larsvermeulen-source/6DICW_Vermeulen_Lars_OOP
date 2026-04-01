using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobbelsteen
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
            private void dobbelsteen6Button_Click(object sender, EventArgs e)
        {
            DobbelsteenForm formulier = new DobbelsteenForm(6);
            formulier.Show();
        }
        private void dobelsteen12Button_Click(object sender, EventArgs e)
        {
            DobbelsteenForm formulier = new DobbelsteenForm(12);
            formulier.Show();
        }
        private void dobbelsteenXButton_Click(object sender, EventArgs e)
        {
            int aantalZijden = (int) zijdenNumericUpDown.Value;
            DobbelsteenForm formulier = new DobbelsteenForm(aantalZijden);
            formulier.Show();
        }
    }
}
