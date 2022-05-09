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

        public Button AcceptButton { get { return AddBookToTabelButton; } }

        Library lib;

        BindingSource BookListSource;
        BindingSource DataSpelSource;
        BindingSource FilmListSource;

        public SäljaControll(BindingSource bookListSource, BindingSource filmerlistSource)
        {
            InitializeComponent();

            BookListSource = bookListSource;
            lib = new Library();
            lib.LoadFile();
         //  SäljaListDataGrid.DataSource = lib.BookList;
            

            FilmListSource = filmerlistSource;
            lib.LoadFileMovie();
         //   SäljaListDataGrid.DataSource = lib.MovieList;
           //lib.SaveFile();

        }


        private void SäljaControll_Load(object sender, EventArgs e)
        {
            
            SäljaListDataGrid.ClearSelection();
            textBox1.Text = "";

        }
        
        
        /*

        private void BookListDataGrid_selectionChanged(object sender, EventArgs e)
        {
            if (SäljaListDataGrid.SelectedRows.Count < 1)
                return;
            var book = (Book)SäljaListDataGrid.SelectedRows[0].DataBoundItem;
            textBox1.Text = book.Pris;
            SäljaListDataGrid.ClearSelection();
            textBox1.Focus();
            textBox1.SelectAll();
        }
 
        */




        private void AddToTabelButton_Click(object sender, EventArgs e)
        {
            foreach(var book in lib.BookList)
            {
                if(book.Pris == textBox1.Text.Trim())
                {
                    listBox1.Items.Add(book);
                    //lib.SaveFile();
                }
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            foreach(var item in listBox1.Items)
            {
                var book = (Book)item;
                book.BoVale = true;
            }
            BookListSource.ResetBindings(false);
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox1.Focus();
            //lib.SaveFile();
        }

        
        private void radioFilm_CheckedChanged(object sender, EventArgs e)
        {
            SäljaListDataGrid.DataSource = lib.MovieList;
            if (SäljaListDataGrid.SelectedRows.Count < 1)
                return;
            var movie = (Filmer)SäljaListDataGrid.SelectedRows[0].DataBoundItem;
            textBox1.Text = movie.Pris;
            SäljaListDataGrid.ClearSelection();
            textBox1.Focus();
            textBox1.SelectAll();




        }


        private void FinishButonFilm_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                var film = (Filmer)item;
                film.BoVale = true;
            }
            FilmListSource.ResetBindings(false);
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox1.Focus();
          //  lib.SaveFileFilm();
        }


        private void FinishButonSpel_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                var spel = (DataSpel)item;
                spel.BoVale = true;
            }
            DataSpelSource.ResetBindings(false);
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox1.Focus();
           // lib.SaveFileSpel();
        }

        private void RadioBock_CheckedChanged_1(object sender, EventArgs e)
        {
           SäljaListDataGrid.DataSource = lib.BookList;
            if (SäljaListDataGrid.SelectedRows.Count < 1)
                return;
            var book = (Book)SäljaListDataGrid.SelectedRows[0].DataBoundItem;
            textBox1.Text = book.Pris;
            SäljaListDataGrid.ClearSelection();
            textBox1.Focus();
            textBox1.SelectAll();

        }

        private void AddMovieToTabelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
