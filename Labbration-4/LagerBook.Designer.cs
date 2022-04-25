namespace Labbration_4
{
    partial class LagerTabs
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.BokTab = new System.Windows.Forms.TabPage();
            this.DataSpelTab = new System.Windows.Forms.TabPage();
            this.FilmTab = new System.Windows.Forms.TabPage();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.BokTab);
            this.tabControl2.Controls.Add(this.DataSpelTab);
            this.tabControl2.Controls.Add(this.FilmTab);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1555, 1031);
            this.tabControl2.TabIndex = 0;
            // 
            // BokTab
            // 
            this.BokTab.Location = new System.Drawing.Point(4, 29);
            this.BokTab.Name = "BokTab";
            this.BokTab.Padding = new System.Windows.Forms.Padding(3);
            this.BokTab.Size = new System.Drawing.Size(1547, 998);
            this.BokTab.TabIndex = 2;
            this.BokTab.Text = "Bok";
            this.BokTab.UseVisualStyleBackColor = true;
            // 
            // DataSpelTab
            // 
            this.DataSpelTab.Location = new System.Drawing.Point(4, 29);
            this.DataSpelTab.Name = "DataSpelTab";
            this.DataSpelTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataSpelTab.Size = new System.Drawing.Size(1622, 1054);
            this.DataSpelTab.TabIndex = 3;
            this.DataSpelTab.Text = "DataSpel";
            this.DataSpelTab.UseVisualStyleBackColor = true;
            // 
            // FilmTab
            // 
            this.FilmTab.Location = new System.Drawing.Point(4, 29);
            this.FilmTab.Name = "FilmTab";
            this.FilmTab.Size = new System.Drawing.Size(1622, 1054);
            this.FilmTab.TabIndex = 4;
            this.FilmTab.Text = "Film";
            this.FilmTab.UseVisualStyleBackColor = true;
            // 
            // LagerTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 1031);
            this.Controls.Add(this.tabControl2);
            this.Name = "LagerTabs";
            this.Text = "LagerTabs";
            this.Load += new System.EventHandler(this.Lager_Load);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage BokTab;
        private System.Windows.Forms.TabPage DataSpelTab;
        private System.Windows.Forms.TabPage FilmTab;
    }
}