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
    public partial class frmSingleAlbum : Form
    {
        public frmSingleAlbum()
        {
            InitializeComponent();
        }

        DBContext context = new DBContext();

        public Albums Album { get; set; }
        public Artists Artist { get; set; }

        private void frmSingleAlbum_Load(object sender, EventArgs e)
        {
            PopulateAlbumInfo();
            PopulateSongInfo();
        }

        private void PopulateAlbumInfo()
        {
            lblAlbumHeader.Text = Album.AlbumTitle;
            txtAlbumTitle.Text = Album.AlbumTitle;
            txtAlbumArtist.Text = Artist.StageName;
            txtAlbumRecordLabel.Text = Album.AlbumRecordLabel;
            txtAlbumGenre.Text = Album.AlbumGenre;
            txtReleaseDate.Text = Album.ReleaseDate.ToShortDateString();
            txtAlbumFact.Text = Album.AlbumFact;
        }

        private void PopulateSongInfo()
        {
            dgvAlbumSongs.DataSource = ( from album in context.Albums
                                         join song in context.Songs
                                            on album.AlbumId equals song.AlbumId
                                         join artist in context.Artists
                                            on song.ArtistId equals artist.ArtistId
                                         where album.AlbumId == Album.AlbumId
                                         orderby song.HighestBillboardRank
                                         select new
                                         {
                                             song.SongId,
                                             artist.ArtistId,
                                             album.AlbumId,
                                             song.SongTitle,
                                             song.SongWriter,
                                             song.HighestBillboardRank,
                                             song.LengthInSeconds
                                         }).ToList();

            dgvAlbumSongs.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica Neue", 14, FontStyle.Bold);
            dgvAlbumSongs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgvAlbumSongs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAlbumSongs.EnableHeadersVisualStyles = false;
            dgvAlbumSongs.DefaultCellStyle.Font = new Font("Helvetica Neue", 12);
            dgvAlbumSongs.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvAlbumSongs.RowsDefaultCellStyle.BackColor = Color.White;
            dgvAlbumSongs.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAlbumSongs.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;

            dgvAlbumSongs.Columns[0].Visible = false;
            dgvAlbumSongs.Columns[1].Visible = false;
            dgvAlbumSongs.Columns[2].Visible = false;
            dgvAlbumSongs.Columns[3].HeaderText = "Song Title";
            dgvAlbumSongs.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAlbumSongs.Columns[4].HeaderText = "Song Writer";
            dgvAlbumSongs.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAlbumSongs.Columns[5].HeaderText = "Top Rank";
            dgvAlbumSongs.Columns[5].Width = 100;
            dgvAlbumSongs.Columns[6].HeaderText = "Length";
            dgvAlbumSongs.Columns[6].Width = 100;

        }

        private void dgvAlbumSongs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the Song ID, the Artist ID, and the Album ID for the selected row
            int song_id = Convert.ToInt32(dgvAlbumSongs.Rows[e.RowIndex].Cells[0].Value);
            Songs selected_song = context.Songs.Find(song_id);
            int artist_id = Convert.ToInt32(dgvAlbumSongs.Rows[e.RowIndex].Cells[1].Value);
            Artists selected_artist = context.Artists.Find(artist_id);
            int album_id = Convert.ToInt32(dgvAlbumSongs.Rows[e.RowIndex].Cells[2].Value);
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
