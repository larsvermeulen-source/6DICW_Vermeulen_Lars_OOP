namespace drielagenmodel_kindvoorspeller_Lars_Vermeulen
{
    public partial class Form1 : Form
    {
        private Voorspeller _voorspeller;
        public Form1()
        {
            InitializeComponent();
            _voorspeller = new Voorspeller();
        }
        private void button1_Click(object sender, EventArgs e) // bereken dochter
        {
            _voorspeller.add(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            label3.Text = _voorspeller.BerekenDochter().ToString("0.00");
            label4.Text = _voorspeller.AantalVoorspellingen.ToString();
        }
        private void button2_Click(object sender, EventArgs e) // bereken zoon
        {
            _voorspeller.add(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            label3.Text = _voorspeller.BerekenZoon().ToString("0.00");
            label4.Text = _voorspeller.AantalVoorspellingen.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e) // voorspelde lengte
        {

        }

        private void label4_Click(object sender, EventArgs e) // aantal voorspellingen
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // opgegeven lengte man
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // opgegeven lengte vrouw
        {

        }
    }
}
