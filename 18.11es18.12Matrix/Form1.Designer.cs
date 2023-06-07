namespace _18._11es18._12
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
            dataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            richTextBox = new RichTextBox();
            N = new NumericUpDown();
            M = new NumericUpDown();
            AdatFeltolt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)N).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 98);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(453, 340);
            dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 62);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "A mátrix méretei:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 62);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "Sor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 62);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Oszlop:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(511, 98);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 4;
            label4.Text = "Eredmény:";
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(511, 116);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(177, 322);
            richTextBox.TabIndex = 5;
            richTextBox.Text = "";
            // 
            // N
            // 
            N.Location = new Point(328, 60);
            N.Name = "N";
            N.Size = new Size(56, 23);
            N.TabIndex = 6;
            // 
            // M
            // 
            M.Location = new Point(471, 60);
            M.Name = "M";
            M.Size = new Size(56, 23);
            M.TabIndex = 7;
            // 
            // AdatFeltolt
            // 
            AdatFeltolt.BackColor = Color.Cornsilk;
            AdatFeltolt.Location = new Point(589, 65);
            AdatFeltolt.Name = "AdatFeltolt";
            AdatFeltolt.Size = new Size(75, 23);
            AdatFeltolt.TabIndex = 8;
            AdatFeltolt.Text = "Mehet";
            AdatFeltolt.UseVisualStyleBackColor = false;
            AdatFeltolt.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AdatFeltolt);
            Controls.Add(M);
            Controls.Add(N);
            Controls.Add(richTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)N).EndInit();
            ((System.ComponentModel.ISupportInitialize)M).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox;
        private NumericUpDown N;
        private NumericUpDown M;
        private Button AdatFeltolt;
    }
}