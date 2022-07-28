using System;
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

        public SäljaControll(BindingSource bookListSource, BindingSource filmerlistSource, BindingSource dataSpelSource)
        {
            InitializeComponent();
            lib = new Library();

            BookListSource = bookListSource;
            lib.LoadFileBooks();
          //  SäljaListDataGrid.DataSource = lib.BookList;


            FilmListSource = filmerlistSource;
            lib.LoadFileMovie();
           // SäljaListDataGrid.DataSource = lib.MovieList;
            

            DataSpelSource = dataSpelSource;
           lib.LoadFileGame();
            //SäljaListDataGrid.DataSource = lib.SpelList;

        }
        private void SäljaControll_Load(object sender, EventArgs e)
        {
            
            SäljaListDataGrid.ClearSelection();
            textBox1.Text = "";

        }
        private void AddToTabelButton_Click(object sender, EventArgs e)
        {
            foreach(var book in lib.BookList)
            {
                if(book.price == textBox1.Text.Trim())
                {
                    listBox1.Items.Add(book);
                    lib.SaveFile();
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
            lib.SaveFile();
        }
        private void radioFilm_CheckedChanged(object sender, EventArgs e)
        {
            SäljaListDataGrid.DataSource = lib.MovieList;
            if (SäljaListDataGrid.SelectedRows.Count < 1)
                return;
            var movie = (Filmer)SäljaListDataGrid.SelectedRows[0].DataBoundItem;
            textBox1.Text = movie.price;
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
            lib.LoadFile();
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
            lib.SaveFileGame();
        }

        private void RadioBock_CheckedChanged_1(object sender, EventArgs e)
        {
           SäljaListDataGrid.DataSource = lib.BookList;
            if (SäljaListDataGrid.SelectedRows.Count < 1)
                return;
            var book = (Book)SäljaListDataGrid.SelectedRows[0].DataBoundItem;
            textBox1.Text = book.price;
            SäljaListDataGrid.ClearSelection();
            textBox1.Focus();
            textBox1.SelectAll();

        }

        private void AddMovieToTabelButton_Click(object sender, EventArgs e)
        {
            foreach (var film in lib.MovieList)
            {
                if (film.price == textBox1.Text.Trim())
                {
                    listBox1.Items.Add(film);
                    lib.SaveFileMovie();
                }
            }
        }

        private void radioSpel_CheckedChanged(object sender, EventArgs e)
        {
            SäljaListDataGrid.DataSource = lib.SpelList;
            if (SäljaListDataGrid.SelectedRows.Count < 1)
                return;
            var spel = (DataSpel)SäljaListDataGrid.SelectedRows[0].DataBoundItem;
            textBox1.Text = spel.name;
            SäljaListDataGrid.ClearSelection();
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void AddSpelToTabelButton_Click(object sender, EventArgs e)
        {
            foreach (var spel in lib.SpelList)
            {
                if (spel.name == textBox1.Text.Trim())
                {
                    listBox1.Items.Add(spel);
                    lib.SaveFileGame();
                }
            }
        }
    }
}
