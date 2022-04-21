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
    public partial class UserControl1 : UserControl
    {
        BindingSource DataSpelSource;
        public UserControl1(BindingSource dataSpelSource)
        {
            InitializeComponent();
            this.DataSpelSource = dataSpelSource;
            dataGridView1.DataSource = dataSpelSource;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
