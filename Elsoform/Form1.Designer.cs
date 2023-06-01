namespace Elsoform
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
            this.Label = new System.Windows.Forms.Label();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.nudSzorzo = new System.Windows.Forms.NumericUpDown();
            this.nudOszto = new System.Windows.Forms.NumericUpDown();
            this.Szorzo = new System.Windows.Forms.Label();
            this.Oszto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzorzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOszto)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.LawnGreen;
            this.Label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(375, 44);
            this.Label.TabIndex = 0;
            this.Label.Text = "Helló world";
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(12, 79);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 1;
            this.btnSzamol.Text = "Számolj!";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(312, 79);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 2;
            this.btnKilep.Text = "Kilép!";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // nudSzorzo
            // 
            this.nudSzorzo.Location = new System.Drawing.Point(12, 132);
            this.nudSzorzo.Name = "nudSzorzo";
            this.nudSzorzo.Size = new System.Drawing.Size(120, 23);
            this.nudSzorzo.TabIndex = 3;
            // 
            // nudOszto
            // 
            this.nudOszto.Location = new System.Drawing.Point(267, 132);
            this.nudOszto.Name = "nudOszto";
            this.nudOszto.Size = new System.Drawing.Size(120, 23);
            this.nudOszto.TabIndex = 4;
            // 
            // Szorzo
            // 
            this.Szorzo.AutoSize = true;
            this.Szorzo.Location = new System.Drawing.Point(12, 114);
            this.Szorzo.Name = "Szorzo";
            this.Szorzo.Size = new System.Drawing.Size(41, 15);
            this.Szorzo.TabIndex = 5;
            this.Szorzo.Text = "Szorzó";
            // 
            // Oszto
            // 
            this.Oszto.AutoSize = true;
            this.Oszto.Location = new System.Drawing.Point(267, 114);
            this.Oszto.Name = "Oszto";
            this.Oszto.Size = new System.Drawing.Size(37, 15);
            this.Oszto.TabIndex = 6;
            this.Oszto.Text = "Osztó";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Oszto);
            this.Controls.Add(this.Szorzo);
            this.Controls.Add(this.nudOszto);
            this.Controls.Add(this.nudSzorzo);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.Label);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "ElsoProgramok";
            ((System.ComponentModel.ISupportInitialize)(this.nudSzorzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOszto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Label;
        private Button btnSzamol;
        private Button btnKilep;
        private NumericUpDown nudSzorzo;
        private NumericUpDown nudOszto;
        private Label Szorzo;
        private Label Oszto;
    }
}