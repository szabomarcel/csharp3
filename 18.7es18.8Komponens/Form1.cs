namespace _18._7es18._8Komponens
{
    public partial class Frm_Dinamikus : Form
    {
        Random random = new Random();
        double atlag; int osszeg, db, min = int.MaxValue, max = int.MinValue;
        public Frm_Dinamikus()
        {
            InitializeComponent();
        }

        private void Frm_Dinamikus_MouseClick(object sender, MouseEventArgs e)
        {
            int i = random.Next(100) + 1;
            Label lb = new Label();
            lb.Location = new Point(e.X, e.Y);
            lb.Text = i.ToString();
            lb.AutoSize = true;
            Controls.Add(lb);
            db++;
            osszeg += i;
            atlag = osszeg / (double)db;
            if(min > i) min = i;
            if(max < i) max = i;
            Szoveg.Text = String.Format("Darabszám: {0}, összeg: {1}, átlag: {2}," + "minimum: {3}, maximum: {4}.", db, osszeg, atlag, min, max);
        }
    }
}