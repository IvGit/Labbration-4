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
    public partial class LagerTabs : Form
    {
        BindingList <Filmer> FilmerList;
        BindingList<Book> BookList;
        BindingList<DataSpel> DataspelList;

        BindingSource FilmSource;
        BindingSource DataSpelSource;
        BindingSource BookListSource;
        Library lib;
        public LagerTabs()
        {
            InitializeComponent();
            lib = new Library();
           /* BookList = new BindingList<Book>() 
            
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
            DataspelList = new BindingList<DataSpel>()
            {
                new DataSpel() { Name = "Halo", Plattform = "PS3", Pris = "9000"},
                new DataSpel() { Name ="dota", Pris= "445", Plattform="XBOX"}
            };


            BookListSource = new BindingSource();
            BookListSource.DataSource = lib.BookList;

            DataSpelSource = new BindingSource();
            DataSpelSource.DataSource = DataspelList;

          



            FilmerList = new BindingList<Filmer>()
            {
                new Filmer()
                {
                    Namn =" nycklen till frihet", Pris = "99",Format = "DVD", Speltid =" 142"
                }
            };

            FilmSource = new BindingSource();
            FilmSource.DataSource = FilmerList;



        }

        private void Lager_Load(object sender, EventArgs e)
        {
            påLagerControll pålager = new påLagerControll(BookListSource);
            pålager.Dock = DockStyle.Fill;
            BokTab.Controls.Add(pålager);

            UserControl1 cl = new UserControl1(DataSpelSource);
            cl.Dock = DockStyle.Fill;   
            DataSpelTab.Controls.Add(cl);


            UserControl2 control2 = new UserControl2(FilmSource);
            control2.Dock = DockStyle.Fill;
            FilmTab.Controls.Add(control2);

        }

        private void BokTab_Click(object sender, EventArgs e)
        {

        }

        private void FilmTab_Click(object sender, EventArgs e)
        {

        }

        private void DataSpelTab_Click(object sender, EventArgs e)
        {

        }
    }
}
