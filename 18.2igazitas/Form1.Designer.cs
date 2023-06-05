namespace _18._2igazitas
{
    partial class btnIgazitas
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
            Igazitas = new Label();
            SuspendLayout();
            // 
            // Igazitas
            // 
            Igazitas.AutoSize = true;
            Igazitas.Location = new Point(337, 55);
            Igazitas.Name = "Igazitas";
            Igazitas.Size = new Size(119, 15);
            Igazitas.TabIndex = 0;
            Igazitas.Text = "Egyek vagy ne egyek!";
            // 
            // btnIgazitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Igazitas);
            Name = "btnIgazitas";
            Text = "Igazítás";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Igazitas;
    }
}