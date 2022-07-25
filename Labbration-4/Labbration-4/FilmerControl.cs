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
    public partial class FilmerControl : UserControl
    {
        BindingSource MovieListSource;
        Filmer SelectedItem;
        private BindingSource movieListSource;
        Library lib;
        public FilmerControl(Library liB, BindingSource movieListSource)
        {
            InitializeComponent();
            lib = liB;
            this.MovieListSource = movieListSource;
            FilmDataGrid.DataSource = movieListSource;

        }


        private void SetTextEnabled(Boolean stat)
        {
            FormatText.Enabled = stat;
            PrisText.Enabled = stat;
            NamnText.Enabled = stat;
            SpeltidText.Enabled = stat;


        }

        private void läggTutton_Click(object sender, EventArgs e)
        {
            LäggTillFilm tillFilm = new LäggTillFilm();
            tillFilm.StartPosition = FormStartPosition.CenterParent;
            if (tillFilm.ShowDialog() == DialogResult.OK)
            {
                MovieListSource.Add(tillFilm.film);
                lib.SaveFileMovie();
                
            }
            {

            }
        }

        private void RaderaButton_Click(object sender, EventArgs e)
        {
            if (FilmDataGrid.SelectedRows.Count < 1)
                return;
            var film = (Filmer)FilmDataGrid.SelectedRows[0].DataBoundItem;
            MovieListSource.Remove(film);
            
            PrisText.Text = "";
            FormatText.Text = "";
            SpeltidText.Text = "";
            NamnText.Text = "";
            SaveButton.Enabled = false;
            CancelButton.Enabled = false;
            FilmDataGrid_SelectionChangedd(sender, null);
            // SetTextEnabled(false);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
           
            SelectedItem.Format = FormatText.Text;
            SelectedItem.Pris = PrisText.Text;
            SelectedItem.Name = NamnText.Text;
            SelectedItem.Playtime= SpeltidText.Text;
            MovieListSource.ResetCurrentItem();
            FilmDataGrid_SelectionChangedd(sender, null);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            FilmDataGrid_SelectionChangedd(sender, null);
        }

        private void NamnText_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void PrisText_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void FormatText_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void SpeltidText_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            CancelButton.Enabled = true;
        }

        private void FilmDataGrid_SelectionChangedd(object sender, EventArgs e)
        {
            if (FilmDataGrid.SelectedRows.Count < 1)
            {
                SetTextEnabled(true);
                return;
            }

            var film = (Filmer)FilmDataGrid.SelectedRows[0].DataBoundItem;
            NamnText.Text = film.Name;
            PrisText.Text = film.Pris;
            SpeltidText.Text = film.Playtime;
            FormatText.Text = film.Format;

            SelectedItem = film;
            SaveButton.Enabled = false;
            CancelButton.Enabled = false;
        }
    }
}
