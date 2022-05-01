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
    public partial class DataSpelControl : UserControl
    {
        BindingSource FilmSource;
        public DataSpelControl(BindingSource filmSource)
        {
            InitializeComponent();
            this.FilmSource = filmSource;
            FilmListDataGrid.DataSource = filmSource;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
