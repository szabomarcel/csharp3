namespace _18._7Komponens
{
    public partial class Komponensek : Form
    {
        Random rand = new Random();
        List<int> items = new List<int>();
        public Komponensek()
        {
            InitializeComponent();
        }
        private void NumbersClick()
        {
            PictureBox click = new PictureBox();
            click.Height = 0; click.Width = 0;

            int x = rand.Next(10, this.ClientSize.Width - click.Width);
            int y = rand.Next(10, this.ClientSize.Height - click.Height);
            click.Location = new Point(x, y);
            click.Click += NewClick;
            items.Add(click);
            this.Contorls.Add(click);
        }
        private void NewClick(object sender, EventArgs e)
        {
            PictureBox temClick = sender as PictureBox;

            items.Remove(temClick);
            this.Controls.Remove(temClick);
        }
        private void TimeEvent(object sender, EventArgs e)
        {
            NumbersClick();
            ItemCount.Text = "Items: " + items.Count();
        }
    }
}