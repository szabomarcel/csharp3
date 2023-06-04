namespace _18._5es18._6ScrollBat
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
            btnCsuszka = new TrackBar();
            btnPiros = new TrackBar();
            btnZold = new TrackBar();
            btnKek = new TrackBar();
            Lb_Negyzet = new Panel();
            Oldala = new Label();
            ((System.ComponentModel.ISupportInitialize)btnCsuszka).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPiros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnZold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKek).BeginInit();
            SuspendLayout();
            // 
            // btnCsuszka
            // 
            btnCsuszka.Location = new Point(80, 63);
            btnCsuszka.Name = "btnCsuszka";
            btnCsuszka.Size = new Size(621, 45);
            btnCsuszka.TabIndex = 0;
            btnCsuszka.TickStyle = TickStyle.Both;
            btnCsuszka.ValueChanged += btnCsuszka_ValueChanged;
            // 
            // btnPiros
            // 
            btnPiros.Location = new Point(84, 278);
            btnPiros.Name = "btnPiros";
            btnPiros.Size = new Size(623, 45);
            btnPiros.TabIndex = 1;
            btnPiros.TickStyle = TickStyle.Both;
            // 
            // btnZold
            // 
            btnZold.Location = new Point(84, 329);
            btnZold.Name = "btnZold";
            btnZold.Size = new Size(620, 45);
            btnZold.TabIndex = 2;
            btnZold.TickStyle = TickStyle.Both;
            // 
            // btnKek
            // 
            btnKek.Location = new Point(81, 380);
            btnKek.Name = "btnKek";
            btnKek.Size = new Size(620, 45);
            btnKek.TabIndex = 3;
            btnKek.TickStyle = TickStyle.Both;
            // 
            // Lb_Negyzet
            // 
            Lb_Negyzet.Location = new Point(84, 114);
            Lb_Negyzet.Name = "Lb_Negyzet";
            Lb_Negyzet.Size = new Size(617, 156);
            Lb_Negyzet.TabIndex = 4;
            // 
            // Oldala
            // 
            Oldala.AutoSize = true;
            Oldala.Location = new Point(94, 18);
            Oldala.Name = "Oldala";
            Oldala.Size = new Size(59, 15);
            Oldala.TabIndex = 5;
            Oldala.Text = "Oldal: 241";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Oldala);
            Controls.Add(Lb_Negyzet);
            Controls.Add(btnKek);
            Controls.Add(btnZold);
            Controls.Add(btnPiros);
            Controls.Add(btnCsuszka);
            Name = "Form1";
            Text = "ScrollBar";
            ((System.ComponentModel.ISupportInitialize)btnCsuszka).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPiros).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnZold).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar btnCsuszka;
        private TrackBar btnPiros;
        private TrackBar btnZold;
        private TrackBar btnKek;
        private Panel Lb_Negyzet;
        private Label Oldala;
    }
}