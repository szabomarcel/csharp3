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
            this.Adatfeltolt = new System.Windows.Forms.Button();
            this.SzovegMatrix = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Sor = new System.Windows.Forms.Label();
            this.Oszlop = new System.Windows.Forms.Label();
            this.Eredmény = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M)).BeginInit();
            this.SuspendLayout();
            // 
            // Adatfeltolt
            // 
            this.Adatfeltolt.Location = new System.Drawing.Point(546, 81);
            this.Adatfeltolt.Name = "Adatfeltolt";
            this.Adatfeltolt.Size = new System.Drawing.Size(75, 23);
            this.Adatfeltolt.TabIndex = 0;
            this.Adatfeltolt.Text = "Mehet";
            this.Adatfeltolt.UseVisualStyleBackColor = true;
            this.Adatfeltolt.Click += new System.EventHandler(this.Adatfeltolt_Click);
            // 
            // SzovegMatrix
            // 
            this.SzovegMatrix.AutoSize = true;
            this.SzovegMatrix.Location = new System.Drawing.Point(167, 57);
            this.SzovegMatrix.Name = "SzovegMatrix";
            this.SzovegMatrix.Size = new System.Drawing.Size(84, 15);
            this.SzovegMatrix.TabIndex = 1;
            this.SzovegMatrix.Text = "Mátrix mérete:";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(330, 55);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(42, 23);
            this.N.TabIndex = 2;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(546, 148);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(148, 259);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(44, 119);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(460, 288);
            this.dataGridView.TabIndex = 4;
            // 
            // Sor
            // 
            this.Sor.AutoSize = true;
            this.Sor.Location = new System.Drawing.Point(297, 57);
            this.Sor.Name = "Sor";
            this.Sor.Size = new System.Drawing.Size(27, 15);
            this.Sor.TabIndex = 5;
            this.Sor.Text = "Sor:";
            // 
            // Oszlop
            // 
            this.Oszlop.AutoSize = true;
            this.Oszlop.Location = new System.Drawing.Point(410, 57);
            this.Oszlop.Name = "Oszlop";
            this.Oszlop.Size = new System.Drawing.Size(46, 15);
            this.Oszlop.TabIndex = 6;
            this.Oszlop.Text = "Oszlop:";
            // 
            // Eredmény
            // 
            this.Eredmény.AutoSize = true;
            this.Eredmény.Location = new System.Drawing.Point(546, 119);
            this.Eredmény.Name = "Eredmény";
            this.Eredmény.Size = new System.Drawing.Size(63, 15);
            this.Eredmény.TabIndex = 7;
            this.Eredmény.Text = "Eredmény:";
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(462, 55);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(42, 23);
            this.M.TabIndex = 8;
            // 
            // Szoveg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.M);
            this.Controls.Add(this.Eredmény);
            this.Controls.Add(this.Oszlop);
            this.Controls.Add(this.Sor);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.N);
            this.Controls.Add(this.SzovegMatrix);
            this.Controls.Add(this.Adatfeltolt);
            this.Name = "Szoveg";
            this.Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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