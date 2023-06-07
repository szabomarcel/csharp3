using System.Windows.Forms;

namespace _18._11es18._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AdatokFeltolt(int N, int M)
        {
            Random random = new Random();
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            for (int j = 0; j < M; j++)
            {
                dataGridView.Columns.Add(String.Empty, String.Empty);
                dataGridView.Columns[j].Width = 35;
            }
            for (int i = 0; i < N; i++)
            {
                object[] intArrray = new object[M];
                for (int j = 0; j < M; j++)
                {
                    intArrray[j] = random.Next(N * M * 10) + 1;
                }
                dataGridView.Rows.Add(intArrray);
            }
        }
    }
}