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
    public partial class frmSingleArtist : Form
    {
        public frmSingleArtist()
        {
            InitializeComponent();
        }
        
        DBContext context = new DBContext();

        public Artists Artist { get; set; }

        private void frmSingleArtist_Load(object sender, EventArgs e)
        {
            //this.Location = this.Owner.Location;
            PopulateArtistInfo();
            PopulateSongInfo();
        }

        private void PopulateArtistInfo()
        {
            lblArtistHeader.Text = Artist.StageName;
            txtBirthName.Text = Artist.BirthName;
            txtStageName.Text = Artist.StageName;
            txtDateOfBirth.Text = Artist.DateOfBirth.ToShortDateString();
            txtHometown.Text = Artist.Hometown;
            txtDateOfDeath.Text = Artist.DateOfDeath != null ?  Artist.DateOfDeath.ToString() : "N/A" ;
            txtArtistFact.Text = Artist.ArtistFact;
        }

        private void PopulateSongInfo()
        {
            dgvArtistSongs.DataSource = (from artist in context.Artists
                                         join song in context.Songs
                                            on artist.ArtistId equals song.ArtistId
                                         join album in context.Albums
                                            on song.AlbumId equals album.AlbumId
                                         where artist.ArtistId == Artist.ArtistId
                                         orderby song.SongTitle
                                         select new
                                         {
                                             song.SongId,
                                             artist.ArtistId,
                                             album.AlbumId,
                                             song.SongTitle
                                         }).ToList();

            dgvArtistSongs.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica Neue", 14, FontStyle.Bold);
            dgvArtistSongs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgvArtistSongs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvArtistSongs.EnableHeadersVisualStyles = false;
            dgvArtistSongs.DefaultCellStyle.Font = new Font("Helvetica Neue", 12);
            dgvArtistSongs.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvArtistSongs.RowsDefaultCellStyle.BackColor = Color.White;
            dgvArtistSongs.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvArtistSongs.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;

            dgvArtistSongs.Columns[0].Visible = false;
            dgvArtistSongs.Columns[1].Visible = false;
            dgvArtistSongs.Columns[2].Visible = false;
            dgvArtistSongs.Columns[3].HeaderText = "Song Title";
            dgvArtistSongs.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void dgvArtistSongs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the Song ID, the Artist ID, and the Album ID for the selected row
            int song_id = Convert.ToInt32(dgvArtistSongs.Rows[e.RowIndex].Cells[0].Value);
            Songs selected_song = context.Songs.Find(song_id);
            int artist_id = Convert.ToInt32(dgvArtistSongs.Rows[e.RowIndex].Cells[1].Value);
            Artists selected_artist = context.Artists.Find(artist_id);
            int album_id = Convert.ToInt32(dgvArtistSongs.Rows[e.RowIndex].Cells[2].Value);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
