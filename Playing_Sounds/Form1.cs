using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Playing_Sounds
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayer;
        public Form1()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("JR Feco - Something Just Like This Cover Piano (Music VIdeo)");
        }
        private void duelStateButton_CheckedChanged(object sender, EventArgs e)
        {
            if (duelStateButton.Checked)
            {
                duelStateButton.Text = "Stop";
                _soundPlayer.Play();
            }
            else
            {
                duelStateButton.Text = "Play";
                _soundPlayer.Stop();
            }
        }
    }
}