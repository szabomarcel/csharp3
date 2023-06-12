namespace _18._5es18._6ScrollBar
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
            this.Sb_Kek = new System.Windows.Forms.HScrollBar();
            this.Sb_Piros = new System.Windows.Forms.HScrollBar();
            this.Sb_Zold = new System.Windows.Forms.HScrollBar();
            this.Sb_Oldal = new System.Windows.Forms.HScrollBar();
            this.Lb_Negyzet = new System.Windows.Forms.Label();
            this.Lb_Oldal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sb_Kek
            // 
            this.Sb_Kek.Location = new System.Drawing.Point(267, 341);
            this.Sb_Kek.Maximum = 255;
            this.Sb_Kek.Name = "Sb_Kek";
            this.Sb_Kek.Size = new System.Drawing.Size(242, 22);
            this.Sb_Kek.TabIndex = 0;
            this.Sb_Kek.ValueChanged += new System.EventHandler(this.Sb_Kek_ValueChanged);
            // 
            // Sb_Piros
            // 
            this.Sb_Piros.Location = new System.Drawing.Point(267, 272);
            this.Sb_Piros.Maximum = 255;
            this.Sb_Piros.Name = "Sb_Piros";
            this.Sb_Piros.Size = new System.Drawing.Size(242, 22);
            this.Sb_Piros.TabIndex = 1;
            this.Sb_Piros.ValueChanged += new System.EventHandler(this.Sb_Piros_ValueChanged);
            // 
            // Sb_Zold
            // 
            this.Sb_Zold.Location = new System.Drawing.Point(267, 307);
            this.Sb_Zold.Maximum = 255;
            this.Sb_Zold.Name = "Sb_Zold";
            this.Sb_Zold.Size = new System.Drawing.Size(242, 22);
            this.Sb_Zold.TabIndex = 2;
            this.Sb_Zold.ValueChanged += new System.EventHandler(this.Sb_Zold_ValueChanged);
            // 
            // Sb_Oldal
            // 
            this.Sb_Oldal.Location = new System.Drawing.Point(267, 48);
            this.Sb_Oldal.Name = "Sb_Oldal";
            this.Sb_Oldal.Size = new System.Drawing.Size(253, 22);
            this.Sb_Oldal.TabIndex = 3;
            this.Sb_Oldal.ValueChanged += new System.EventHandler(this.Sb_Oldal_ValueChanged);
            // 
            // Lb_Negyzet
            // 
            this.Lb_Negyzet.BackColor = System.Drawing.SystemColors.ControlText;
            this.Lb_Negyzet.Location = new System.Drawing.Point(294, 108);
            this.Lb_Negyzet.Name = "Lb_Negyzet";
            this.Lb_Negyzet.Size = new System.Drawing.Size(156, 137);
            this.Lb_Negyzet.TabIndex = 4;
            // 
            // Lb_Oldal
            // 
            this.Lb_Oldal.Location = new System.Drawing.Point(435, 20);
            this.Lb_Oldal.Name = "Lb_Oldal";
            this.Lb_Oldal.Size = new System.Drawing.Size(38, 15);
            this.Lb_Oldal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "A négyzet oldala:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lb_Oldal);
            this.Controls.Add(this.Lb_Negyzet);
            this.Controls.Add(this.Sb_Oldal);
            this.Controls.Add(this.Sb_Zold);
            this.Controls.Add(this.Sb_Piros);
            this.Controls.Add(this.Sb_Kek);
            this.Name = "Form1";
            this.Text = "ScrollBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HScrollBar Sb_Kek;
        private HScrollBar Sb_Piros;
        private HScrollBar Sb_Zold;
        private HScrollBar Sb_Oldal;
        private Label Lb_Negyzet;
        private Label Lb_Oldal;
        private Label label2;
    }
}