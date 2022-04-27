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


        private BindingSource BookListS;
        Library lib;
       

        public SäljaControll(Library liB, BindingSource bookListSource)
        {
            InitializeComponent();
            BookListS = bookListSource;
             BookListDataGrid.DataSource = bookListSource;
            lib = new Library();
            lib = liB;

            
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
                    lib.saveFile();
                }
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            foreach(var item in listBox1.Items)
            {
                var book = (Book)item;
                book.BoVale = radioLend.Checked;
            }
            BookListS.ResetBindings(false);
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioLend_CheckedChanged(object sender, EventArgs e)
        {
            FinishButon.Text = "Lend ";
        }

        private void RadioReturn_CheckedChanged(object sender, EventArgs e)
        {
            FinishButon.Text = "Return ";
        }
    }
}
