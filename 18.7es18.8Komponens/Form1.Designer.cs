namespace _18._7es18._8Komponens
{
    partial class Frm_Dinamikus
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
            Szoveg = new Label();
            SuspendLayout();
            // 
            // Szoveg
            // 
            Szoveg.AutoSize = true;
            Szoveg.BackColor = Color.CornflowerBlue;
            Szoveg.Location = new Point(2, 9);
            Szoveg.Name = "Szoveg";
            Szoveg.Size = new Size(795, 15);
            Szoveg.TabIndex = 0;
            Szoveg.Text = "Ez egy üres terület! Létrejön egy új címke, rajta egy 1 és 100 közötti szám. Az összeg: 361, átlag: 45.125, minimum: 2147483637, minimum: -2147483638.";
            // 
            // Frm_Dinamikus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Szoveg);
            Name = "Frm_Dinamikus";
            Text = "Komponens";
            MouseClick += Frm_Dinamikus_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Szoveg;
    }
}