namespace Labbration_4
{
    partial class FilmerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.läggTutton = new System.Windows.Forms.Button();
            this.RaderaButton = new System.Windows.Forms.Button();
            this.FilmDataGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeltidText = new System.Windows.Forms.TextBox();
            this.FormatText = new System.Windows.Forms.TextBox();
            this.PrisText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NamnText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilmDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.FilmDataGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.SaveButton);
            this.splitContainer1.Panel2.Controls.Add(this.CancelButton);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.SpeltidText);
            this.splitContainer1.Panel2.Controls.Add(this.FormatText);
            this.splitContainer1.Panel2.Controls.Add(this.PrisText);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.NamnText);
            this.splitContainer1.Size = new System.Drawing.Size(1367, 1041);
            this.splitContainer1.SplitterDistance = 912;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(290, 957);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.läggTutton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.RaderaButton);
            this.splitContainer2.Size = new System.Drawing.Size(242, 49);
            this.splitContainer2.SplitterDistance = 80;
            this.splitContainer2.TabIndex = 1;
            // 
            // läggTutton
            // 
            this.läggTutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.läggTutton.Location = new System.Drawing.Point(0, 0);
            this.läggTutton.Name = "läggTutton";
            this.läggTutton.Size = new System.Drawing.Size(80, 49);
            this.läggTutton.TabIndex = 0;
            this.läggTutton.Text = "Lägg Till";
            this.läggTutton.UseVisualStyleBackColor = true;
            this.läggTutton.Click += new System.EventHandler(this.läggTutton_Click);
            // 
            // RaderaButton
            // 
            this.RaderaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RaderaButton.Location = new System.Drawing.Point(0, 0);
            this.RaderaButton.Name = "RaderaButton";
            this.RaderaButton.Size = new System.Drawing.Size(158, 49);
            this.RaderaButton.TabIndex = 0;
            this.RaderaButton.Text = "Ta Bort";
            this.RaderaButton.UseVisualStyleBackColor = true;
            this.RaderaButton.Click += new System.EventHandler(this.RaderaButton_Click);
            // 
            // FilmDataGrid
            // 
            this.FilmDataGrid.AllowUserToAddRows = false;
            this.FilmDataGrid.AllowUserToDeleteRows = false;
            this.FilmDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmDataGrid.Location = new System.Drawing.Point(3, 3);
            this.FilmDataGrid.MultiSelect = false;
            this.FilmDataGrid.Name = "FilmDataGrid";
            this.FilmDataGrid.ReadOnly = true;
            this.FilmDataGrid.RowHeadersWidth = 62;
            this.FilmDataGrid.RowTemplate.Height = 28;
            this.FilmDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FilmDataGrid.ShowCellErrors = false;
            this.FilmDataGrid.ShowCellToolTips = false;
            this.FilmDataGrid.ShowEditingIcon = false;
            this.FilmDataGrid.ShowRowErrors = false;
            this.FilmDataGrid.Size = new System.Drawing.Size(906, 934);
            this.FilmDataGrid.TabIndex = 0;
            this.FilmDataGrid.SelectionChanged += new System.EventHandler(this.FilmDataGrid_SelectionChangedd);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(93, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "Update Film:";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(279, 257);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(117, 33);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Spara";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Enabled = false;
            this.CancelButton.Location = new System.Drawing.Point(163, 257);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(99, 33);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Abryt";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Speltid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pris";
            // 
            // SpeltidText
            // 
            this.SpeltidText.Location = new System.Drawing.Point(163, 164);
            this.SpeltidText.Name = "SpeltidText";
            this.SpeltidText.Size = new System.Drawing.Size(233, 26);
            this.SpeltidText.TabIndex = 4;
            this.SpeltidText.TextChanged += new System.EventHandler(this.SpeltidText_TextChanged);
            // 
            // FormatText
            // 
            this.FormatText.Location = new System.Drawing.Point(163, 132);
            this.FormatText.Name = "FormatText";
            this.FormatText.Size = new System.Drawing.Size(233, 26);
            this.FormatText.TabIndex = 3;
            this.FormatText.TextChanged += new System.EventHandler(this.FormatText_TextChanged);
            // 
            // PrisText
            // 
            this.PrisText.Location = new System.Drawing.Point(163, 100);
            this.PrisText.Name = "PrisText";
            this.PrisText.Size = new System.Drawing.Size(233, 26);
            this.PrisText.TabIndex = 2;
            this.PrisText.TextChanged += new System.EventHandler(this.PrisText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn";
            // 
            // NamnText
            // 
            this.NamnText.Location = new System.Drawing.Point(163, 68);
            this.NamnText.Name = "NamnText";
            this.NamnText.Size = new System.Drawing.Size(233, 26);
            this.NamnText.TabIndex = 0;
            this.NamnText.TextChanged += new System.EventHandler(this.NamnText_TextChanged);
            // 
            // FilmerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "FilmerControl";
            this.Size = new System.Drawing.Size(1367, 1041);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilmDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView FilmDataGrid;
        private System.Windows.Forms.TextBox NamnText;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SpeltidText;
        private System.Windows.Forms.TextBox FormatText;
        private System.Windows.Forms.TextBox PrisText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button läggTutton;
        private System.Windows.Forms.Button RaderaButton;
        private System.Windows.Forms.Label label7;
    }
}
