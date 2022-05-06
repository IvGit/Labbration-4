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
            this.AddBookToTabelButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.AddSpelToTabelButton = new System.Windows.Forms.Button();
            this.AddMovieToTabelButton = new System.Windows.Forms.Button();
            this.FinishButonSpel = new System.Windows.Forms.Button();
            this.FinishButonFilm = new System.Windows.Forms.Button();
            this.radioSpel = new System.Windows.Forms.RadioButton();
            this.radioFilm = new System.Windows.Forms.RadioButton();
            this.RadioBock = new System.Windows.Forms.RadioButton();
            this.FinishButonBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SäljaListDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SäljaListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 26);
            this.textBox1.TabIndex = 1;
            // 
            // AddBookToTabelButton
            // 
            this.AddBookToTabelButton.Location = new System.Drawing.Point(193, 68);
            this.AddBookToTabelButton.Name = "AddBookToTabelButton";
            this.AddBookToTabelButton.Size = new System.Drawing.Size(87, 34);
            this.AddBookToTabelButton.TabIndex = 2;
            this.AddBookToTabelButton.Text = "Add";
            this.AddBookToTabelButton.UseVisualStyleBackColor = true;
            this.AddBookToTabelButton.Click += new System.EventHandler(this.AddToTabelButton_Click);
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
            this.splitContainer1.Panel2.Controls.Add(this.SäljaListDataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(830, 630);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.AddSpelToTabelButton);
            this.splitContainer2.Panel1.Controls.Add(this.AddMovieToTabelButton);
            this.splitContainer2.Panel1.Controls.Add(this.FinishButonSpel);
            this.splitContainer2.Panel1.Controls.Add(this.FinishButonFilm);
            this.splitContainer2.Panel1.Controls.Add(this.radioSpel);
            this.splitContainer2.Panel1.Controls.Add(this.radioFilm);
            this.splitContainer2.Panel1.Controls.Add(this.RadioBock);
            this.splitContainer2.Panel1.Controls.Add(this.FinishButonBook);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.AddBookToTabelButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBox1);
            this.splitContainer2.Size = new System.Drawing.Size(990, 230);
            this.splitContainer2.SplitterDistance = 336;
            this.splitContainer2.TabIndex = 5;
            // 
            // AddSpelToTabelButton
            // 
            this.AddSpelToTabelButton.Location = new System.Drawing.Point(193, 171);
            this.AddSpelToTabelButton.Name = "AddSpelToTabelButton";
            this.AddSpelToTabelButton.Size = new System.Drawing.Size(87, 34);
            this.AddSpelToTabelButton.TabIndex = 12;
            this.AddSpelToTabelButton.Text = "Add";
            this.AddSpelToTabelButton.UseVisualStyleBackColor = true;
            // 
            // AddMovieToTabelButton
            // 
            this.AddMovieToTabelButton.Location = new System.Drawing.Point(193, 117);
            this.AddMovieToTabelButton.Name = "AddMovieToTabelButton";
            this.AddMovieToTabelButton.Size = new System.Drawing.Size(87, 34);
            this.AddMovieToTabelButton.TabIndex = 11;
            this.AddMovieToTabelButton.Text = "Add";
            this.AddMovieToTabelButton.UseVisualStyleBackColor = true;
            
            // 
            // FinishButonSpel
            // 
            this.FinishButonSpel.Location = new System.Drawing.Point(110, 171);
            this.FinishButonSpel.Name = "FinishButonSpel";
            this.FinishButonSpel.Size = new System.Drawing.Size(75, 34);
            this.FinishButonSpel.TabIndex = 10;
            this.FinishButonSpel.Text = "Finish";
            this.FinishButonSpel.UseVisualStyleBackColor = true;
            this.FinishButonSpel.Click += new System.EventHandler(this.FinishButonSpel_Click);
            // 
            // FinishButonFilm
            // 
            this.FinishButonFilm.Location = new System.Drawing.Point(110, 117);
            this.FinishButonFilm.Name = "FinishButonFilm";
            this.FinishButonFilm.Size = new System.Drawing.Size(75, 34);
            this.FinishButonFilm.TabIndex = 9;
            this.FinishButonFilm.Text = "Finish";
            this.FinishButonFilm.UseVisualStyleBackColor = true;
            this.FinishButonFilm.Click += new System.EventHandler(this.FinishButonFilm_Click);
            // 
            // radioSpel
            // 
            this.radioSpel.AutoSize = true;
            this.radioSpel.Location = new System.Drawing.Point(38, 176);
            this.radioSpel.Name = "radioSpel";
            this.radioSpel.Size = new System.Drawing.Size(66, 24);
            this.radioSpel.TabIndex = 7;
            this.radioSpel.Text = "Spel";
            this.radioSpel.UseVisualStyleBackColor = true;
            this.radioSpel.CheckedChanged += new System.EventHandler(this.radioSpel_CheckedChanged);
            // 
            // radioFilm
            // 
            this.radioFilm.AutoSize = true;
            this.radioFilm.Location = new System.Drawing.Point(34, 122);
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
            this.RadioBock.Location = new System.Drawing.Point(34, 73);
            this.RadioBock.Name = "RadioBock";
            this.RadioBock.Size = new System.Drawing.Size(70, 24);
            this.RadioBock.TabIndex = 5;
            this.RadioBock.Text = "Bock";
            this.RadioBock.UseVisualStyleBackColor = true;
            this.RadioBock.CheckedChanged += new System.EventHandler(this.RadioBock_CheckedChanged);
            // 
            // FinishButonBook
            // 
            this.FinishButonBook.Location = new System.Drawing.Point(110, 68);
            this.FinishButonBook.Name = "FinishButonBook";
            this.FinishButonBook.Size = new System.Drawing.Size(75, 34);
            this.FinishButonBook.TabIndex = 4;
            this.FinishButonBook.Text = "Finish";
            this.FinishButonBook.UseVisualStyleBackColor = true;
            this.FinishButonBook.Click += new System.EventHandler(this.FinishButton_Click);
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
            // SäljaListDataGrid
            // 
            this.SäljaListDataGrid.AllowUserToAddRows = false;
            this.SäljaListDataGrid.AllowUserToDeleteRows = false;
            this.SäljaListDataGrid.AllowUserToResizeColumns = false;
            this.SäljaListDataGrid.AllowUserToResizeRows = false;
            this.SäljaListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SäljaListDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SäljaListDataGrid.Location = new System.Drawing.Point(0, 0);
            this.SäljaListDataGrid.MultiSelect = false;
            this.SäljaListDataGrid.Name = "SäljaListDataGrid";
            this.SäljaListDataGrid.ReadOnly = true;
            this.SäljaListDataGrid.RowHeadersWidth = 62;
            this.SäljaListDataGrid.RowTemplate.Height = 28;
            this.SäljaListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SäljaListDataGrid.ShowCellErrors = false;
            this.SäljaListDataGrid.ShowCellToolTips = false;
            this.SäljaListDataGrid.ShowEditingIcon = false;
            this.SäljaListDataGrid.ShowRowErrors = false;
            this.SäljaListDataGrid.Size = new System.Drawing.Size(830, 430);
            this.SäljaListDataGrid.TabIndex = 0;
            this.SäljaListDataGrid.SelectionChanged += new System.EventHandler(this.BookListDataGrid_selectionChanged);
            // 
            // SäljaControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "SäljaControll";
            this.Size = new System.Drawing.Size(830, 630);
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
            ((System.ComponentModel.ISupportInitialize)(this.SäljaListDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddBookToTabelButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView SäljaListDataGrid;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button FinishButonBook;
        private System.Windows.Forms.RadioButton RadioBock;
        private System.Windows.Forms.RadioButton radioFilm;
        private System.Windows.Forms.RadioButton radioSpel;
        private System.Windows.Forms.Button AddSpelToTabelButton;
        private System.Windows.Forms.Button AddMovieToTabelButton;
        private System.Windows.Forms.Button FinishButonSpel;
        private System.Windows.Forms.Button FinishButonFilm;
    }
}
