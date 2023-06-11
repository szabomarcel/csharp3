namespace _18._13es18._14es18._15Szorzotabla
{
    public partial class Szorzotabla : Form
    {
        Random random = new Random();
        public Szorzotabla()
        {
            InitializeComponent();
        }
        private void Sorsol()
        {
            do
            {
                aktI = random.Next(N) + 1;
                aktJ = random.Next(N) + 1;
            }
            while (dataGridView[aktJ, aktI].Value != null);
            dataGridView[aktJ, aktI].Style.BackColor =
                dataGridView[0, aktI].Style.BackColor =
                dataGridView[aktJ, 0].Style.BackColor = Color.PowderBlue;
        }
        private void TablaEpit()
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Width = 35 * (N + 1) + 3;
            for (int j = 0; j <= N; j++)
            {
                dataGridView.Columns.Add(String.Empty, String.Empty);
                dataGridView.Columns[j].Width = 35;
            }
            for (int i = 0; i <= N; i++)
            {
                object[] intArrray = new object[N];
                dataGridView.Rows.Add(intArrray);
            }
            for (int i = 1; i <= N; i++)
            {
                dataGridView[i, 0].Value = i;
                dataGridView[i, 0].Style.Font = new Font(dataGridView.Font, FontStyle.Bold);
            }
            for (int j = 1; j <= N; j++)
            {
                dataGridView[j, 0].Value = j;
                dataGridView[j, 0].Style.Font = new Font(dataGridView.Font, FontStyle.Bold);
            }
        }
        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView[aktJ, aktI].Value == null) return;
            if (aktI * aktJ == Convert.ToInt32(dataGridView[aktJ, aktI].Value))
            {
                dataGridView[aktJ, aktI].Style.BackColor =
          dataGridView.DefaultCellStyle.BackColor;
                dataGridView[0, aktI].Style.BackColor =
                   dataGridView[aktJ, 0].Style.BackColor =
                   dataGridView.DefaultCellStyle.BackColor;
                joValasz++;
                lb_Joalasz.Text = String.Format("J� v�laszaid sz�ma: {0}",
                                        joValasz);
                if (joValasz < N * N)
                { Sorsol(); }
                else
                {
                    MessageBox.Show("Gratul�lok, k�sz a szorz�t�bla!");
                    dataGridView.Enabled = false;
                }
            }
            else
            {
                dataGridView[aktJ, aktI].Value = null;
                rosszValasz++;
                lb_Rosszvalasz.Text = String.Format("Rossz v�laszaid sz�ma:"
                                           + "{0}", rosszValasz);
                MessageBox.Show("Rossz v�lasz!");
            }
        }
    }
}
}