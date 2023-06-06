namespace _18._5es18._6ScrollBar
{
    partial class ScrollBar
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
            Panel1 = new Label();
            Oldal = new TrackBar();
            SB_Piros = new TrackBar();
            SB_Zold = new TrackBar();
            SB_Kek = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)Oldal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SB_Piros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SB_Zold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SB_Kek).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.AutoSize = true;
            Panel1.Location = new Point(109, 86);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(50, 15);
            Panel1.TabIndex = 0;
            Panel1.Text = "Színezés";
            // 
            // Oldal
            // 
            Oldal.Location = new Point(109, 27);
            Oldal.Name = "Oldal";
            Oldal.Size = new Size(590, 45);
            Oldal.TabIndex = 1;
            Oldal.TickStyle = TickStyle.Both;
            Oldal.ValueChanged += Oldal_ValueChanged;
            // 
            // SB_Piros
            // 
            SB_Piros.Location = new Point(109, 172);
            SB_Piros.Name = "SB_Piros";
            SB_Piros.Size = new Size(590, 45);
            SB_Piros.TabIndex = 2;
            SB_Piros.TickStyle = TickStyle.Both;
            SB_Piros.ValueChanged += SB_Piros_ValueChanged;
            // 
            // SB_Zold
            // 
            SB_Zold.Location = new Point(109, 251);
            SB_Zold.Name = "SB_Zold";
            SB_Zold.Size = new Size(590, 45);
            SB_Zold.TabIndex = 3;
            SB_Zold.TickStyle = TickStyle.Both;
            SB_Zold.ValueChanged += SB_Zold_ValueChanged;
            // 
            // SB_Kek
            // 
            SB_Kek.Location = new Point(109, 332);
            SB_Kek.Name = "SB_Kek";
            SB_Kek.Size = new Size(590, 45);
            SB_Kek.TabIndex = 4;
            SB_Kek.TickStyle = TickStyle.Both;
            SB_Kek.ValueChanged += SB_Kek_ValueChanged;
            // 
            // ScrollBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SB_Kek);
            Controls.Add(SB_Zold);
            Controls.Add(SB_Piros);
            Controls.Add(Oldal);
            Controls.Add(Panel1);
            Name = "ScrollBar";
            Text = "SrcollBar";
            ((System.ComponentModel.ISupportInitialize)Oldal).EndInit();
            ((System.ComponentModel.ISupportInitialize)SB_Piros).EndInit();
            ((System.ComponentModel.ISupportInitialize)SB_Zold).EndInit();
            ((System.ComponentModel.ISupportInitialize)SB_Kek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Panel1;
        private TrackBar Oldal;
        private TrackBar SB_Piros;
        private TrackBar SB_Zold;
        private TrackBar SB_Kek;
    }
}