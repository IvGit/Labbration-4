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
    public partial class BöckerControll : UserControl
    {
        BindingSource BoookListSource;
        Book SelectedItem;
        Library lib;
        public int counter =1;
       
       


        private BindingSource bookListSource;
        private bool stat;

        public BöckerControll() { }
        public BöckerControll(Library liB, BindingSource bookListSource)
        {
            InitializeComponent();
           
            lib = liB;
            this.BoookListSource = bookListSource;
            BookDataGrid.DataSource = bookListSource;

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
            BookDataGrid_Selectionchanged(sender, null);
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
            LäggTillBook tillBook = new LäggTillBook(counter++);
            tillBook.StartPosition = FormStartPosition.CenterParent;  

           if(tillBook.ShowDialog() == DialogResult.OK)
           {
                foreach (var st in lib.BookList)
                {
                   if(tillBook.Book.name == st.name)
                    {
                        stat = true;
                      
                    }
                }

                if(stat==false)
                {
                    BoookListSource.Add(tillBook.Book);
                   // lib.SaveFile();
                }
                stat= false;

           }

           
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
            BookDataGrid_Selectionchanged(sender, null);
            //lib.SaveFile();
            lib.LoadFile();
        }

        

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SelectedItem.name = NamnText.Text;
            SelectedItem.genre = GenreText.Text;
            SelectedItem.language = SpråkText.Text;
            SelectedItem.format = FormatText.Text;
            SelectedItem.price = PrisText.Text;
            BookDataGrid_Selectionchanged(sender, null);
            lib.SaveFile();
        }

        private void BookDataGrid_Selectionchanged(object sender, EventArgs e)
        {
            if (BookDataGrid.SelectedRows.Count < 1)
            {
                SetTextEnabled(true);
                return;
            }

            var book = (Book)BookDataGrid.SelectedRows[0].DataBoundItem;
            NamnText.Text = book.name;
            GenreText.Text = book.genre;
            SpråkText.Text = book.language;
            FormatText.Text = book.format;
            PrisText.Text = book.price;
            SelectedItem = book;
            SaveButton.Enabled = false;
            CancelButton.Enabled = false;
        }

      
       
    }
}
