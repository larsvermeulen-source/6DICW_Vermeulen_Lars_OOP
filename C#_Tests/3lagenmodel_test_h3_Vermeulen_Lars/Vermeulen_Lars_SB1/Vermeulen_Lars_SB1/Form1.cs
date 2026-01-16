using static Vermeulen_Lars_SB1.ComedyShow;

namespace Vermeulen_Lars_SB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // show toevoegen
        {
            // hier moet alles worden toegevoegd in de labels
            String naam = textBox6_TextChanged();
            double score = textBox7_TextChanged();
            Comedyshow.Add(naam);
            label1_Click() = ComedyShow.BerekenGemiddelde();
            label2_Click() = ComedyShow.get_StrLaatst;
            label3_Click() = ComedyShow.get(_intAantal);



        }

        private void label1_Click(object sender, EventArgs e) // gem score
        {

        }

        private void label2_Click(object sender, EventArgs e) // laatste show
        {

        }

        private void label3_Click(object sender, EventArgs e) // aantal shows
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e) // naam show invoeren
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e) // score invoeren
        {

        }
    }
}
