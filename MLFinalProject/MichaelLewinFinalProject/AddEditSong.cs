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
    public partial class frmAddEditSong : Form
    {
        public frmAddEditSong()
        {
            InitializeComponent();
        }

        DBContext context = new DBContext();

        public Songs Song { get; set; }
        public bool AddSong { get; set; }

        private void frmAddSong_Load(object sender, EventArgs e)
        {
            cbArtist.DataSource = context.Artists.OrderBy(a => a.StageName).ToList();
            cbArtist.ValueMember = "ArtistId";
            cbArtist.DisplayMember = "StageName";

            cbAlbum.DataSource = context.Albums.OrderBy(a => a.AlbumTitle).ToList();
            cbAlbum.ValueMember = "AlbumId";
            cbAlbum.DisplayMember = "AlbumTitle";

            if (AddSong)
            {
                lblAddEditSongHeader.Text = "Add New Song";
                Song = new Songs();
            }
            else
            {
                lblAddEditSongHeader.Text = "Modify Song";
                DisplaySong();
            }
        }

        private void DisplaySong()
        {
            txtSongTitle.Text = Song.SongTitle;
            cbArtist.SelectedValue = Song.ArtistId;
            cbAlbum.SelectedValue = Song.AlbumId;
            txtLength.Text = Song.LengthInSeconds.ToString();
            txtHighestRank.Text = Song.HighestBillboardRank.ToString();
            txtDateOfRank.Text = Song.DateOfHighestRank.ToString();
            txtSongWriter.Text = Song.SongWriter;
            txtUserComment.Text = Song.UserComment;
        }

        private void ClearFields()
        {
            txtSongTitle.Text = "";
            cbArtist.SelectedValue = "";
            cbAlbum.SelectedValue = "";
            txtLength.Text = "";
            txtHighestRank.Text = "";
            txtDateOfRank.Text = "";
            txtSongWriter.Text = "";
            txtUserComment.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Song.SongTitle = txtSongTitle.Text;
                Song.ArtistId = Convert.ToInt32(cbArtist.SelectedValue);
                Song.AlbumId = Convert.ToInt32(cbAlbum.SelectedValue);
                Song.LengthInSeconds = Convert.ToInt32(txtLength.Text);
                if (txtHighestRank.Text == "" || !Int32.TryParse(txtHighestRank.Text, out int text))
                {
                    Song.HighestBillboardRank = null;
                }
                else
                {
                    Song.HighestBillboardRank = Convert.ToInt32(txtHighestRank.Text);
                }
                if (txtDateOfRank.Text == "")
                {
                    Song.DateOfHighestRank = null;
                }
                else
                {
                    Song.DateOfHighestRank = Convert.ToDateTime(txtDateOfRank.Text);
                }
                Song.SongWriter = txtSongWriter.Text;
                Song.UserComment = txtUserComment.Text;

                if (AddSong)
                {
                    context.Songs.Add(Song);
                    context.SaveChanges();
                    ClearFields();
                    this.Hide();
                    MessageBox.Show("Success! New song added.");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("Error: Add new song failed. Please check your entries and try again.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
