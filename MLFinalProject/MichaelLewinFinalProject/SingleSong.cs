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
    public partial class frmSingleSong : Form
    {
        public frmSingleSong()
        {
            InitializeComponent();
        }

        DBContext context = new DBContext();

        public Songs Song { get; set; }
        public Albums Album { get; set; }
        public Artists Artist { get; set; }

        private void frmSingleSong_Load(object sender, EventArgs e)
        {
            PopulateSongInfo();
        }

        private void PopulateSongInfo()
        {
            lblSongHeader.Text = Song.SongTitle;
            txtSongTitle.Text = Song.SongTitle;
            txtSongArtist.Text = Artist.StageName;
            txtSongAlbum.Text = Album.AlbumTitle;
            txtSongWriter.Text = Song.SongWriter;
            txtLength.Text = Song.LengthInSeconds.ToString();
            txtHighestRank.Text = Song.HighestBillboardRank != 0 ? Song.HighestBillboardRank.ToString() : "-";
            txtDateOfRank.Text = Song.DateOfHighestRank.HasValue ? Song.DateOfHighestRank.ToString().Split(" ").First() : "-";
            txtUserComment.Text = Song.UserComment;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSongTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSongAlbum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSongWriter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHighestRank_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDateOfRank_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserComment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
