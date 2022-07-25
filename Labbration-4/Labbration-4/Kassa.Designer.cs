namespace Labbration_4
{
    partial class Kassa
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
            this.SäljaTab = new System.Windows.Forms.TabControl();
            this.SäljaTab1 = new System.Windows.Forms.TabPage();
            this.SäljaTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SäljaTab
            // 
            this.SäljaTab.Controls.Add(this.SäljaTab1);
            this.SäljaTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SäljaTab.Location = new System.Drawing.Point(0, 0);
            this.SäljaTab.Name = "SäljaTab";
            this.SäljaTab.SelectedIndex = 0;
            this.SäljaTab.Size = new System.Drawing.Size(815, 759);
            this.SäljaTab.TabIndex = 0;
            // 
            // SäljaTab1
            // 
            this.SäljaTab1.Location = new System.Drawing.Point(4, 29);
            this.SäljaTab1.Name = "SäljaTab1";
            this.SäljaTab1.Padding = new System.Windows.Forms.Padding(3);
            this.SäljaTab1.Size = new System.Drawing.Size(807, 726);
            this.SäljaTab1.TabIndex = 0;
            this.SäljaTab1.Text = "Sälja";
            this.SäljaTab1.UseVisualStyleBackColor = true;
          
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 759);
            this.Controls.Add(this.SäljaTab);
            this.Name = "Kassa";
            this.Text = "Kassa";
            this.Load += new System.EventHandler(this.Kassa_Load);
            this.SäljaTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SäljaTab;
        private System.Windows.Forms.TabPage SäljaTab1;
    }
}