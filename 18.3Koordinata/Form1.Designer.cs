namespace _18._3Koordinata
{
    partial class Frm_Holmozog
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
            this.Holmozog = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Holmozog
            // 
            this.Holmozog.BackColor = System.Drawing.Color.Lime;
            this.Holmozog.Location = new System.Drawing.Point(195, 99);
            this.Holmozog.Name = "Holmozog";
            this.Holmozog.Size = new System.Drawing.Size(200, 106);
            this.Holmozog.TabIndex = 0;
            // 
            // Frm_Holmozog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Holmozog);
            this.Name = "Frm_Holmozog";
            this.Text = "Koordinátái X:90, Y:68 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelIgazit_MouseMove);
            this.Resize += new System.EventHandler(this.PanelIgazit_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Holmozog;
    }
}