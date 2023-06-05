namespace _18._3Koordinata
{
    public partial class Koordinata : Form
    {
        public Koordinata()
        {
            InitializeComponent();
        }

        private void Frm_Holmozog_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("Az egér koordinátái: X:{0}, Y{1}", e.X, e.Y);
        }

        private void Frm_Holmozog_Resize(object sender, EventArgs e)
        {
            PanelIgazitas();
        }
        private void Frm_Holmozog_Load(object sender, EventArgs e)
        {
            PanelIgazitas();
        }
        private void PanelIgazitas(object sender, EventArgs e)
        {
            Panel.Left = (ClientSize.Width - Panel.Width) / 2;
            Panel.Top = (ClientSize.Height - Panel.Height) / 2;
        }
    }
}