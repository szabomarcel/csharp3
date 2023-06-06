namespace _18._5es18._6ScrollBar
{
    public partial class ScrollBar : Form
    {
        public ScrollBar()
        {
            InitializeComponent();
        }

        private void Oldal_ValueChanged(object sender, EventArgs e)
        {
            Panel1.Width = Panel1.Width = Oldal.Value;
            Oldal.Text = Oldal.Value.ToString();
        }

        private void SB_Piros_ValueChanged(object sender, EventArgs e)
        {
            Panel1.BackColor = Color.FromArgb(SB_Piros.Value, SB_Zold.Value, SB_Kek.Value);
        }

        private void SB_Zold_ValueChanged(object sender, EventArgs e)
        {
            Panel1.BackColor = Color.FromArgb(SB_Piros.Value, SB_Zold.Value, SB_Kek.Value);
        }

        private void SB_Kek_ValueChanged(object sender, EventArgs e)
        {
            Panel1.BackColor = Color.FromArgb(SB_Piros.Value, SB_Zold.Value, SB_Kek.Value);
        }
    }
}