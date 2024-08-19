using MichaelLewinFinalProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MichaelLewinFinalProject
{
    public partial class frmAllAlbums : Form
    {
        public frmAllAlbums()
        {
            InitializeComponent();
        }

        DBContext context = new DBContext();

        Albums selected_album = null;

        readonly char[] space = new char[] { ' ' };
        const int EDITINDEX = 0;
        const int DELETEINDEX = 1;

        private void frmAllAlbums_Load(object sender, EventArgs e)
        {
            DisplayAlbums();
        }

        private void DisplayAlbums()
        {
            dgvAllAlbums.Columns.Clear();

            dgvAllAlbums.DataSource = (from album in context.Albums
                                       join artist in context.Artists
                                            on album.ArtistId equals artist.ArtistId
                                       orderby album.AlbumTitle
                                       select new
                                       {
                                            album.AlbumId,
                                            artist.ArtistId,
                                            album.AlbumTitle,
                                            artist.StageName,
                                            album.AlbumGenre,
                                            album.AlbumRecordLabel,
                                            album.ReleaseDate
                                       }).ToList();

            dgvAllAlbums.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica Neue", 14, FontStyle.Bold);
            dgvAllAlbums.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgvAllAlbums.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllAlbums.EnableHeadersVisualStyles = false;
            dgvAllAlbums.DefaultCellStyle.Font = new Font("Helvetica Neue", 12);
            dgvAllAlbums.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvAllAlbums.RowsDefaultCellStyle.BackColor = Color.White;
            dgvAllAlbums.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAllAlbums.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;

            DataGridViewButtonColumn edit_column = new DataGridViewButtonColumn();
            edit_column.HeaderText = "";
            edit_column.Text = "Edit";
            edit_column.UseColumnTextForButtonValue = true;
            edit_column.DisplayIndex = 7;
            dgvAllAlbums.Columns.Insert(EDITINDEX, edit_column);

            DataGridViewButtonColumn delete_column = new DataGridViewButtonColumn();
            delete_column.HeaderText = "";
            delete_column.Text = "Delete";
            delete_column.UseColumnTextForButtonValue = true;
            delete_column.DisplayIndex = 8;
            dgvAllAlbums.Columns.Insert(DELETEINDEX, delete_column);

            dgvAllAlbums.Columns[2].Visible = false;
            dgvAllAlbums.Columns[3].Visible = false;
            dgvAllAlbums.Columns[4].HeaderText = "Album Title";
            dgvAllAlbums.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAllAlbums.Columns[5].HeaderText = "Artist";
            dgvAllAlbums.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAllAlbums.Columns[6].HeaderText = "Genre";
            dgvAllAlbums.Columns[6].Width = 130;
            dgvAllAlbums.Columns[7].HeaderText = "Record Label";
            dgvAllAlbums.Columns[7].Width = 150;
            dgvAllAlbums.Columns[8].HeaderText = "Release Date";
            dgvAllAlbums.Columns[8].Width = 100;
            dgvAllAlbums.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void EditAlbum()
        {
            var frmEditAlbum = new frmAddEditAlbum()
            {
                AddAlbum = false,
                Album = selected_album
            };
            DialogResult result = frmEditAlbum.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selected_album = frmEditAlbum.Album;
                    context.SaveChanges();
                    MessageBox.Show("Success! Album has been updated successfully");
                }
                catch
                {
                    MessageBox.Show("Error: Album add/update failed. Please check your entries and try again.");
                }
                DisplayAlbums();
            }
            else
            {
                MessageBox.Show("Error: Album add/update failed. Please check your entries and try again.");
                frmEditAlbum.Close();
            }
        }

        private void DeleteAlbum()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selected_album.AlbumTitle.Trim()}? All songs on album will also be deleted.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                context.Albums.Remove(selected_album);
                context.SaveChanges(true);
                DisplayAlbums();
            }
        }

        private void dgvAllAlbums_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the Album ID and then the Artist ID for the selected row
            int album_id = Convert.ToInt32(dgvAllAlbums.Rows[e.RowIndex].Cells[2].Value);
            Albums selected_album = context.Albums.Find(album_id);
            int artist_id = Convert.ToInt32(dgvAllAlbums.Rows[e.RowIndex].Cells[3].Value);
            Artists selected_artist = context.Artists.Find(artist_id);

            // Generate a single album form and pass the selected album and artist as the context for the form
            frmSingleAlbum SingleAlbum = new frmSingleAlbum()
            {
                Album = selected_album,
                Artist = selected_artist
            };

            SingleAlbum.Show();
        }

        private void dgvAllAlbums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EDITINDEX || e.ColumnIndex == DELETEINDEX)
            {
                int album_id = Convert.ToInt32(dgvAllAlbums.Rows[e.RowIndex].Cells[2].Value);
                selected_album = context.Albums.Find(album_id);
            }
            if (e.ColumnIndex == EDITINDEX)
            {
                EditAlbum();
            }
            else if (e.ColumnIndex == DELETEINDEX)
            {
                DeleteAlbum();
            }
        }
    }

}
