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

        BindingList<Book> BookList;
        BindingSource BookListSource;

        BindingList<DataSpel> DataspelList;
        BindingSource DataSpelSource;

        BindingList<Filmer> FilmlList;
        BindingSource FilmListSource;

        public SäljaControll(BindingSource bookListSource, BindingSource dataSpellistSource, BindingSource filmerlistSource)
        {
            InitializeComponent();
            lib = new Library();
            BookListSource = bookListSource;
            SäljaListDataGrid.DataSource = bookListSource;
            lib.LoadFile();


            DataSpelSource = dataSpellistSource;
            SäljaListDataGrid.DataSource= dataSpellistSource;
            lib.SaveFileSpel();


            FilmListSource = filmerlistSource;
            SäljaListDataGrid.DataSource = filmerlistSource;
            lib.SaveFileFilm();






        }


        private void SäljaControll_Load(object sender, EventArgs e)
        {
            
            SäljaListDataGrid.ClearSelection();
            textBox1.Text = "";

        }

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

        private void SpelListDataGrid_selectionChanged(object sender, EventArgs e)
        {
            if (SäljaListDataGrid.SelectedRows.Count < 1)
                return;
            var spel = (DataSpel)SäljaListDataGrid.SelectedRows[0].DataBoundItem;
            textBox1.Text = spel.Pris;
            SäljaListDataGrid.ClearSelection();
            textBox1.Focus();
            textBox1.SelectAll();
        }





        private void AddToTabelButton_Click(object sender, EventArgs e)
        {
            foreach(var book in lib.BookList)
            {
                if(book.Pris == textBox1.Text.Trim())
                {
                    listBox1.Items.Add(book);
                    lib.SaveFileBook();
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
            lib.SaveFileBook();
        }


        private void RadioBock_CheckedChanged(object sender, EventArgs e)
        {
            SäljaListDataGrid.DataSource = lib.BookList;

        }

        private void radioFilm_CheckedChanged(object sender, EventArgs e)
        {
            SäljaListDataGrid.DataSource = lib.FilmList;
                

        }

        private void radioSpel_CheckedChanged(object sender, EventArgs e)
        {
            SäljaListDataGrid.DataSource = lib.SpelList;

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
            lib.SaveFileFilm();
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
            lib.SaveFileSpel();
        }
    }
}
