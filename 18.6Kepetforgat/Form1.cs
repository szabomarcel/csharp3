namespace _18._6Kepetforgat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBal_Click(object sender, EventArgs e)
        {
            Image s = Lb_1.Image;
            Lb_1.Image = Lb_2.Image;
            Lb_2.Image = Lb_3.Image;
            Lb_3.Image = Lb_4.Image;
            Lb_4.Image = Lb_5.Image;
            Lb_5.Image = Lb_6.Image;
            Lb_6.Image = Lb_7.Image;
            Lb_7.Image = Lb_8.Image;
            Lb_8.Image = s;
        }

        private void btnJobb_Click(object sender, EventArgs e)
        {
            Image s = Lb_8.Image;
            Lb_8.Image = Lb_7.Image;
            Lb_7.Image = Lb_6.Image;
            Lb_6.Image = Lb_5.Image;
            Lb_5.Image = Lb_4.Image;
            Lb_4.Image = Lb_3.Image;
            Lb_3.Image = Lb_2.Image;
            Lb_2.Image = Lb_1.Image;
            Lb_1.Image = s;
        }

        private void btnBal_Click_1(object sender, EventArgs e)
        {

        }
    }
}