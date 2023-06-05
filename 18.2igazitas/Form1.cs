namespace _18._2igazitas
{
    public partial class btnIgazitas : Form
    {
        public btnIgazitas()
        {
            InitializeComponent();
        }

        private void Igazitas_MouseClick(object sender, MouseEventArgs e)
        {
            int n = e.X / (Igazitas.Width / 3);
            int m = e.Y / (Igazitas.Height / 3);
            switch (m * 3 + n)
            {
                case 0: Igazitas.TextAlign = ContentAlignment.TopLeft; break;
                case 1: Igazitas.TextAlign = ContentAlignment.TopCenter; break;
                case 2: Igazitas.TextAlign = ContentAlignment.TopRight; break;
                case 3: Igazitas.TextAlign = ContentAlignment.MiddleLeft; break;
                case 4: Igazitas.TextAlign = ContentAlignment.MiddleCenter; break;
                case 5: Igazitas.TextAlign = ContentAlignment.MiddleRight; break;
                case 6: Igazitas.TextAlign = ContentAlignment.BottomLeft; break;
                case 7: Igazitas.TextAlign = ContentAlignment.BottomCenter; break;
                case 8: Igazitas.TextAlign = ContentAlignment.BottomRight; break;
            }
        }
    }
}