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

                Book.Name = NamnText.Text;
                Book.Pris = PrisText.Text;
                Book.Språk = SpråkText.Text;
                Book.Genre = GenreText.Text;
                Book.Författare = FörfattareText.Text;
                Book.Format = FormatText.Text;
                Book.ID = Counter;


            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
