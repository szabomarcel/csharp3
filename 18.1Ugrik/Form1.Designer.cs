namespace _18._1Ugrik
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
            this.btnBalrafel = new System.Windows.Forms.Button();
            this.btnJobbrafel = new System.Windows.Forms.Button();
            this.jobbrale = new System.Windows.Forms.Button();
            this.btnBalrale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBalrafel
            // 
            this.btnBalrafel.BackColor = System.Drawing.Color.Tan;
            this.btnBalrafel.Location = new System.Drawing.Point(152, 46);
            this.btnBalrafel.Name = "btnBalrafel";
            this.btnBalrafel.Size = new System.Drawing.Size(75, 23);
            this.btnBalrafel.TabIndex = 0;
            this.btnBalrafel.Text = "Balra fel";
            this.btnBalrafel.UseVisualStyleBackColor = false;
            this.btnBalrafel.Click += new System.EventHandler(this.btnBalrafel_Click);
            // 
            // btnJobbrafel
            // 
            this.btnJobbrafel.BackColor = System.Drawing.Color.Tan;
            this.btnJobbrafel.Location = new System.Drawing.Point(369, 46);
            this.btnJobbrafel.Name = "btnJobbrafel";
            this.btnJobbrafel.Size = new System.Drawing.Size(75, 23);
            this.btnJobbrafel.TabIndex = 0;
            this.btnJobbrafel.Text = "Jobbra fel";
            this.btnJobbrafel.UseVisualStyleBackColor = false;
            this.btnJobbrafel.Click += new System.EventHandler(this.btnJobbrafel_Click);
            // 
            // jobbrale
            // 
            this.jobbrale.BackColor = System.Drawing.Color.Tan;
            this.jobbrale.Location = new System.Drawing.Point(369, 129);
            this.jobbrale.Name = "jobbrale";
            this.jobbrale.Size = new System.Drawing.Size(75, 23);
            this.jobbrale.TabIndex = 0;
            this.jobbrale.Text = "Jobbra fel";
            this.jobbrale.UseVisualStyleBackColor = false;
            this.jobbrale.Click += new System.EventHandler(this.jobbrale_Click);
            // 
            // btnBalrale
            // 
            this.btnBalrale.BackColor = System.Drawing.Color.Tan;
            this.btnBalrale.Location = new System.Drawing.Point(152, 129);
            this.btnBalrale.Name = "btnBalrale";
            this.btnBalrale.Size = new System.Drawing.Size(75, 23);
            this.btnBalrale.TabIndex = 0;
            this.btnBalrale.Text = "Balra le";
            this.btnBalrale.UseVisualStyleBackColor = false;
            this.btnBalrale.Click += new System.EventHandler(this.btnBalrale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBalrale);
            this.Controls.Add(this.jobbrale);
            this.Controls.Add(this.btnJobbrafel);
            this.Controls.Add(this.btnBalrafel);
            this.Name = "Form1";
            this.Text = "Form ugratás";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBalrafel;
        private Button btnJobbrafel;
        private Button jobbrale;
        private Button btnBalrale;
    }
}