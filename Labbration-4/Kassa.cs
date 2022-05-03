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
            BookListSource = new BindingSource();
           
        }  

        private void Kassa_Load(object sender, EventArgs e)
        {
            SäljaControll säljaControll = new SäljaControll(lib,BookListSource);
            säljaControll.Dock = DockStyle.Fill;
            SäljaTab1.Controls.Add(säljaControll);

            AcceptButton = säljaControll.AcceptButton;

        }

    }
}
