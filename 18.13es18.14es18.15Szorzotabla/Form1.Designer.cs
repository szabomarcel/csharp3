namespace _18._13es18._14es18._15Szorzotabla
{
    partial class Szorzotabla
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            aktJ = new Label();
            aktI = new Label();
            btnKilepes = new Button();
            N = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(776, 330);
            dataGridView.TabIndex = 0;
            // 
            // aktJ
            // 
            aktJ.AutoSize = true;
            aktJ.Location = new Point(30, 360);
            aktJ.Name = "aktJ";
            aktJ.Size = new Size(107, 15);
            aktJ.TabIndex = 1;
            aktJ.Text = "Jó válaszaid száma:";
            // 
            // aktI
            // 
            aktI.AutoSize = true;
            aktI.Location = new Point(30, 387);
            aktI.Name = "aktI";
            aktI.Size = new Size(128, 15);
            aktI.TabIndex = 2;
            aktI.Text = "Rossz válaszaid száma: ";
            // 
            // btnKilepes
            // 
            btnKilepes.Location = new Point(30, 415);
            btnKilepes.Name = "btnKilepes";
            btnKilepes.Size = new Size(75, 23);
            btnKilepes.TabIndex = 3;
            btnKilepes.Text = "Kilépés";
            btnKilepes.UseVisualStyleBackColor = true;
            // 
            // N
            // 
            N.Location = new Point(478, 348);
            N.Name = "N";
            N.Size = new Size(135, 90);
            N.TabIndex = 4;
            N.Text = "";
            // 
            // Szorzotabla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(N);
            Controls.Add(btnKilepes);
            Controls.Add(aktI);
            Controls.Add(aktJ);
            Controls.Add(dataGridView);
            Name = "Szorzotabla";
            Text = "Szorzótábla";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label aktJ;
        private Label aktI;
        private Button btnKilepes;
        private RichTextBox N;
    }
}