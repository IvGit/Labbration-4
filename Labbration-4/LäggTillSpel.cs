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
            try
            {
                string strname = NamnTextSpel.Text;
                string strplattform = PlattformTextSpel.Text;

                spel = new DataSpel();
                Boolean stat1 = strname.All(Char.IsLetter);
                Boolean stat2 = strplattform.All(Char.IsLetter);
                spel.price = int.Parse(PrisTextSpel.Text);

                if (stat1 == true && stat2 == true)
                {
                    spel.name = NamnTextSpel.Text;
                    spel.platform = PlattformTextSpel.Text;
                    DialogResult = DialogResult.OK;
                    Close();

                }
                else
                {
                    MessageBox.Show("Invalid input!!");

                }

            } catch
            {
                MessageBox.Show("Samthing happend");
              
            }
            
        }

       

        private void CancelButtonSpel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
