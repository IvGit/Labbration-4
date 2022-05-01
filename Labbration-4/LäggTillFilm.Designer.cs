namespace Labbration_4
{
    partial class LäggTillFilm
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
            this.label6 = new System.Windows.Forms.Label();
            this.SpeltidText = new System.Windows.Forms.TextBox();
            this.FormatText = new System.Windows.Forms.TextBox();
            this.PrisText = new System.Windows.Forms.TextBox();
            this.NamnText = new System.Windows.Forms.TextBox();
            this.Titt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SparaFilm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 43);
            this.label6.TabIndex = 30;
            this.label6.Text = "Lägg Till En Film:";
            // 
            // SpeltidText
            // 
            this.SpeltidText.Location = new System.Drawing.Point(81, 184);
            this.SpeltidText.Multiline = true;
            this.SpeltidText.Name = "SpeltidText";
            this.SpeltidText.Size = new System.Drawing.Size(337, 32);
            this.SpeltidText.TabIndex = 34;
            // 
            // FormatText
            // 
            this.FormatText.Location = new System.Drawing.Point(81, 147);
            this.FormatText.Multiline = true;
            this.FormatText.Name = "FormatText";
            this.FormatText.Size = new System.Drawing.Size(337, 31);
            this.FormatText.TabIndex = 33;
            // 
            // PrisText
            // 
            this.PrisText.Location = new System.Drawing.Point(81, 109);
            this.PrisText.Multiline = true;
            this.PrisText.Name = "PrisText";
            this.PrisText.Size = new System.Drawing.Size(336, 32);
            this.PrisText.TabIndex = 32;
            // 
            // NamnText
            // 
            this.NamnText.Location = new System.Drawing.Point(80, 72);
            this.NamnText.Multiline = true;
            this.NamnText.Name = "NamnText";
            this.NamnText.Size = new System.Drawing.Size(337, 31);
            this.NamnText.TabIndex = 31;
            // 
            // Titt
            // 
            this.Titt.AutoSize = true;
            this.Titt.Location = new System.Drawing.Point(23, 75);
            this.Titt.Name = "Titt";
            this.Titt.Size = new System.Drawing.Size(51, 20);
            this.Titt.TabIndex = 35;
            this.Titt.Text = "Namn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Pris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "SpelTid";
            // 
            // SparaFilm
            // 
            this.SparaFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SparaFilm.Location = new System.Drawing.Point(263, 228);
            this.SparaFilm.Name = "SparaFilm";
            this.SparaFilm.Size = new System.Drawing.Size(150, 54);
            this.SparaFilm.TabIndex = 39;
            this.SparaFilm.Text = "Spara Filmen";
            this.SparaFilm.UseVisualStyleBackColor = true;
            this.SparaFilm.Click += new System.EventHandler(this.SparaFilm_Click);
            // 
            // LäggTillFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 294);
            this.Controls.Add(this.SparaFilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titt);
            this.Controls.Add(this.SpeltidText);
            this.Controls.Add(this.FormatText);
            this.Controls.Add(this.PrisText);
            this.Controls.Add(this.NamnText);
            this.Controls.Add(this.label6);
            this.Name = "LäggTillFilm";
            this.Text = "LäggTillFilm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SpeltidText;
        private System.Windows.Forms.TextBox FormatText;
        private System.Windows.Forms.TextBox PrisText;
        private System.Windows.Forms.TextBox NamnText;
        private System.Windows.Forms.Label Titt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SparaFilm;
    }
}