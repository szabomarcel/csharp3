namespace _18._11es18._12Matrix
{
    partial class Szoveg
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
            Adatfeltolt = new Button();
            SzovegMatrix = new Label();
            N = new NumericUpDown();
            richTextBox = new RichTextBox();
            dataGridView = new DataGridView();
            Sor = new Label();
            Oszlop = new Label();
            Eredmény = new Label();
            M = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)N).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M).BeginInit();
            SuspendLayout();
            // 
            // Adatfeltolt
            // 
            Adatfeltolt.Location = new Point(546, 81);
            Adatfeltolt.Name = "Adatfeltolt";
            Adatfeltolt.Size = new Size(75, 23);
            Adatfeltolt.TabIndex = 0;
            Adatfeltolt.Text = "Mehet";
            Adatfeltolt.UseVisualStyleBackColor = true;
            // 
            // SzovegMatrix
            // 
            SzovegMatrix.AutoSize = true;
            SzovegMatrix.Location = new Point(167, 57);
            SzovegMatrix.Name = "SzovegMatrix";
            SzovegMatrix.Size = new Size(84, 15);
            SzovegMatrix.TabIndex = 1;
            SzovegMatrix.Text = "Mátrix mérete:";
            // 
            // N
            // 
            N.Location = new Point(330, 55);
            N.Name = "N";
            N.Size = new Size(42, 23);
            N.TabIndex = 2;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(546, 148);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(148, 259);
            richTextBox.TabIndex = 3;
            richTextBox.Text = "";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(44, 119);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(460, 288);
            dataGridView.TabIndex = 4;
            // 
            // Sor
            // 
            Sor.AutoSize = true;
            Sor.Location = new Point(297, 57);
            Sor.Name = "Sor";
            Sor.Size = new Size(27, 15);
            Sor.TabIndex = 5;
            Sor.Text = "Sor:";
            // 
            // Oszlop
            // 
            Oszlop.AutoSize = true;
            Oszlop.Location = new Point(410, 57);
            Oszlop.Name = "Oszlop";
            Oszlop.Size = new Size(46, 15);
            Oszlop.TabIndex = 6;
            Oszlop.Text = "Oszlop:";
            // 
            // Eredmény
            // 
            Eredmény.AutoSize = true;
            Eredmény.Location = new Point(546, 119);
            Eredmény.Name = "Eredmény";
            Eredmény.Size = new Size(63, 15);
            Eredmény.TabIndex = 7;
            Eredmény.Text = "Eredmény:";
            // 
            // M
            // 
            M.Location = new Point(462, 55);
            M.Name = "M";
            M.Size = new Size(42, 23);
            M.TabIndex = 8;
            // 
            // Szoveg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(M);
            Controls.Add(Eredmény);
            Controls.Add(Oszlop);
            Controls.Add(Sor);
            Controls.Add(dataGridView);
            Controls.Add(richTextBox);
            Controls.Add(N);
            Controls.Add(SzovegMatrix);
            Controls.Add(Adatfeltolt);
            Name = "Szoveg";
            Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)N).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)M).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Adatfeltolt;
        private Label SzovegMatrix;
        private NumericUpDown N;
        private RichTextBox richTextBox;
        private DataGridView dataGridView;
        private Label Sor;
        private Label Oszlop;
        private Label Eredmény;
        private NumericUpDown M;
    }
}