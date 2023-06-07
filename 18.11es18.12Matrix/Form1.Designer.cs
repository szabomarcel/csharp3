namespace _18._11es18._12Matrix
{
    partial class Form1
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
            AdatokFeltolt = new Button();
            label1 = new Label();
            Szoveg = new Label();
            Szoveg1 = new Label();
            EredmenyKiir = new Label();
            N = new NumericUpDown();
            M = new NumericUpDown();
            dataGridView = new DataGridView();
            richTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)N).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // AdatokFeltolt
            // 
            AdatokFeltolt.Location = new Point(511, 75);
            AdatokFeltolt.Name = "AdatokFeltolt";
            AdatokFeltolt.Size = new Size(75, 23);
            AdatokFeltolt.TabIndex = 0;
            AdatokFeltolt.Text = "Mehet";
            AdatokFeltolt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 75);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "A mátrix mérete:";
            // 
            // Szoveg
            // 
            Szoveg.AutoSize = true;
            Szoveg.Location = new Point(272, 75);
            Szoveg.Name = "Szoveg";
            Szoveg.Size = new Size(27, 15);
            Szoveg.TabIndex = 2;
            Szoveg.Text = "Sor:";
            // 
            // Szoveg1
            // 
            Szoveg1.AutoSize = true;
            Szoveg1.Location = new Point(381, 75);
            Szoveg1.Name = "Szoveg1";
            Szoveg1.Size = new Size(46, 15);
            Szoveg1.TabIndex = 3;
            Szoveg1.Text = "Oszlop:";
            // 
            // EredmenyKiir
            // 
            EredmenyKiir.AutoSize = true;
            EredmenyKiir.Location = new Point(530, 133);
            EredmenyKiir.Name = "EredmenyKiir";
            EredmenyKiir.Size = new Size(56, 15);
            EredmenyKiir.TabIndex = 4;
            EredmenyKiir.Text = "Eremény:";
            // 
            // N
            // 
            N.Location = new Point(305, 73);
            N.Name = "N";
            N.Size = new Size(38, 23);
            N.TabIndex = 5;
            // 
            // M
            // 
            M.Location = new Point(425, 73);
            M.Name = "M";
            M.Size = new Size(38, 23);
            M.TabIndex = 6;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 102);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(464, 327);
            dataGridView.TabIndex = 7;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(530, 160);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(179, 269);
            richTextBox.TabIndex = 8;
            richTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Controls.Add(dataGridView);
            Controls.Add(M);
            Controls.Add(N);
            Controls.Add(EredmenyKiir);
            Controls.Add(Szoveg1);
            Controls.Add(Szoveg);
            Controls.Add(label1);
            Controls.Add(AdatokFeltolt);
            Name = "Form1";
            Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)N).EndInit();
            ((System.ComponentModel.ISupportInitialize)M).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AdatokFeltolt;
        private Label label1;
        private Label Szoveg;
        private Label Szoveg1;
        private Label EredmenyKiir;
        private NumericUpDown N;
        private NumericUpDown M;
        private DataGridView dataGridView;
        private RichTextBox richTextBox;
    }
}