﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labbration_4
{
    public partial class BöckerControll : UserControl
    {
        BindingSource BoookListSource;
        Book SelectedItem;
        Library lib;
        private BindingSource bookListSource;

        public BöckerControll(Library liB, BindingSource bookListSource)
        {
            InitializeComponent();
            this.BoookListSource = bookListSource;
            lib = liB;
            BookDataGrid.DataSource = bookListSource;
            
           
        } 


        private void BookDataGrid_SelectionChanged(object sender, EventArgs e)

        {
            if (BookDataGrid.SelectedRows.Count < 1)
            {
                SetTextEnabled(true);
                return;
            }
               
            var book = (Book)BookDataGrid.SelectedRows[0].DataBoundItem;
            NamnText.Text = book.Name;
            GenreText.Text = book.Genre;
            SpråkText.Text = book.Språk;
            FormatText.Text = book.Format;
            FörfattareText.Text = book.Författare;
            PrisText.Text = book.Pris;
            SelectedItem = book;
            SaveButton.Enabled = false;
            CancelButton.Enabled = false;


        }

        private void NamnText_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void PrisText_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void FörfattareText_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void GenreText_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void FormatText_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void SpråkText_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            BookDataGrid_SelectionChanged(sender, null);
        }

       

        private void SetTextEnabled(Boolean stat)
        {
            FormatText.Enabled = stat;
            PrisText.Enabled = stat;
            GenreText.Enabled = stat;
            SpråkText.Enabled = stat;
            NamnText.Enabled = stat;
            FörfattareText.Enabled=stat;
        }

        private void läggTutton_Click(object sender, EventArgs e)
        {
            LäggTillBook tillBook = new LäggTillBook();
            tillBook.StartPosition = FormStartPosition.CenterParent;  
           if(tillBook.ShowDialog() == DialogResult.OK)
            {
                BoookListSource.Add(tillBook.Book);
                lib.SaveFileBook();
            }
            {
                  
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SelectedItem.Författare = FörfattareText.Text;
            SelectedItem.Genre = GenreText.Text;
            SelectedItem.Språk = SpråkText.Text;
            SelectedItem.Format = FormatText.Text;
            SelectedItem.Pris = PrisText.Text;
            SelectedItem.Name = NamnText.Text;
            BoookListSource.ResetCurrentItem();
            BookDataGrid_SelectionChanged(sender, null);
            lib.SaveFileBook();
        }

        private void RaderaButton_Click(object sender, EventArgs e)
        {
            if (BookDataGrid.SelectedRows.Count < 1)
                return;
            var book = (Book)BookDataGrid.SelectedRows[0].DataBoundItem;
            BoookListSource.Remove(book);
            FörfattareText.Text = "";
            GenreText.Text = "";
            PrisText.Text = "";
            FormatText.Text = "";
            SpråkText.Text = "";
            NamnText.Text = "";
            SaveButton.Enabled = false;
            CancelButton.Enabled = false;
            BookDataGrid_SelectionChanged(sender, null);
            lib.SaveFileBook();
        }

    }
}
