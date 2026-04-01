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
    public partial class DobbelsteenForm : Form
    {
        // businessobject _dobbelsteen declareren
        private Business.Dobbelsteen _dobbelsteen;
        public DobbelsteenForm(int aantalZijden)
        {
            InitializeComponent();
            // businessobject _dobbelsteen initialiseren met 6 zijden
            _dobbelsteen = new Business.Dobbelsteen(aantalZijden);
            // dobbelsteen werpen en resultaat in tekstvak tonen
            dobbelsteenTextBox.Text = _dobbelsteen.Werp().ToString();
        }
        private void werpenButton_Click(object sender, EventArgs e)
        {
            // dobbelsteen werpen en resultaat in tekstvak tonen
            dobbelsteenTextBox.Text = _dobbelsteen.Werp().ToString();
        }
    }
}
