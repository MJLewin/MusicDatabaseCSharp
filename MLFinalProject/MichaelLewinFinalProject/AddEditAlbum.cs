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
    public partial class frmAddEditAlbum : Form
    {
        public frmAddEditAlbum()
        {
            InitializeComponent();
        }

        DBContext context = new DBContext();

        public Albums Album { get; set; }
        public bool AddAlbum { get; set; }

        private void frmAddAlbum_Load(object sender, EventArgs e)
        {
            cbArtist.DataSource = context.Artists.OrderBy(a => a.StageName).ToList();
            cbArtist.ValueMember = "ArtistId";
            cbArtist.DisplayMember = "StageName";

            if (AddAlbum)
            {
                lblAddEditAlbumHeader.Text = "Add New Album";
                Album = new Albums();
            }
            else
            {
                lblAddEditAlbumHeader.Text = "Modify Album";
                DisplayAlbum();
            }
        }

        private void DisplayAlbum()
        {
            txtAlbumTitle.Text = Album.AlbumTitle;
            cbArtist.SelectedValue = Album.ArtistId;
            txtAlbumRecordLabel.Text = Album.AlbumRecordLabel;
            txtAlbumGenre.Text = Album.AlbumGenre;
            txtReleaseDate.Text = Album.ReleaseDate.ToString("MM/dd/yyyy");
            txtAlbumFact.Text = Album.AlbumFact;
        }

        private void ClearFields()
        {
            txtAlbumTitle.Text = "";
            cbArtist.SelectedValue = "";
            txtAlbumRecordLabel.Text = "";
            txtAlbumGenre.Text = "";
            txtReleaseDate.Text = "";
            txtAlbumFact.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Album.AlbumTitle = txtAlbumTitle.Text;
                Album.ArtistId = Convert.ToInt32(cbArtist.SelectedValue);
                Album.AlbumRecordLabel = txtAlbumRecordLabel.Text;
                Album.AlbumGenre = txtAlbumGenre.Text;
                Album.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
                Album.AlbumFact = txtAlbumFact.Text;

                if (AddAlbum)
                {
                    context.Albums.Add(Album);
                    context.SaveChanges();
                    ClearFields();
                    this.Hide();
                    MessageBox.Show("Success! New album added.");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
                
            }
            catch
            {
                MessageBox.Show("Error: Add new album failed. Please check your entries and try again.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
