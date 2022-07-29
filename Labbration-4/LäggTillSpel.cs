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
    public partial class LäggTillSpel : Form
    {
        internal DataSpel spel { get; private set; }
        private int Counter;

        public LäggTillSpel(int counter)
        {
            InitializeComponent();
            this.Counter = counter;
        }

        private void SparaFilm_Click(object sender, EventArgs e)
        {
            int number;
            string strname = NamnTextSpel.Text;
            string strplattform = PlattformTextSpel.Text;   
       
            spel = new DataSpel();
            Boolean stat1 = strname.All(Char.IsLetter);
            Boolean stat2 = strplattform.All(Char.IsLetter);
            Boolean stat3 = int.TryParse(PrisTextSpel.Text, out number);

            if (stat3 == true && stat1 == true && stat2 == true)
            {
                spel.name = NamnTextSpel.Text;
                spel.platform = PlattformTextSpel.Text;
                spel.price = int.Parse(PrisTextSpel.Text);
                DialogResult = DialogResult.OK;
                Close();
            }

            else
            {
                MessageBox.Show("Input is invalid");
                Close();
            }
        }

       

        private void CancelButtonSpel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
