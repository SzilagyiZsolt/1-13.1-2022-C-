namespace Első_Forms
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSzamolj_Click(object sender, EventArgs e)
        {
            Eredmeny.Text="Eredmény: "+Convert.ToString(Szorzó.Value / Osztó.Value);
        }

        private void btnkilép_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Szam_Click(object sender, EventArgs e)
        {

        }
    }
}