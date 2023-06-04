namespace _18._7Komponens
{
    partial class Komponensek
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
            Szoveg.BackColor = Color.CornflowerBlue;
            Szoveg.Location = new Point(195, 9);
            Szoveg.Name = "Szoveg";
            Szoveg.Size = new Size(450, 34);
            Szoveg.TabIndex = 0;
            Szoveg.Text = "Kattints az üres területen! Létrejön egy új címke, rajta 1 és 100 közötti szám. Összeg: 361,  átlag: 45.125, minimum: 214748367, maximum:- 214748368";
            // 
            // Komponensek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Szoveg);
            Name = "Komponensek";
            Text = "Komponensek";
            ResumeLayout(false);
        }

        #endregion

        private Label Szoveg;
    }
}