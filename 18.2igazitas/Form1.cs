namespace _18._2igazitas
{
    public partial class btnIgazitas : Form
    {
        public btnIgazitas()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            int n = e.X / (btnIgazitas.Width / 3);
            int m = e.Y / (btnIgazitas.Height / 3);
            switch (m * 3 + n)
            {
                case 0: btnIgazitas.TextAlign = ContentAlignment.TopLeft; break;
                case 1: btnIgazitas.TextAlign = ContentAlignment.TopCenter; break;
                case 2: btnIgazitas.TextAlign = ContentAlignment.TopRight; break;
                case 3: btnIgazitas.TextAlign = ContentAlignment.MiddleLeft; break;
                case 4: btnIgazitas.TextAlign = ContentAlignment.MiddleCenter; break;
                case 5: btnIgazitas.TextAlign = ContentAlignment.MiddleRight; break;
                case 6: btnIgazitas.TextAlign = ContentAlignment.BottomLeft; break;
                case 7: btnIgazitas.TextAlign = ContentAlignment.BottomCenter; break;
                case 8: btnIgazitas.TextAlign = ContentAlignment.BottomRight; break;
            }
        }
    }
}