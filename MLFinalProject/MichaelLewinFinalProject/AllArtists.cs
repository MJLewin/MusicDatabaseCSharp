using MichaelLewinFinalProject.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MichaelLewinFinalProject
{
    public partial class frmAllArtists : Form
    {
        public frmAllArtists()
        {
            InitializeComponent();
        }

        DBContext context = new DBContext();

        Artists selected_artist = null;

        readonly char[] space = new char[] { ' ' };
        const int EDITINDEX = 0;
        const int DELETEINDEX = 1;

        private void frmAllArtists_Load(object sender, EventArgs e)
        {
            DisplayArtists();
        }

        private void DisplayArtists()
        {
            dgvAllArtists.Columns.Clear();

            dgvAllArtists.DataSource = (from artist in context.Artists
                                        orderby artist.BirthName
                                        select new
                                        {
                                            artist.ArtistId,
                                            last_name = artist.BirthName.Split(space).Last(),
                                            artist.StageName,
                                            age = artist.DateOfDeath.HasValue ?
                                                (Convert.ToDateTime(artist.DateOfDeath).Year - artist.DateOfBirth.Year) :
                                                (DateTime.Today.Year - artist.DateOfBirth.Year),
                                            num_songs = artist.Songs.Count
                                        }).ToList();

            dgvAllArtists.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica Neue", 14, FontStyle.Bold);
            dgvAllArtists.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgvAllArtists.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllArtists.EnableHeadersVisualStyles = false;
            dgvAllArtists.DefaultCellStyle.Font = new Font("Helvetica Neue", 12);
            dgvAllArtists.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvAllArtists.RowsDefaultCellStyle.BackColor = Color.White;
            dgvAllArtists.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAllArtists.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;

            DataGridViewButtonColumn edit_column = new DataGridViewButtonColumn();
            edit_column.HeaderText = "";
            edit_column.Text = "Edit";
            edit_column.UseColumnTextForButtonValue = true;
            edit_column.DisplayIndex = 5;
            dgvAllArtists.Columns.Insert(EDITINDEX, edit_column);

            DataGridViewButtonColumn delete_column = new DataGridViewButtonColumn();
            delete_column.HeaderText = "";
            delete_column.Text = "Delete";
            delete_column.UseColumnTextForButtonValue = true;
            delete_column.DisplayIndex = 6;
            dgvAllArtists.Columns.Insert(DELETEINDEX, delete_column);

            dgvAllArtists.Columns[2].Visible = false;
            dgvAllArtists.Columns[3].HeaderText = "Last Name";
            dgvAllArtists.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAllArtists.Columns[4].HeaderText = "Stage Name";
            dgvAllArtists.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAllArtists.Columns[5].HeaderText = "Age";
            dgvAllArtists.Columns[5].Width = 120;
            dgvAllArtists.Columns[6].HeaderText = "Songs";
            dgvAllArtists.Columns[6].Width = 120;
        }

        private void EditArtist()
        {
            var frmEditArtist = new frmAddEditArtist()
            {
                AddArtist = false,
                Artist = selected_artist
            };
            DialogResult result = frmEditArtist.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selected_artist = frmEditArtist.Artist;
                    context.SaveChanges();
                    MessageBox.Show("Success! Artist has been updated successfully");
                }
                catch
                {
                    MessageBox.Show("Error: Artist add/update failed. Please check your entries and try again.");
                }
                DisplayArtists();
            }
            else
            {
                MessageBox.Show("Error: Artist add/update failed. Please check your entries and try again.");
                frmEditArtist.Close();
            }
        }

        private void DeleteArtist()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selected_artist.BirthName.Trim()}? All albums and songs by artist will also be deleted.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                context.Artists.Remove(selected_artist);
                context.SaveChanges(true);
                DisplayArtists();
            }
        }

        private void dgvAllArtists_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the Artist ID for the selected row
            int artist_id = Convert.ToInt32(dgvAllArtists.Rows[e.RowIndex].Cells[2].Value);
            Artists selected_artist = context.Artists.Find(artist_id);

            
            // Generate a single artist form and pass the selected artist as the context for the form
            frmSingleArtist SingleArtist = new frmSingleArtist()
            {
                Artist = selected_artist
            };

            SingleArtist.Show();
        }

        private void dgvAllArtists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EDITINDEX || e.ColumnIndex == DELETEINDEX)
            {
                int artist_id = Convert.ToInt32(dgvAllArtists.Rows[e.RowIndex].Cells[2].Value);
                selected_artist = context.Artists.Find(artist_id);
            }
            if (e.ColumnIndex == EDITINDEX)
            {
                EditArtist();
            }
            else if (e.ColumnIndex == DELETEINDEX)
            {
                DeleteArtist();
            }
        }
    }
}