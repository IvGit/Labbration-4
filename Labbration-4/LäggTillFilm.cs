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
    public partial class LäggTillFilm : Form
    {
        internal Filmer film { get; private set; }
        public LäggTillFilm()
        {
            InitializeComponent();
        }

        private void SparaFilm_Click(object sender, EventArgs e)
        {
            film = new Filmer();
           
          
            film.format = FormatText.Text;
          

            try
            {
                string strname = NamnText.Text;
                string strformat = FormatText.Text;


                film = new Filmer();
                Boolean stat1 = strname.All(Char.IsLetter);
                Boolean stat2 = strformat.All(Char.IsLetter);
                film.price = int.Parse(PrisText.Text);
                film.playtime = int.Parse(SpeltidText.Text);


                if (stat1 == true && stat2 == true)
                {
                    film.name = NamnText.Text;
                    film.format = FormatText.Text;

                    DialogResult = DialogResult.OK;
                    Close();

                }
                else
                {
                    MessageBox.Show("Invalid movie input!!");

                }

            }
            catch
            {
                MessageBox.Show("Samthing happend Moive input");

            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
