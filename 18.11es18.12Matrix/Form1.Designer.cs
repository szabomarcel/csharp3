namespace _18._11es18._12Matrix
{
    partial class Matrix
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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            Oszlop = new Label();
            Sor = new Label();
            label3 = new Label();
            AdatokFeltolt = new Panel();
            Eredmeny = new Label();
            panel2 = new Panel();
            EredmenyKiir = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(439, 27);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(46, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(232, 27);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(46, 23);
            numericUpDown2.TabIndex = 1;
            // 
            // Oszlop
            // 
            Oszlop.AutoSize = true;
            Oszlop.Location = new Point(390, 29);
            Oszlop.Name = "Oszlop";
            Oszlop.Size = new Size(46, 15);
            Oszlop.TabIndex = 2;
            Oszlop.Text = "Oszlop:";
            // 
            // Sor
            // 
            Sor.AutoSize = true;
            Sor.Location = new Point(199, 29);
            Sor.Name = "Sor";
            Sor.Size = new Size(27, 15);
            Sor.TabIndex = 3;
            Sor.Text = "Sor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 31);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 4;
            label3.Text = "Mátrix mérete:";
            // 
            // AdatokFeltolt
            // 
            AdatokFeltolt.BackColor = SystemColors.ControlDark;
            AdatokFeltolt.Location = new Point(12, 75);
            AdatokFeltolt.Name = "AdatokFeltolt";
            AdatokFeltolt.Size = new Size(509, 363);
            AdatokFeltolt.TabIndex = 5;
            AdatokFeltolt.Click += AdatokFeltolt_Click;
            // 
            // Eredmeny
            // 
            Eredmeny.AutoSize = true;
            Eredmeny.Location = new Point(539, 93);
            Eredmeny.Name = "Eredmeny";
            Eredmeny.Size = new Size(75, 15);
            Eredmeny.TabIndex = 6;
            Eredmeny.Text = "Eredmények:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(539, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 327);
            panel2.TabIndex = 7;
            // 
            // EredmenyKiir
            // 
            EredmenyKiir.Location = new Point(611, 48);
            EredmenyKiir.Name = "EredmenyKiir";
            EredmenyKiir.Size = new Size(75, 23);
            EredmenyKiir.TabIndex = 8;
            EredmenyKiir.Text = "Mehet";
            EredmenyKiir.UseVisualStyleBackColor = true;
            EredmenyKiir.SystemColorsChanged += EredmenyKiir_SystemColorsChanged;
            // 
            // Matrix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EredmenyKiir);
            Controls.Add(panel2);
            Controls.Add(Eredmeny);
            Controls.Add(AdatokFeltolt);
            Controls.Add(label3);
            Controls.Add(Sor);
            Controls.Add(Oszlop);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Name = "Matrix";
            Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label Oszlop;
        private Label Sor;
        private Label label3;
        private Panel AdatokFeltolt;
        private Label Eredmeny;
        private Panel panel2;
        private Button EredmenyKiir;
    }
}