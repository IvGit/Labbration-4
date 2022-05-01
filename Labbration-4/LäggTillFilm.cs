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
            film.Name = NamnText.Text;
            film.Pris = PrisText.Text;
            film.Format = FormatText.Text;
            film.Speltid = SpeltidText.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
