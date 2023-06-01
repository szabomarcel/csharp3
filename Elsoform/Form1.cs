namespace Elsoform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSzamol_Click(object sender, EventArgs e) // (private) void == nem add vissza értéket
        {
            Label.Text = Convert.ToString(nudSzorzo.Value / nudOszto.Value);
        }

        private void btnKilep_Click(object sender, EventArgs e) // (private) void == nem add vissza értéket
        {
            Close();
        }
    }
}