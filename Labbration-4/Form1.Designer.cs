namespace Labbration_4
{
    partial class Form1
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
            this.BookButton = new System.Windows.Forms.Button();
            this.KassaButton = new System.Windows.Forms.Button();
            this.AvslutaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(78, 121);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(281, 55);
            this.BookButton.TabIndex = 0;
            this.BookButton.Text = "Till Lager";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // KassaButton
            // 
            this.KassaButton.Location = new System.Drawing.Point(425, 121);
            this.KassaButton.Name = "KassaButton";
            this.KassaButton.Size = new System.Drawing.Size(260, 55);
            this.KassaButton.TabIndex = 1;
            this.KassaButton.Text = "Till Kassa";
            this.KassaButton.UseVisualStyleBackColor = true;
            this.KassaButton.Click += new System.EventHandler(this.KassaButton_Click);
            // 
            // AvslutaButton
            // 
            this.AvslutaButton.Location = new System.Drawing.Point(78, 203);
            this.AvslutaButton.Name = "AvslutaButton";
            this.AvslutaButton.Size = new System.Drawing.Size(607, 95);
            this.AvslutaButton.TabIndex = 2;
            this.AvslutaButton.Text = "Avsluta";
            this.AvslutaButton.UseVisualStyleBackColor = true;
            this.AvslutaButton.Click += new System.EventHandler(this.AvslutaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AvslutaButton);
            this.Controls.Add(this.KassaButton);
            this.Controls.Add(this.BookButton);
            this.Name = "Form1";
            this.Text = "Affärssystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button KassaButton;
        private System.Windows.Forms.Button AvslutaButton;
    }
}

