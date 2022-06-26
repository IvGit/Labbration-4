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
            spel = new DataSpel();
            spel.name = NamnTextSpel.Text;
            spel.price = PrisTextSpel.Text;
            spel.platform = PlattformTextSpel.Text;
          //  spel.id = Counter;
            

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButtonSpel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
