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
           
                spel = new DataSpel();
            try
            {
                
                    spel.name = NamnTextSpel.Text;

                  int strPrice = int.Parse(PrisTextSpel.Text);
                  spel.price = strPrice;

               
                    spel.platform = PlattformTextSpel.Text;

                DialogResult = DialogResult.OK;
                Close();



            }

            catch ( Exception) { MessageBox.Show("Input is invalid"); }


        }

       

        private void CancelButtonSpel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
