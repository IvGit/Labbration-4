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
            NamnTextSpel.Text = spel.Name;
            PlattformTextSpel.Text = spel.Platform;
            PrisTextSpel.Text = spel.Pris;
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
            SelectedItem.Platform = PlattformTextSpel.Text;
            SelectedItem.Pris = PrisTextSpel.Text;
            SelectedItem.Name = NamnTextSpel.Text;
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
            LäggTillSpel tillSpel = new LäggTillSpel();
            tillSpel.StartPosition = FormStartPosition.CenterParent;
            if (tillSpel.ShowDialog() == DialogResult.OK)
            {
                SpelListSource.Add(tillSpel.spel);
                lib.SaveFileGame();
            }
            {

            }
        }
    }
}
