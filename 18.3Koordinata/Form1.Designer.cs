namespace _18._3Koordinata
{
    partial class Koordinata
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
            Frm_Holmozog = new Panel();
            SuspendLayout();
            // 
            // Frm_Holmozog
            // 
            Frm_Holmozog.BackColor = Color.ForestGreen;
            Frm_Holmozog.Location = new Point(277, 115);
            Frm_Holmozog.Name = "Frm_Holmozog";
            Frm_Holmozog.Size = new Size(212, 172);
            Frm_Holmozog.TabIndex = 0;
            Frm_Holmozog.MouseMove += Frm_Holmozog_MouseMove;
            Frm_Holmozog.Resize += Frm_Holmozog_Resize;
            // 
            // Koordinata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Frm_Holmozog);
            Name = "Koordinata";
            Text = "Koordinata";
            ResumeLayout(false);
        }

        #endregion

        private Panel Frm_Holmozog;
    }
}