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

        public Button AcceptButton { get { return AddToTabelButton; } }

        private BindingList<Book> BookList;
        Library lib;
        private BindingList<DataSpel> DataspelList;
        private BindingSource BookListSource;
        private BindingSource DataSpelSource;

        public SäljaControll(Library liB, BindingSource bookListSource)
        {
            InitializeComponent();
            BookListSource = bookListSource;
            BookListDataGrid.DataSource = bookListSource;
            lib = new Library();
            lib.LoadFile();


        }


        private void SäljaControll_Load(object sender, EventArgs e)
        {
            
            BookListDataGrid.ClearSelection();
            textBox1.Text = "";

        }

        private void BookListDataGrid_selectionChanged(object sender, EventArgs e)
        {
            if (BookListDataGrid.SelectedRows.Count < 1)
                return;
            var book = (Book)BookListDataGrid.SelectedRows[0].DataBoundItem;
            textBox1.Text = book.Genre;
            BookListDataGrid.ClearSelection();
            //textBox1.Focus();
            textBox1.SelectAll();
        }

        private void AddToTabelButton_Click(object sender, EventArgs e)
        {
            foreach(var book in (BindingList<Book>)BookListSource.DataSource)
            {
                if(book.Genre == textBox1.Text.Trim())
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
                book.BoVale = radioFilm.Checked;
            }
            BookListSource.ResetBindings(false);
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox1.Focus();
            lib.SaveFile();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioBock_CheckedChanged(object sender, EventArgs e)
        {
            BookList = new BindingList<Book>()
            {
                new Book()
                {
                    Name = "Ivan", Författare ="Hemingway", Format = "CD", Genre = "Drama", Pris = "150", Språk = "Engelska"
                }
            };
            BookListDataGrid.DataSource = BookList;

        }

        private void radioFilm_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
