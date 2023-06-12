namespace _18._4Mozog
{
    public partial class Mozog : Form
    {
        public Mozog()
        {
            InitializeComponent();
        }

        private void btnKozepre_Click(object sender, EventArgs e)
        {
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            btnLe.Visible = btnLe.Visible =
            btnFel.Visible = btnFel.Visible =
            btnBal.Visible = btnBal.Visible =
            btnJobbra.Visible = btnJobbra.Visible = true;
        }

        private void btnNovekvo_Click(object sender, EventArgs e)
        {
            Width += Width;
            Height += Height;
        }

        private void btnCsokkeno_Click(object sender, EventArgs e)
        {
            Width -= Width;
            Height -= Height;
        }

        private void btNovekvo_Click(object sender, EventArgs e)
        {
            if (Opacity > 0.1)
            {
                Opacity += 0.1;
            }
        }

        private void btCsokkeno_Click(object sender, EventArgs e)
        {
            if (Opacity > 0.1)
            {
                Opacity -= 0.1;
            }
        }

        private void btnFel_Click(object sender, EventArgs e)
        {
            int btnMeret = 1;
            if (Top - btnMeret > 0)
            {
                Top -= btnMeret;
            }
            else
            {
                Top = 0;
                btnFel.Visible = btnTeljesenFel.Visible = false;
            }
            btnLe.Visible = btnTeljesenLe.Visible = true;
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            Top += 10;
            if (Top == (Screen.PrimaryScreen.Bounds.Height - Height))
            {
                Top = 0;
                btnFel.Visible = btnTeljesenFel.Visible = false;
            }
            btnLe.Visible = btnTeljesenLe.Visible = true;
        }

        private void btnTeljesenFel_Click(object sender, EventArgs e)
        {
            Top = 0;
            btnTeljesenFel.Visible = btnTeljesenFel.Visible = false;
            btnTeljesenFel.Visible = btnTeljesenFel.Visible = true;
        }

        private void btnTeljesenLe_Click(object sender, EventArgs e)
        {
            Top = (Screen.PrimaryScreen.Bounds.Height - Height);
            btnTeljesenLe.Visible = btnTeljesenLe.Visible = false;
            btnTeljesenLe.Visible = btnTeljesenLe.Visible = true;
        }
    }
}