namespace Labbration_4
{
    partial class SäljaControll
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddToTabelButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.radioSpel = new System.Windows.Forms.RadioButton();
            this.radioFilm = new System.Windows.Forms.RadioButton();
            this.RadioBock = new System.Windows.Forms.RadioButton();
            this.FinishButon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BookListDataGrid = new System.Windows.Forms.DataGridView();
            this.BuyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 26);
            this.textBox1.TabIndex = 1;
            // 
            // AddToTabelButton
            // 
            this.AddToTabelButton.Location = new System.Drawing.Point(193, 68);
            this.AddToTabelButton.Name = "AddToTabelButton";
            this.AddToTabelButton.Size = new System.Drawing.Size(87, 34);
            this.AddToTabelButton.TabIndex = 2;
            this.AddToTabelButton.Text = "Add";
            this.AddToTabelButton.UseVisualStyleBackColor = true;
            this.AddToTabelButton.Click += new System.EventHandler(this.AddToTabelButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BookListDataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(996, 756);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.BuyButton);
            this.splitContainer2.Panel1.Controls.Add(this.radioSpel);
            this.splitContainer2.Panel1.Controls.Add(this.radioFilm);
            this.splitContainer2.Panel1.Controls.Add(this.RadioBock);
            this.splitContainer2.Panel1.Controls.Add(this.FinishButon);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.AddToTabelButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBox1);
            this.splitContainer2.Size = new System.Drawing.Size(990, 230);
            this.splitContainer2.SplitterDistance = 336;
            this.splitContainer2.TabIndex = 5;
            // 
            // radioSpel
            // 
            this.radioSpel.AutoSize = true;
            this.radioSpel.Location = new System.Drawing.Point(162, 145);
            this.radioSpel.Name = "radioSpel";
            this.radioSpel.Size = new System.Drawing.Size(66, 24);
            this.radioSpel.TabIndex = 7;
            this.radioSpel.Text = "Spel";
            this.radioSpel.UseVisualStyleBackColor = true;
            // 
            // radioFilm
            // 
            this.radioFilm.AutoSize = true;
            this.radioFilm.Location = new System.Drawing.Point(93, 145);
            this.radioFilm.Name = "radioFilm";
            this.radioFilm.Size = new System.Drawing.Size(63, 24);
            this.radioFilm.TabIndex = 6;
            this.radioFilm.Text = "Film";
            this.radioFilm.UseVisualStyleBackColor = true;
            this.radioFilm.CheckedChanged += new System.EventHandler(this.radioFilm_CheckedChanged);
            // 
            // RadioBock
            // 
            this.RadioBock.AutoSize = true;
            this.RadioBock.Location = new System.Drawing.Point(17, 145);
            this.RadioBock.Name = "RadioBock";
            this.RadioBock.Size = new System.Drawing.Size(70, 24);
            this.RadioBock.TabIndex = 5;
            this.RadioBock.Text = "Bock";
            this.RadioBock.UseVisualStyleBackColor = true;
            this.RadioBock.CheckedChanged += new System.EventHandler(this.RadioBock_CheckedChanged);
            // 
            // FinishButon
            // 
            this.FinishButon.Location = new System.Drawing.Point(110, 68);
            this.FinishButon.Name = "FinishButon";
            this.FinishButon.Size = new System.Drawing.Size(75, 34);
            this.FinishButon.TabIndex = 4;
            this.FinishButon.Text = "Finish";
            this.FinishButon.UseVisualStyleBackColor = true;
            this.FinishButon.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lägg till Korgen";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(650, 230);
            this.listBox1.TabIndex = 4;
            // 
            // BookListDataGrid
            // 
            this.BookListDataGrid.AllowUserToAddRows = false;
            this.BookListDataGrid.AllowUserToDeleteRows = false;
            this.BookListDataGrid.AllowUserToResizeColumns = false;
            this.BookListDataGrid.AllowUserToResizeRows = false;
            this.BookListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookListDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookListDataGrid.Location = new System.Drawing.Point(0, 0);
            this.BookListDataGrid.MultiSelect = false;
            this.BookListDataGrid.Name = "BookListDataGrid";
            this.BookListDataGrid.ReadOnly = true;
            this.BookListDataGrid.RowHeadersWidth = 62;
            this.BookListDataGrid.RowTemplate.Height = 28;
            this.BookListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookListDataGrid.ShowCellErrors = false;
            this.BookListDataGrid.ShowCellToolTips = false;
            this.BookListDataGrid.ShowEditingIcon = false;
            this.BookListDataGrid.ShowRowErrors = false;
            this.BookListDataGrid.Size = new System.Drawing.Size(996, 516);
            this.BookListDataGrid.TabIndex = 0;
            this.BookListDataGrid.SelectionChanged += new System.EventHandler(this.BookListDataGrid_selectionChanged);
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(17, 175);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(211, 34);
            this.BuyButton.TabIndex = 8;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            // 
            // SäljaControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "SäljaControll";
            this.Size = new System.Drawing.Size(996, 756);
            this.Load += new System.EventHandler(this.SäljaControll_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookListDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddToTabelButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView BookListDataGrid;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button FinishButon;
        private System.Windows.Forms.RadioButton RadioBock;
        private System.Windows.Forms.RadioButton radioFilm;
        private System.Windows.Forms.RadioButton radioSpel;
        private System.Windows.Forms.Button BuyButton;
    }
}
