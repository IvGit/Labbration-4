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
    public partial class Kassa : Form
    {
       

       // BindingList<Book> BookList;
        BindingSource BookListSource;
        Library lib;

        public Kassa()
        {
            InitializeComponent();
          /*  BookList = new BindingList<Book>()
            {
                new Book()
                {
                    Name = "Ivan", Författare ="Hemingway", Format = "CD", Genre = "Drama", Pris = "150", Språk = "Engelska"
                },

                new Book()
                {
                    Name = "Iv", Författare ="Heming", Format = "", Genre = "Horro", Pris = "250", Språk = ""
                }
            };
             */
            BookListSource = new BindingSource();
            //BookListSource.DataSource = lib.BookList;
           
        }  

        private void Kassa_Load(object sender, EventArgs e)
        {
            SäljaControll säljaControll = new SäljaControll(lib,BookListSource);
            säljaControll.Dock = DockStyle.Fill;
            SäljaTab1.Controls.Add(säljaControll);

            AcceptButton = säljaControll.AcceptButton;

        }

        private void SäljaTab1_Click(object sender, EventArgs e)
        {

        }
    }
}
