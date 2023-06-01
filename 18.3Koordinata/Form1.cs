namespace _18._3Koordinata
{
    public partial class Frm_Holmozog : Form
    {
        public Frm_Holmozog()
        {
            InitializeComponent();
        }


        private void PanelIgazit_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("Az egér koordinátái X:{0}, Y:{1}, e.X, e.Y")
        }

        private void PanelIgazit_Resize(object sender, EventArgs e)
        {
            Frm_Holmozog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Frm_Holmozog();
        }
    }
}