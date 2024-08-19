using MichaelLewinFinalProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MichaelLewinFinalProject
{
    public partial class frmAddEditArtist : Form
    {
        public frmAddEditArtist()
        {
            InitializeComponent();
        }

        DBContext context = new DBContext();

        public Artists Artist { get; set; }
        public bool AddArtist { get; set; }

        private void frmAddArtist_Load(object sender, EventArgs e)
        {
            if (AddArtist)
            {
                lblAddEditArtistHeader.Text = "Add New Artist";
                Artist = new Artists();
            }
            else
            {
                lblAddEditArtistHeader.Text = "Modify Artist";
                DisplayArtist();
            }
        }

        private void DisplayArtist()
        {
            txtBirthName.Text = Artist.BirthName.ToString();
            txtStageName.Text = Artist.StageName.ToString();
            txtDateOfBirth.Text = Artist.DateOfBirth.ToString("MM/dd/yyyy");
            txtHometown.Text = Artist.Hometown.ToString();
            txtDateOfDeath.Text = Artist.DateOfDeath.ToString();
            txtArtistFact.Text = Artist.ArtistFact.ToString();
        }

        private void ClearFields()
        {
            txtBirthName.Text = "";
            txtStageName.Text = "";
            txtDateOfBirth.Text = "";
            txtHometown.Text = "";
            txtDateOfDeath.Text = "";
            txtArtistFact.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime dt;

            try
            {
                Artist.StageName = txtStageName.Text;
                Artist.BirthName = txtBirthName.Text;
                if (DateTime.TryParse(txtDateOfBirth.Text, out dt))
                {
                    Artist.DateOfBirth = dt;
                }
                else
                {
                    //Close();
                }
                Artist.Hometown = txtHometown.Text;
                if (DateTime.TryParse(txtDateOfDeath.Text, out dt))
                {
                    Artist.DateOfDeath = dt;
                }
                else
                {
                    Artist.DateOfDeath = null;
                }
                Artist.ArtistFact = txtArtistFact.Text;
                if (AddArtist)
                {
                    context.Artists.Add(Artist);
                    context.SaveChanges();
                    ClearFields();
                    this.Hide();
                    MessageBox.Show("Success! New artist added.");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
                
            }
            catch
            {
                MessageBox.Show("Error: Artist add/update failed. Please check your entries and try again.");
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
