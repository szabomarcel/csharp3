namespace _18._9es18._10Halmazok
{
    partial class Halmazok
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
            label1 = new Label();
            Eloallit = new Button();
            Halmazgeneral = new TextBox();
            Bennevan = new TextBox();
            LBx_A = new ListBox();
            LBx_B = new ListBox();
            LBx_Unio = new ListBox();
            LBx_Metsz = new ListBox();
            LBx_A_B = new ListBox();
            LBx_B_A = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 352);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Halmazok elemszáma:";
            // 
            // Eloallit
            // 
            Eloallit.Location = new Point(501, 375);
            Eloallit.Name = "Eloallit";
            Eloallit.Size = new Size(75, 23);
            Eloallit.TabIndex = 1;
            Eloallit.Text = "Előállít";
            Eloallit.UseVisualStyleBackColor = true;
            Eloallit.Click += Eloallit_Click;
            // 
            // Halmazgeneral
            // 
            Halmazgeneral.Location = new Point(81, 394);
            Halmazgeneral.Name = "Halmazgeneral";
            Halmazgeneral.Size = new Size(100, 23);
            Halmazgeneral.TabIndex = 2;
            // 
            // Bennevan
            // 
            Bennevan.Location = new Point(208, 394);
            Bennevan.Name = "Bennevan";
            Bennevan.Size = new Size(100, 23);
            Bennevan.TabIndex = 3;
            // 
            // LBx_A
            // 
            LBx_A.FormattingEnabled = true;
            LBx_A.ItemHeight = 15;
            LBx_A.Location = new Point(81, 54);
            LBx_A.Name = "LBx_A";
            LBx_A.Size = new Size(100, 274);
            LBx_A.TabIndex = 4;
            // 
            // LBx_B
            // 
            LBx_B.FormattingEnabled = true;
            LBx_B.ItemHeight = 15;
            LBx_B.Location = new Point(187, 54);
            LBx_B.Name = "LBx_B";
            LBx_B.Size = new Size(100, 274);
            LBx_B.TabIndex = 5;
            // 
            // LBx_Unio
            // 
            LBx_Unio.FormattingEnabled = true;
            LBx_Unio.ItemHeight = 15;
            LBx_Unio.Location = new Point(293, 54);
            LBx_Unio.Name = "LBx_Unio";
            LBx_Unio.Size = new Size(100, 274);
            LBx_Unio.TabIndex = 6;
            // 
            // LBx_Metsz
            // 
            LBx_Metsz.FormattingEnabled = true;
            LBx_Metsz.ItemHeight = 15;
            LBx_Metsz.Location = new Point(399, 54);
            LBx_Metsz.Name = "LBx_Metsz";
            LBx_Metsz.Size = new Size(100, 274);
            LBx_Metsz.TabIndex = 7;
            // 
            // LBx_A_B
            // 
            LBx_A_B.FormattingEnabled = true;
            LBx_A_B.ItemHeight = 15;
            LBx_A_B.Location = new Point(505, 54);
            LBx_A_B.Name = "LBx_A_B";
            LBx_A_B.Size = new Size(100, 274);
            LBx_A_B.TabIndex = 8;
            // 
            // LBx_B_A
            // 
            LBx_B_A.FormattingEnabled = true;
            LBx_B_A.ItemHeight = 15;
            LBx_B_A.Location = new Point(611, 54);
            LBx_B_A.Name = "LBx_B_A";
            LBx_B_A.Size = new Size(100, 274);
            LBx_B_A.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 22);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 10;
            label2.Text = "A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 22);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 11;
            label3.Text = "B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 22);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 12;
            label4.Text = "A unio B:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(400, 22);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 13;
            label5.Text = "A metszet B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(502, 22);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 14;
            label6.Text = "A-B";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(612, 22);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 15;
            label7.Text = "B-A";
            // 
            // Halmazok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LBx_B_A);
            Controls.Add(LBx_A_B);
            Controls.Add(LBx_Metsz);
            Controls.Add(LBx_Unio);
            Controls.Add(LBx_B);
            Controls.Add(LBx_A);
            Controls.Add(Bennevan);
            Controls.Add(Halmazgeneral);
            Controls.Add(Eloallit);
            Controls.Add(label1);
            Name = "Halmazok";
            Text = "Halmazok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Eloallit;
        private TextBox Halmazgeneral;
        private TextBox Bennevan;
        private ListBox LBx_A;
        private ListBox LBx_B;
        private ListBox LBx_Unio;
        private ListBox LBx_Metsz;
        private ListBox LBx_A_B;
        private ListBox LBx_B_A;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}