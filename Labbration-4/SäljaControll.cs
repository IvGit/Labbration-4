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
    public partial class SäljaControll : UserControl
    {

        public Button AcceptButton { get { return AddToTabelButton; } }


        private BindingSource BookListS;
       

        public SäljaControll(BindingSource bookListSource)
        {
            InitializeComponent();
            BookListS = bookListSource;
             BookListDataGrid.DataSource = bookListSource;

            
        }


        private void SäljaControll_Load(object sender, EventArgs e)
        {
            

            BookListDataGrid.ClearSelection();
            textBox1.Text = "";



        }

        private void BookListDataGrid_selectionChanged(object sender, EventArgs e)
        {
            if (BookListDataGrid.SelectedRows.Count < 1)
            
              //  SetTextEnabled(true);
                return;
            

            var book = (Book)BookListDataGrid.SelectedRows[0].DataBoundItem;
            textBox1.Text = book.Genre;
            BookListDataGrid.ClearSelection();
            textBox1.Focus();   
            textBox1.SelectAll();
        }

        private void AddToTabelButton_Click(object sender, EventArgs e)
        {
            foreach(var book in (BindingList<Book>)BookListS.DataSource)
            {
                if(book.Genre == textBox1.Text.Trim())
                {
                    listBox1.Items.Add(book);
                }
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            foreach(var item in textBox1.Items)
            {
                var book = (Book)item;
                book.BoVale = true;
            }
            BookListS.ResetBindings(false);
        }
    }
}
