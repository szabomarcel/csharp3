namespace Playing_Sounds
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
            duelStateButton = new CheckBox();
            SuspendLayout();
            // 
            // duelStateButton
            // 
            duelStateButton.Appearance = Appearance.Button;
            duelStateButton.Location = new Point(319, 128);
            duelStateButton.Name = "duelStateButton";
            duelStateButton.Size = new Size(185, 145);
            duelStateButton.TabIndex = 0;
            duelStateButton.Text = "Play";
            duelStateButton.TextAlign = ContentAlignment.MiddleCenter;
            duelStateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(duelStateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CheckBox duelStateButton;
    }
}