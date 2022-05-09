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
       // BindingList <Filmer> FilmerList;
       // BindingList<Book> BookList;
        BindingList<DataSpel> DataspelList;

        BindingSource MovieListSource;
        BindingSource DataSpelSource;
        BindingSource BookListSource;
        Library lib;

      
        public LagerTabs()
        {
            InitializeComponent();
            lib = new Library();

            BookListSource = new BindingSource();
            lib.SaveFile();
            BookListSource.DataSource = lib.BookList;
            //lib.LoadFile();


            MovieListSource = new BindingSource();
            lib.SaveFileMovie();
            MovieListSource.DataSource = lib.MovieList;



            DataSpelSource = new BindingSource();
            DataSpelSource.DataSource = lib.SpelList;

        }

        private void Lager_Load(object sender, EventArgs e)
        {
            //lib.SaveFile();
            BöckerControll c1= new BöckerControll(lib,BookListSource);
            c1.Dock = DockStyle.Fill;
            BokTab.Controls.Add(c1);

            FilmerControl c2 = new FilmerControl(lib, MovieListSource);
            c2.Dock = DockStyle.Fill;   
            FilmTab.Controls.Add(c2);

   
            DataSpelControl c3 = new DataSpelControl(lib,DataSpelSource);
            c3.Dock = DockStyle.Fill;
            DataSpelTab.Controls.Add(c3);

            

          





        }

    }
}
