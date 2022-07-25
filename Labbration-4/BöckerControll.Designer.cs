namespace Labbration_4
{
    partial class BöckerControll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BookDataGrid = new System.Windows.Forms.DataGridView();
            this.MainSpliter = new System.Windows.Forms.SplitContainer();
            this.ButtonSpliter = new System.Windows.Forms.SplitContainer();
            this.läggTutton = new System.Windows.Forms.Button();
            this.RaderaButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SpråkText = new System.Windows.Forms.TextBox();
            this.FormatText = new System.Windows.Forms.TextBox();
            this.GenreText = new System.Windows.Forms.TextBox();
            this.FörfattareText = new System.Windows.Forms.TextBox();
            this.PrisText = new System.Windows.Forms.TextBox();
            this.NamnText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Titt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSpliter)).BeginInit();
            this.MainSpliter.Panel1.SuspendLayout();
            this.MainSpliter.Panel2.SuspendLayout();
            this.MainSpliter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSpliter)).BeginInit();
            this.ButtonSpliter.Panel1.SuspendLayout();
            this.ButtonSpliter.Panel2.SuspendLayout();
            this.ButtonSpliter.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookDataGrid
            // 
            this.BookDataGrid.AllowUserToAddRows = false;
            this.BookDataGrid.AllowUserToDeleteRows = false;
            this.BookDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.BookDataGrid.Location = new System.Drawing.Point(-3, 0);
            this.BookDataGrid.MultiSelect = false;
            this.BookDataGrid.Name = "BookDataGrid";
            this.BookDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BookDataGrid.RowHeadersWidth = 62;
            this.BookDataGrid.RowTemplate.Height = 28;
            this.BookDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDataGrid.ShowCellErrors = false;
            this.BookDataGrid.ShowCellToolTips = false;
            this.BookDataGrid.ShowEditingIcon = false;
            this.BookDataGrid.ShowRowErrors = false;
            this.BookDataGrid.Size = new System.Drawing.Size(954, 819);
            this.BookDataGrid.TabIndex = 0;
            this.BookDataGrid.SelectionChanged += new System.EventHandler(this.BookDataGrid_Selectionchanged);
            // 
            // MainSpliter
            // 
            this.MainSpliter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSpliter.IsSplitterFixed = true;
            this.MainSpliter.Location = new System.Drawing.Point(0, 0);
            this.MainSpliter.Name = "MainSpliter";
            // 
            // MainSpliter.Panel1
            // 
            this.MainSpliter.Panel1.Controls.Add(this.ButtonSpliter);
            this.MainSpliter.Panel1.Controls.Add(this.BookDataGrid);
            // 
            // MainSpliter.Panel2
            // 
            this.MainSpliter.Panel2.Controls.Add(this.label6);
            this.MainSpliter.Panel2.Controls.Add(this.CancelButton);
            this.MainSpliter.Panel2.Controls.Add(this.SaveButton);
            this.MainSpliter.Panel2.Controls.Add(this.SpråkText);
            this.MainSpliter.Panel2.Controls.Add(this.FormatText);
            this.MainSpliter.Panel2.Controls.Add(this.GenreText);
            this.MainSpliter.Panel2.Controls.Add(this.FörfattareText);
            this.MainSpliter.Panel2.Controls.Add(this.PrisText);
            this.MainSpliter.Panel2.Controls.Add(this.NamnText);
            this.MainSpliter.Panel2.Controls.Add(this.label5);
            this.MainSpliter.Panel2.Controls.Add(this.label4);
            this.MainSpliter.Panel2.Controls.Add(this.label3);
            this.MainSpliter.Panel2.Controls.Add(this.label2);
            this.MainSpliter.Panel2.Controls.Add(this.label1);
            this.MainSpliter.Panel2.Controls.Add(this.Titt);
            this.MainSpliter.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainSpliter.Size = new System.Drawing.Size(1456, 911);
            this.MainSpliter.SplitterDistance = 954;
            this.MainSpliter.TabIndex = 1;
            // 
            // ButtonSpliter
            // 
            this.ButtonSpliter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSpliter.IsSplitterFixed = true;
            this.ButtonSpliter.Location = new System.Drawing.Point(97, 841);
            this.ButtonSpliter.Name = "ButtonSpliter";
            // 
            // ButtonSpliter.Panel1
            // 
            this.ButtonSpliter.Panel1.Controls.Add(this.läggTutton);
            // 
            // ButtonSpliter.Panel2
            // 
            this.ButtonSpliter.Panel2.Controls.Add(this.RaderaButton);
            this.ButtonSpliter.Size = new System.Drawing.Size(654, 70);
            this.ButtonSpliter.SplitterDistance = 225;
            this.ButtonSpliter.TabIndex = 15;
            // 
            // läggTutton
            // 
            this.läggTutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.läggTutton.Location = new System.Drawing.Point(0, 0);
            this.läggTutton.Name = "läggTutton";
            this.läggTutton.Size = new System.Drawing.Size(225, 70);
            this.läggTutton.TabIndex = 0;
            this.läggTutton.Text = "Lägg Till";
            this.läggTutton.UseVisualStyleBackColor = true;
           
            // 
            // RaderaButton
            // 
            this.RaderaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RaderaButton.Location = new System.Drawing.Point(0, 0);
            this.RaderaButton.Name = "RaderaButton";
            this.RaderaButton.Size = new System.Drawing.Size(425, 70);
            this.RaderaButton.TabIndex = 14;
            this.RaderaButton.Text = "Ta Bort";
            this.RaderaButton.UseVisualStyleBackColor = true;
            this.RaderaButton.Click += new System.EventHandler(this.RaderaButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "Update Böcker:";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Enabled = false;
            this.CancelButton.Location = new System.Drawing.Point(94, 355);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(106, 54);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Avbryt";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(244, 355);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(97, 54);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Spara";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SpråkText
            // 
            this.SpråkText.Location = new System.Drawing.Point(94, 235);
            this.SpråkText.Multiline = true;
            this.SpråkText.Name = "SpråkText";
            this.SpråkText.Size = new System.Drawing.Size(337, 32);
            this.SpråkText.TabIndex = 13;
            this.SpråkText.TextChanged += new System.EventHandler(this.SpråkText_TextChanged);
            // 
            // FormatText
            // 
            this.FormatText.Location = new System.Drawing.Point(94, 202);
            this.FormatText.Multiline = true;
            this.FormatText.Name = "FormatText";
            this.FormatText.Size = new System.Drawing.Size(337, 31);
            this.FormatText.TabIndex = 12;
            this.FormatText.TextChanged += new System.EventHandler(this.FormatText_TextChanged);
            // 
            // GenreText
            // 
            this.GenreText.Location = new System.Drawing.Point(94, 169);
            this.GenreText.Multiline = true;
            this.GenreText.Name = "GenreText";
            this.GenreText.Size = new System.Drawing.Size(337, 31);
            this.GenreText.TabIndex = 11;
            this.GenreText.TextChanged += new System.EventHandler(this.GenreText_TextChanged);
            // 
            // FörfattareText
            // 
            this.FörfattareText.Location = new System.Drawing.Point(94, 137);
            this.FörfattareText.Multiline = true;
            this.FörfattareText.Name = "FörfattareText";
            this.FörfattareText.Size = new System.Drawing.Size(337, 31);
            this.FörfattareText.TabIndex = 9;
            this.FörfattareText.TextChanged += new System.EventHandler(this.FörfattareText_TextChanged);
            // 
            // PrisText
            // 
            this.PrisText.Location = new System.Drawing.Point(95, 103);
            this.PrisText.Multiline = true;
            this.PrisText.Name = "PrisText";
            this.PrisText.Size = new System.Drawing.Size(336, 32);
            this.PrisText.TabIndex = 8;
            this.PrisText.TextChanged += new System.EventHandler(this.PrisText_TextChanged);
            // 
            // NamnText
            // 
            this.NamnText.Location = new System.Drawing.Point(94, 70);
            this.NamnText.Multiline = true;
            this.NamnText.Name = "NamnText";
            this.NamnText.Size = new System.Drawing.Size(337, 31);
            this.NamnText.TabIndex = 7;
            this.NamnText.TextChanged += new System.EventHandler(this.NamnText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Språk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Format";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Författare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pris";
            // 
            // Titt
            // 
            this.Titt.AutoSize = true;
            this.Titt.Location = new System.Drawing.Point(8, 70);
            this.Titt.Name = "Titt";
            this.Titt.Size = new System.Drawing.Size(51, 20);
            this.Titt.TabIndex = 1;
            this.Titt.Text = "Namn";
            // 
            // BöckerControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainSpliter);
            this.Name = "BöckerControll";
            this.Size = new System.Drawing.Size(1456, 911);
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGrid)).EndInit();
            this.MainSpliter.Panel1.ResumeLayout(false);
            this.MainSpliter.Panel2.ResumeLayout(false);
            this.MainSpliter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSpliter)).EndInit();
            this.MainSpliter.ResumeLayout(false);
            this.ButtonSpliter.Panel1.ResumeLayout(false);
            this.ButtonSpliter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSpliter)).EndInit();
            this.ButtonSpliter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookDataGrid;
        private System.Windows.Forms.SplitContainer MainSpliter;
        private System.Windows.Forms.Button läggTutton;
        private System.Windows.Forms.Label Titt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SpråkText;
        private System.Windows.Forms.TextBox FormatText;
        private System.Windows.Forms.TextBox GenreText;
        private System.Windows.Forms.TextBox FörfattareText;
        private System.Windows.Forms.TextBox PrisText;
        private System.Windows.Forms.TextBox NamnText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer ButtonSpliter;
        private System.Windows.Forms.Button RaderaButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
    }
}
