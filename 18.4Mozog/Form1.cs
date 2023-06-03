namespace _18._4Mozog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKozepre_Click(object sender, EventArgs e)
        {
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            btnLe.Visible = btnLe.Visible =
            btnFel.Visible = btnFel.Visible =
            btnBalra.Visible = btnBalra.Visible =
            btnJobbra.Visible = btnJobbra.Visible = true;
        }

        private void btnNovekszik_Click(object sender, EventArgs e)
        {
            if (Opacity < 1.0)
            {
                Opacity += 0.1;
            }
        }

        private void btnCsokken_Click(object sender, EventArgs e)
        {
            Width -= Width;
            Height -= Height;
        }

        private void btnTeljesen3_Click(object sender, EventArgs e)
        {
            Top = 0;
            btnFel.Visible = btnTeljesenFel.Visible = false;
            btnLe.Visible = btnTeljesenLe.Visible = true;
        }

        private void btnFel_Click(object sender, EventArgs e)
        {
            if(Top - btnMeret > 0)
            {
                Top -= btnMeret;
            }
            else
            {
                Top = 0;
                btnFel.Visible = btnTeljesenFel.Visible = false;
            }
            btnTeljesenLe.Visible = btnTeljesenLe.Visible = true;
        }
    }
}