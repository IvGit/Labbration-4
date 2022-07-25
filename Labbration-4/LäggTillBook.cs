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
        private int Counter;
        public LäggTillBook(int counter)
        {
            InitializeComponent();
            this.Counter=counter;
           
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
                Book = new Book();

                Book.name = NamnText.Text;
                Book.price = PrisText.Text;
                Book.language = SpråkText.Text;
                Book.genre = GenreText.Text;
                Book.format = FormatText.Text;
               // Book.id = Counter;


            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
