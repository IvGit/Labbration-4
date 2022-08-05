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
        private int countBuy = 0;

        BindingSource BookListSource;
        BindingSource DataSpelSource;
        BindingSource FilmListSource;

        public SäljaControll(BindingSource bookListSource, BindingSource filmerlistSource, BindingSource dataSpelSource)
        {
            InitializeComponent();
            lib = new Library();

            BookListSource = bookListSource;    
            lib.LoadFileBooks();
          // SäljaListDataGrid.DataSource = lib.BookList;


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
        
        private void FinishButton_Click(object sender, EventArgs e)
        {
            countBuy++;
            foreach (var item in listBox1.Items)
            {
                var book = (Book)item;
                //book.stock--;
                if(book.stock == 0)
                {
                    book.finished = true;
                    MessageBox.Show("Sorry! The Book is sold out!!");
                   // book.stock--;
                }


                else if(book.finished == false)
                {
                    MessageBox.Show("Thank you for your Order, ", $"{countBuy} an email is sent to you!");
                    book.stock--;

                }
               

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
            textBox1.Text = movie.name;
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
            lib.SaveFileMovie();
          
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
            textBox1.Text = book.name;
            SäljaListDataGrid.ClearSelection();
            textBox1.Focus();
            textBox1.SelectAll();
           

        }

        private void AddMovieToTabelButton_Click(object sender, EventArgs e)
        {
            FilmListSource.DataSource = lib.MovieList;
            var film2 = (Filmer)SäljaListDataGrid.SelectedRows[0].DataBoundItem;
            textBox1.Text = film2.name;
            foreach (var film in (BindingList<Filmer>)FilmListSource.DataSource)
            {
                SäljaListDataGrid.ClearSelection();
                textBox1.Focus();
                textBox1.SelectAll();
                if (film.name== textBox1.Text.Trim() && film.BoVale != true)
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
            DataSpelSource.DataSource = lib.SpelList;
            var spel2 = (DataSpel)SäljaListDataGrid.SelectedRows[0].DataBoundItem;
            textBox1.Text = spel2.name;

            foreach (var spel in (BindingList<DataSpel>)DataSpelSource.DataSource)
            {
                SäljaListDataGrid.ClearSelection();
                textBox1.Focus();
                textBox1.SelectAll();
                if (spel.name == textBox1.Text.Trim() && spel.BoVale != true)
                {
                    listBox1.Items.Add(spel);
                    lib.SaveFileGame();
                }
            }
        }

        private void AddBookToTabelButton_Click(object sender, EventArgs e)
        {
            
            BookListSource.DataSource = lib.BookList;
            var book2 = (Book)SäljaListDataGrid.SelectedRows[0].DataBoundItem;
            textBox1.Text = book2.name;

            foreach (var book in (BindingList<Book>)BookListSource.DataSource)
            {
                SäljaListDataGrid.ClearSelection();
                textBox1.Focus();
                textBox1.SelectAll();

                if (book.name == textBox1.Text.Trim() && book.finished != true)
                {
                    listBox1.Items.Add(book);
                    lib.SaveFile();
                }
            }
        }

        
        private void SäljaListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SäljaListDataGrid.SelectedRows.Count < 1)
            {
                SetTextEnabled(true);
                return;
            }

           // var book2 = (Book)SäljaListDataGrid.SelectedRows[0].DataBoundItem;
           // textBox1.Text = book2.name;

        }



        private void SetTextEnabled(Boolean stat)
        {
            textBox1.Enabled = stat;
           
        }
    }
}
