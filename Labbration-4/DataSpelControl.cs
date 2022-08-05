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
        private int counter = 11243;
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
            PrisTextSpel.Text = spel.price.ToString();
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
            if (spel.stock > 1)
            {
                spel.stock--;
                SpelListSource.ResetBindings(true);
            }
            else
            {
                SpelListSource.Remove(spel);
                PlattformTextSpel.Text = "";
                PrisTextSpel.Text = "";
                NamnTextSpel.Text = "";
                SaveButton.Enabled = false;
                CancelButton.Enabled = false;
                SpelListDataGrid_SelectionChanged(sender, null);

            }
            lib.SaveFileGame();
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
            SelectedItem.name = NamnTextSpel.Text;
            SelectedItem.platform = PlattformTextSpel.Text;
            SelectedItem.price = int.Parse(PrisTextSpel.Text);
            SpelListSource.ResetCurrentItem();
            SpelListDataGrid_SelectionChanged(sender, null);
           lib.SaveFileGame();
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
                foreach (var sp in lib.SpelList)
                {
                    if (tillSpel.spel.name == sp.name)
                    {
                        stat = true;
                        sp.stock++;
                        SpelListSource.ResetBindings(true);
                        lib.SaveFileGame();


                    }
                }

                if (stat == false)
                {
                    counter++;
                    tillSpel.spel.id = counter;
                    tillSpel.spel.stock++;
                    SpelListSource.Add(tillSpel.spel);
                    lib.SaveFileGame();
                }
                stat = false;

            }
        }
    }
}
