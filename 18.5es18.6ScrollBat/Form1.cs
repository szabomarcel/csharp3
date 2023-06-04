namespace _18._5es18._6ScrollBat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCsuszka_ValueChanged(object sender, EventArgs e)
        {
            Lb_Negyzet.BackColor = Color.FromArgb(btnPiros.Value, btnZold.Value, btnKek.Value);
        }
        private void Oldala_ValueChanged(object sender, EventArgs e)
        {
            Lb_Negyzet.Width = Lb_Negyzet.Height = Oldala.Value;
            Oldala.Text = Oldala.Value.ToString();
        }
    }
}