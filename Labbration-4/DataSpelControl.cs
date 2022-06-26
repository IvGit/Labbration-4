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
        BindingSource SpelListSource;
        private BindingSource spelListSource;
        DataSpel SelectedItem;
        Library lib;
        private int counter=1;
        private bool stat;

        public DataSpelControl(Library liB,BindingSource spelListSource)
        {
            InitializeComponent();
            lib = liB;
            this.SpelListSource = spelListSource;
            SpelListDataGrid.DataSource = spelListSource;
        }

        private void SpelListDataGrid_SelectionChanged(object sender, EventArgs e)

        {
            if (SpelListDataGrid.SelectedRows.Count < 1)
            {
                SetTextEnabled(true);
                return;
            }

            var spel = (DataSpel)SpelListDataGrid.SelectedRows[0].DataBoundItem;
            NamnTextSpel.Text = spel.name;
            PlattformTextSpel.Text = spel.platform;
            PrisTextSpel.Text = spel.price;
            SelectedItem = spel;
            SaveButton.Enabled = false;
            CancelButton.Enabled = false;


        }

        private void SetTextEnabled(Boolean stat)
        {
            PlattformTextSpel.Enabled = stat;
            PrisTextSpel.Enabled = stat;
            NamnTextSpel.Enabled = stat;
        }

        private void RaderaButtonSpel_Click(object sender, EventArgs e)
        {
            if (SpelListDataGrid.SelectedRows.Count < 1)
                return;
            var spel = (DataSpel)SpelListDataGrid.SelectedRows[0].DataBoundItem;
            SpelListSource.Remove(spel);
            PlattformTextSpel.Text = "";
            PrisTextSpel.Text = "";
            NamnTextSpel.Text = "";
            SaveButton.Enabled = false;
            CancelButton.Enabled = false;
            SpelListDataGrid_SelectionChanged(sender, null);
          //  lib.SaveFileSpel();
            // SetTextEnabled(false);
        }

        private void NamnTextSpel_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void PrisTextSpel_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void PlattformTextSpel_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void SaveButtonSpel_Click(object sender, EventArgs e)
        {
            SelectedItem.platform = PlattformTextSpel.Text;
            SelectedItem.price = PrisTextSpel.Text;
            SelectedItem.name = NamnTextSpel.Text;
            SpelListSource.ResetCurrentItem();
            SpelListDataGrid_SelectionChanged(sender, null);
           // lib.SaveFileSpel();
        }

        

        private void CancelButtonSpel_Click(object sender, EventArgs e)
        {
            SpelListDataGrid_SelectionChanged(sender, null);
        }

        private void läggTuttonSpel_Click_1(object sender, EventArgs e)
        {
            LäggTillSpel tillSpel = new LäggTillSpel(counter++);
            tillSpel.StartPosition = FormStartPosition.CenterParent;
            if (tillSpel.ShowDialog() == DialogResult.OK)
            {
                foreach (var sp in lib.SpelList)
                {
                    if (tillSpel.spel.name == sp.name)
                    {
                        stat = true;

                    }
                }

                if (stat == false)
                {
                    SpelListSource.Add(tillSpel.spel);
                    lib.SaveFileGame();
                }
                stat = false;

            }
        }
    }
}
