namespace Labbration_4
{
    partial class LäggTillSpel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SparaFilm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Titt = new System.Windows.Forms.Label();
            this.PlattformTextSpel = new System.Windows.Forms.TextBox();
            this.PrisTextSpel = new System.Windows.Forms.TextBox();
            this.NamnTextSpel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SparaFilm
            // 
            this.SparaFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SparaFilm.Location = new System.Drawing.Point(278, 186);
            this.SparaFilm.Name = "SparaFilm";
            this.SparaFilm.Size = new System.Drawing.Size(150, 54);
            this.SparaFilm.TabIndex = 47;
            this.SparaFilm.Text = "Spara Spelet";
            this.SparaFilm.UseVisualStyleBackColor = true;
            this.SparaFilm.Click += new System.EventHandler(this.SparaSpel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Plattform";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Pris";
            // 
            // Titt
            // 
            this.Titt.AutoSize = true;
            this.Titt.Location = new System.Drawing.Point(34, 72);
            this.Titt.Name = "Titt";
            this.Titt.Size = new System.Drawing.Size(51, 20);
            this.Titt.TabIndex = 44;
            this.Titt.Text = "Namn";
            // 
            // PlattformTextSpel
            // 
            this.PlattformTextSpel.Location = new System.Drawing.Point(92, 148);
            this.PlattformTextSpel.Multiline = true;
            this.PlattformTextSpel.Name = "PlattformTextSpel";
            this.PlattformTextSpel.Size = new System.Drawing.Size(337, 31);
            this.PlattformTextSpel.TabIndex = 43;
            // 
            // PrisTextSpel
            // 
            this.PrisTextSpel.Location = new System.Drawing.Point(92, 106);
            this.PrisTextSpel.Multiline = true;
            this.PrisTextSpel.Name = "PrisTextSpel";
            this.PrisTextSpel.Size = new System.Drawing.Size(336, 32);
            this.PrisTextSpel.TabIndex = 42;
            // 
            // NamnTextSpel
            // 
            this.NamnTextSpel.Location = new System.Drawing.Point(91, 69);
            this.NamnTextSpel.Multiline = true;
            this.NamnTextSpel.Name = "NamnTextSpel";
            this.NamnTextSpel.Size = new System.Drawing.Size(337, 31);
            this.NamnTextSpel.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 36);
            this.label6.TabIndex = 40;
            this.label6.Text = "Lägg Till En Spel:";
            // 
            // LäggTillSpel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 252);
            this.Controls.Add(this.SparaFilm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titt);
            this.Controls.Add(this.PlattformTextSpel);
            this.Controls.Add(this.PrisTextSpel);
            this.Controls.Add(this.NamnTextSpel);
            this.Controls.Add(this.label6);
            this.Name = "LäggTillSpel";
            this.Text = "LäggTillSpel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SparaFilm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titt;
        private System.Windows.Forms.TextBox PlattformTextSpel;
        private System.Windows.Forms.TextBox PrisTextSpel;
        private System.Windows.Forms.TextBox NamnTextSpel;
        private System.Windows.Forms.Label label6;
    }
}