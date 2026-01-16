using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpDeWeegschaal
{
    public partial class BMIForm : Form
    {
        private WeightWatcher weegschaal;
        public BMIForm()
        {
            InitializeComponent();
            weegschaal = new WeightWatcher(70, 1.75);
            UpdateScherm();
        }
        private void UpdateScherm()
        {
            label1.Text = weegschaal.grootte.ToString("0.00") + " m"; // Lengte
            label2.Text = weegschaal.gewicht + " kg";            // Massa
            label3.Text = weegschaal.GeefBMI().ToString("0.0");  // BMI
            label4.Text = weegschaal.GeeftStatus();              // Status
        }
        private void label1_Click(object sender, EventArgs e) // Lengte
        {
            // Gebeurt bij updatescherm
        }
        private void label2_Click(object sender, EventArgs e) // Massa
        {
            // Gebeurt bij updatescherm
        }

        private void label3_Click(object sender, EventArgs e) // BMI
        {
            // Gebeurt bij updatescherm
        }

        private void label4_Click(object sender, EventArgs e) // Status
        {
            // Gebeurt bij updatescherm
        }

        private void button1_Click(object sender, EventArgs e) // - button
        {
            if (weegschaal.gewicht > 1)
            {
                weegschaal.gewicht--;
                UpdateScherm();
            }
        }

        private void button2_Click(object sender, EventArgs e) // + button
        {
            weegschaal.gewicht++;
            UpdateScherm();
        }
    }
}
