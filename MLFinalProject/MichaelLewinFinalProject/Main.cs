using MichaelLewinFinalProject.Model;
using MichaelLewinFinalProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichaelLewinFinalProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        DBContext context = new DBContext();

        frmAllArtists AllArtistsView = new frmAllArtists() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
        frmAllAlbums AllAlbumsView = new frmAllAlbums() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
        frmAllSongs AllSongsView = new frmAllSongs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };

        frmAddEditArtist AddEditArtist = new frmAddEditArtist() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
        frmAddEditAlbum AddEditAlbum = new frmAddEditAlbum() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
        frmAddEditSong AddEditSong = new frmAddEditSong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };

        private void HideForms()
        {
            AllArtistsView.Hide();
            AllAlbumsView.Hide();
            AllSongsView.Hide();
            AddEditArtist.Hide();
            AddEditAlbum.Hide();
            AddEditSong.Hide();
        }

        private void ShowForm(Form form)
        {
            this.pContainer.Controls.Add(form);
            form.Show();
        }

        private void btnAllArtists_Click(object sender, EventArgs e)
        {
            HideForms();
            ShowForm(AllArtistsView);
        }

        private void btnAllAlbums_Click(object sender, EventArgs e)
        {
            HideForms();
            ShowForm(AllAlbumsView);
        }

        private void btnAllSongs_Click(object sender, EventArgs e)
        {
            HideForms();
            ShowForm(AllSongsView);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HideForms();
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            HideForms();
            AddEditArtist.AddArtist = true;
            ShowForm(AddEditArtist);
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            HideForms();
            AddEditAlbum.AddAlbum = true;
            ShowForm(AddEditAlbum);
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            HideForms();
            AddEditSong.AddSong = true;
            ShowForm(AddEditSong);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
