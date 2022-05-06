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
        BindingSource BookListSource;
        BindingSource DataSpellistSource;
        BindingSource FilmerlistSource;
        Library lib;

        public Kassa()
        {
            InitializeComponent();
            BookListSource = new BindingSource();
            DataSpellistSource = new BindingSource();
            FilmerlistSource = new BindingSource(); 


        }  

        private void Kassa_Load(object sender, EventArgs e)
        {
            SäljaControll säljaControll = new SäljaControll(BookListSource, DataSpellistSource, FilmerlistSource);
            säljaControll.Dock = DockStyle.Fill;
            SäljaTab1.Controls.Add(säljaControll);

            AcceptButton = säljaControll.AcceptButton;

        }

    }
}
