﻿namespace _18._9es18._10Halmazok
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
            this.TBx_A = new System.Windows.Forms.TextBox();
            this.TBx_B = new System.Windows.Forms.TextBox();
            this.Eloallit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LBx_A = new System.Windows.Forms.ListBox();
            this.LBx_B = new System.Windows.Forms.ListBox();
            this.LBx_Unio = new System.Windows.Forms.ListBox();
            this.LBx_Metsz = new System.Windows.Forms.ListBox();
            this.LBx_A_B = new System.Windows.Forms.ListBox();
            this.LBx_B_A = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TBx_A
            // 
            this.TBx_A.Location = new System.Drawing.Point(177, 402);
            this.TBx_A.Name = "TBx_A";
            this.TBx_A.Size = new System.Drawing.Size(65, 23);
            this.TBx_A.TabIndex = 0;
            // 
            // TBx_B
            // 
            this.TBx_B.Location = new System.Drawing.Point(249, 402);
            this.TBx_B.Name = "TBx_B";
            this.TBx_B.Size = new System.Drawing.Size(70, 23);
            this.TBx_B.TabIndex = 1;
            // 
            // Eloallit
            // 
            this.Eloallit.Location = new System.Drawing.Point(338, 401);
            this.Eloallit.Name = "Eloallit";
            this.Eloallit.Size = new System.Drawing.Size(75, 23);
            this.Eloallit.TabIndex = 2;
            this.Eloallit.Text = "Előállít";
            this.Eloallit.UseVisualStyleBackColor = true;
            this.Eloallit.Click += new System.EventHandler(this.Eloallit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "A unio B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "A metszet B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "A-B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "B-A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Halmazok elemszáma:";
            // 
            // LBx_A
            // 
            this.LBx_A.FormattingEnabled = true;
            this.LBx_A.ItemHeight = 15;
            this.LBx_A.Location = new System.Drawing.Point(37, 92);
            this.LBx_A.Name = "LBx_A";
            this.LBx_A.Size = new System.Drawing.Size(110, 229);
            this.LBx_A.TabIndex = 12;
            // 
            // LBx_B
            // 
            this.LBx_B.FormattingEnabled = true;
            this.LBx_B.ItemHeight = 15;
            this.LBx_B.Location = new System.Drawing.Point(159, 92);
            this.LBx_B.Name = "LBx_B";
            this.LBx_B.Size = new System.Drawing.Size(110, 229);
            this.LBx_B.TabIndex = 13;
            // 
            // LBx_Unio
            // 
            this.LBx_Unio.FormattingEnabled = true;
            this.LBx_Unio.ItemHeight = 15;
            this.LBx_Unio.Location = new System.Drawing.Point(281, 92);
            this.LBx_Unio.Name = "LBx_Unio";
            this.LBx_Unio.Size = new System.Drawing.Size(110, 229);
            this.LBx_Unio.TabIndex = 14;
            // 
            // LBx_Metsz
            // 
            this.LBx_Metsz.FormattingEnabled = true;
            this.LBx_Metsz.ItemHeight = 15;
            this.LBx_Metsz.Location = new System.Drawing.Point(403, 92);
            this.LBx_Metsz.Name = "LBx_Metsz";
            this.LBx_Metsz.Size = new System.Drawing.Size(110, 229);
            this.LBx_Metsz.TabIndex = 15;
            // 
            // LBx_A_B
            // 
            this.LBx_A_B.FormattingEnabled = true;
            this.LBx_A_B.ItemHeight = 15;
            this.LBx_A_B.Location = new System.Drawing.Point(525, 92);
            this.LBx_A_B.Name = "LBx_A_B";
            this.LBx_A_B.Size = new System.Drawing.Size(110, 229);
            this.LBx_A_B.TabIndex = 16;
            // 
            // LBx_B_A
            // 
            this.LBx_B_A.FormattingEnabled = true;
            this.LBx_B_A.ItemHeight = 15;
            this.LBx_B_A.Location = new System.Drawing.Point(647, 92);
            this.LBx_B_A.Name = "LBx_B_A";
            this.LBx_B_A.Size = new System.Drawing.Size(110, 229);
            this.LBx_B_A.TabIndex = 17;
            // 
            // Szoveg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBx_B_A);
            this.Controls.Add(this.LBx_A_B);
            this.Controls.Add(this.LBx_Metsz);
            this.Controls.Add(this.LBx_Unio);
            this.Controls.Add(this.LBx_B);
            this.Controls.Add(this.LBx_A);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eloallit);
            this.Controls.Add(this.TBx_B);
            this.Controls.Add(this.TBx_A);
            this.Name = "Szoveg";
            this.Text = "Halmazok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TBx_A;
        private TextBox TBx_B;
        private Button Eloallit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox LBx_A;
        private ListBox LBx_B;
        private ListBox LBx_Unio;
        private ListBox LBx_Metsz;
        private ListBox LBx_A_B;
        private ListBox LBx_B_A;
    }
}