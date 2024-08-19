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
    public partial class frmAllSongs : Form
    {
        public frmAllSongs()
        {
            InitializeComponent();
        }

        DBContext context = new DBContext();

        Songs selected_song = null;

        readonly char[] space = new char[] { ' ' };
        const int EDITINDEX = 0;
        const int DELETEINDEX = 1;

        private void frmAllSongs_Load(object sender, EventArgs e)
        {
            DisplaySongs();
        }

        private void DisplaySongs()
        {
            dgvAllSongs.Columns.Clear();

            dgvAllSongs.DataSource = (from song in context.Songs
                                      join artist in context.Artists
                                            on song.ArtistId equals artist.ArtistId
                                      join album in context.Albums
                                            on song.AlbumId equals album.AlbumId
                                      orderby song.SongTitle
                                      select new
                                      {
                                            song.SongId,
                                            artist.ArtistId,
                                            album.AlbumId,
                                            song.SongTitle,
                                            album.AlbumTitle,
                                            song.SongWriter
                                        }).ToList();


            dgvAllSongs.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica Neue", 14, FontStyle.Bold);
            dgvAllSongs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgvAllSongs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllSongs.EnableHeadersVisualStyles = false;
            dgvAllSongs.DefaultCellStyle.Font = new Font("Helvetica Neue", 12);
            dgvAllSongs.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvAllSongs.RowsDefaultCellStyle.BackColor = Color.White;
            dgvAllSongs.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAllSongs.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;

            DataGridViewButtonColumn edit_column = new DataGridViewButtonColumn();
            edit_column.HeaderText = "";
            edit_column.Text = "Edit";
            edit_column.UseColumnTextForButtonValue = true;
            edit_column.DisplayIndex = 6;
            dgvAllSongs.Columns.Insert(EDITINDEX, edit_column);

            DataGridViewButtonColumn delete_column = new DataGridViewButtonColumn();
            delete_column.HeaderText = "";
            delete_column.Text = "Delete";
            delete_column.UseColumnTextForButtonValue = true;
            delete_column.DisplayIndex = 7;
            dgvAllSongs.Columns.Insert(DELETEINDEX, delete_column);

            dgvAllSongs.Columns[2].Visible = false;
            dgvAllSongs.Columns[3].Visible = false;
            dgvAllSongs.Columns[4].Visible = false;
            dgvAllSongs.Columns[5].HeaderText = "Song Title";
            dgvAllSongs.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAllSongs.Columns[6].HeaderText = "Album";
            dgvAllSongs.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAllSongs.Columns[7].HeaderText = "Song Writer";
            dgvAllSongs.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void EditSong()
        {
            var frmEditSong = new frmAddEditSong()
            {
                AddSong = false,
                Song = selected_song
            };
            DialogResult result = frmEditSong.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selected_song = frmEditSong.Song;
                    context.SaveChanges();
                    MessageBox.Show("Success! Song has been updated successfully");
                }
                catch
                {
                    MessageBox.Show("Error: Song add/update failed. Please check your entries and try again.");
                }
                DisplaySongs();
            }
            else
            {
                MessageBox.Show("Error: Song add/update failed. Please check your entries and try again.");
                frmEditSong.Close();
            }
        }

        private void DeleteSong()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selected_song.SongTitle.Trim()}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                context.Songs.Remove(selected_song);
                context.SaveChanges(true);
                DisplaySongs();
            }
        }

        private void dgvAllSongs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the Song ID, the Artist ID, and the Album ID for the selected row
            int song_id = Convert.ToInt32(dgvAllSongs.Rows[e.RowIndex].Cells[2].Value);
            Songs selected_song = context.Songs.Find(song_id);
            int artist_id = Convert.ToInt32(dgvAllSongs.Rows[e.RowIndex].Cells[3].Value);
            Artists selected_artist = context.Artists.Find(artist_id);
            int album_id = Convert.ToInt32(dgvAllSongs.Rows[e.RowIndex].Cells[4].Value);
            Albums selected_album = context.Albums.Find(album_id);
            

            // Generate a single song form and pass the selected song, artist, and album as the context for the form
            frmSingleSong SingleSong = new frmSingleSong()
            {
                Song = selected_song,
                Artist = selected_artist,
                Album = selected_album
            };

            SingleSong.Show();
        }

        private void dgvAllSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EDITINDEX || e.ColumnIndex == DELETEINDEX)
            {
                int song_id = Convert.ToInt32(dgvAllSongs.Rows[e.RowIndex].Cells[2].Value);
                selected_song = context.Songs.Find(song_id);
            }
            if (e.ColumnIndex == EDITINDEX)
            {
                EditSong();
            }
            else if (e.ColumnIndex == DELETEINDEX)
            {
                DeleteSong();
            }
        }
    }
}
