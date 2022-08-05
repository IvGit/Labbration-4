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
    public partial class LäggTillBook : Form
    {
        internal Book Book { get; private set; }
       
        public LäggTillBook()
        {
            InitializeComponent();
           
           
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close(); 
        }

        private void Lägtill_load(object sender, EventArgs e)
        {
      
        }

        private void SparaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Book = new Book();
                string strname = NamnText.Text;
                string strGenre = GenreText.Text;
                string strformat = FormatText.Text;
                string strWriter = FörfattareText.Text;
                string strLang = SpråkText.Text;


                Boolean stat1 = strname.All(Char.IsLetter);
                Boolean stat2 = strGenre.All(Char.IsLetter);
                Boolean stat3 = strformat.All(Char.IsLetter);
                Boolean stat4 = strWriter.All(Char.IsLetter);
                Boolean stat5 = strLang.All(Char.IsLetter);
                Book.price = int.Parse(PrisText.Text);



                if (stat1 == true && stat2 == true && stat3 == true && stat5 == true&& stat5 == true)
                {
                    Book.name = NamnText.Text;
                    Book.genre = GenreText.Text;
                    Book.format = FormatText.Text;
                    Book.writer = FörfattareText.Text;
                    Book.language= SpråkText.Text;
                    DialogResult = DialogResult.OK;
                    Close();

                }
                else
                {
                    MessageBox.Show("Invalid input!!");

                }

            }
            catch
            {
                MessageBox.Show("Samthing happend");

            }



        }

    }
}
