namespace _18._5es18._6ScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Sb_Piros_ValueChanged(object sender, EventArgs e)
        {
            Lb_Negyzet.BackColor = Color.FromArgb(Sb_Piros.Value,
                      Sb_Zold.Value, Sb_Kek.Value);
        }

        private void Sb_Oldal_ValueChanged(object sender, EventArgs e)
        {
            Lb_Negyzet.Width = Lb_Negyzet.Height = Sb_Oldal.Value;
            Lb_Oldal.Text = Sb_Oldal.Value.ToString();
        }

        private void Sb_Zold_ValueChanged(object sender, EventArgs e)
        {
            Lb_Negyzet.BackColor = Color.FromArgb(Sb_Piros.Value,
                     Sb_Zold.Value, Sb_Kek.Value);
        }

        private void Sb_Kek_ValueChanged(object sender, EventArgs e)
        {
            Lb_Negyzet.BackColor = Color.FromArgb(Sb_Piros.Value,
                     Sb_Zold.Value, Sb_Kek.Value);
        }
    }
}