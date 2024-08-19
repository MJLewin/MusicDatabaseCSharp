
namespace MichaelLewinFinalProject
{
    partial class frmAddEditSong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new MichaelLewinFinalProject.View.ModernButton();
            this.lblDateOfRank = new System.Windows.Forms.Label();
            this.lblHighestRank = new System.Windows.Forms.Label();
            this.txtDateOfRank = new System.Windows.Forms.TextBox();
            this.txtHighestRank = new System.Windows.Forms.TextBox();
            this.lblUserComment = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblSongWriter = new System.Windows.Forms.Label();
            this.lblSongAlbum = new System.Windows.Forms.Label();
            this.lblSongArtist = new System.Windows.Forms.Label();
            this.lblSongTitle = new System.Windows.Forms.Label();
            this.txtUserComment = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtSongWriter = new System.Windows.Forms.TextBox();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.lblAddEditSongHeader = new System.Windows.Forms.Label();
            this.btnSave = new MichaelLewinFinalProject.View.ModernButton();
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderWidth = 2;
            this.btnCancel.ButtonShape = MichaelLewinFinalProject.View.ModernButton.ButtonsShapes.RoundRect;
            this.btnCancel.ButtonText = "";
            this.btnCancel.EndColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.GradientAngle = 90;
            this.btnCancel.Location = new System.Drawing.Point(517, 578);
            this.btnCancel.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnCancel.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnCancel.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnCancel.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShowButtontext = true;
            this.btnCancel.Size = new System.Drawing.Size(144, 50);
            this.btnCancel.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextLocation_X = 47;
            this.btnCancel.TextLocation_Y = 21;
            this.btnCancel.Transparent1 = 175;
            this.btnCancel.Transparent2 = 50;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDateOfRank
            // 
            this.lblDateOfRank.AutoSize = true;
            this.lblDateOfRank.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfRank.ForeColor = System.Drawing.Color.White;
            this.lblDateOfRank.Location = new System.Drawing.Point(18, 519);
            this.lblDateOfRank.Name = "lblDateOfRank";
            this.lblDateOfRank.Size = new System.Drawing.Size(133, 25);
            this.lblDateOfRank.TabIndex = 45;
            this.lblDateOfRank.Text = "Date of Rank:";
            // 
            // lblHighestRank
            // 
            this.lblHighestRank.AutoSize = true;
            this.lblHighestRank.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHighestRank.ForeColor = System.Drawing.Color.White;
            this.lblHighestRank.Location = new System.Drawing.Point(18, 441);
            this.lblHighestRank.Name = "lblHighestRank";
            this.lblHighestRank.Size = new System.Drawing.Size(222, 25);
            this.lblHighestRank.TabIndex = 44;
            this.lblHighestRank.Text = "Highest Billboard Rank:";
            // 
            // txtDateOfRank
            // 
            this.txtDateOfRank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateOfRank.Location = new System.Drawing.Point(269, 515);
            this.txtDateOfRank.Name = "txtDateOfRank";
            this.txtDateOfRank.Size = new System.Drawing.Size(200, 29);
            this.txtDateOfRank.TabIndex = 43;
            // 
            // txtHighestRank
            // 
            this.txtHighestRank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHighestRank.Location = new System.Drawing.Point(269, 437);
            this.txtHighestRank.Name = "txtHighestRank";
            this.txtHighestRank.Size = new System.Drawing.Size(200, 29);
            this.txtHighestRank.TabIndex = 42;
            // 
            // lblUserComment
            // 
            this.lblUserComment.AutoSize = true;
            this.lblUserComment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserComment.ForeColor = System.Drawing.Color.White;
            this.lblUserComment.Location = new System.Drawing.Point(512, 83);
            this.lblUserComment.Name = "lblUserComment";
            this.lblUserComment.Size = new System.Drawing.Size(149, 25);
            this.lblUserComment.TabIndex = 41;
            this.lblUserComment.Text = "User Comment:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLength.ForeColor = System.Drawing.Color.White;
            this.lblLength.Location = new System.Drawing.Point(18, 359);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(180, 25);
            this.lblLength.TabIndex = 40;
            this.lblLength.Text = "Length in Seconds:";
            // 
            // lblSongWriter
            // 
            this.lblSongWriter.AutoSize = true;
            this.lblSongWriter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSongWriter.ForeColor = System.Drawing.Color.White;
            this.lblSongWriter.Location = new System.Drawing.Point(18, 290);
            this.lblSongWriter.Name = "lblSongWriter";
            this.lblSongWriter.Size = new System.Drawing.Size(127, 25);
            this.lblSongWriter.TabIndex = 39;
            this.lblSongWriter.Text = "Song Writer:";
            // 
            // lblSongAlbum
            // 
            this.lblSongAlbum.AutoSize = true;
            this.lblSongAlbum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSongAlbum.ForeColor = System.Drawing.Color.White;
            this.lblSongAlbum.Location = new System.Drawing.Point(18, 221);
            this.lblSongAlbum.Name = "lblSongAlbum";
            this.lblSongAlbum.Size = new System.Drawing.Size(76, 25);
            this.lblSongAlbum.TabIndex = 38;
            this.lblSongAlbum.Text = "Album:";
            // 
            // lblSongArtist
            // 
            this.lblSongArtist.AutoSize = true;
            this.lblSongArtist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSongArtist.ForeColor = System.Drawing.Color.White;
            this.lblSongArtist.Location = new System.Drawing.Point(18, 152);
            this.lblSongArtist.Name = "lblSongArtist";
            this.lblSongArtist.Size = new System.Drawing.Size(66, 25);
            this.lblSongArtist.TabIndex = 37;
            this.lblSongArtist.Text = "Artist:";
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.AutoSize = true;
            this.lblSongTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSongTitle.ForeColor = System.Drawing.Color.White;
            this.lblSongTitle.Location = new System.Drawing.Point(18, 83);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(107, 25);
            this.lblSongTitle.TabIndex = 36;
            this.lblSongTitle.Text = "Song Title:";
            // 
            // txtUserComment
            // 
            this.txtUserComment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserComment.Location = new System.Drawing.Point(512, 128);
            this.txtUserComment.Multiline = true;
            this.txtUserComment.Name = "txtUserComment";
            this.txtUserComment.Size = new System.Drawing.Size(236, 260);
            this.txtUserComment.TabIndex = 35;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLength.Location = new System.Drawing.Point(269, 359);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(200, 29);
            this.txtLength.TabIndex = 34;
            // 
            // txtSongWriter
            // 
            this.txtSongWriter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSongWriter.Location = new System.Drawing.Point(181, 290);
            this.txtSongWriter.Name = "txtSongWriter";
            this.txtSongWriter.Size = new System.Drawing.Size(288, 29);
            this.txtSongWriter.TabIndex = 33;
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSongTitle.Location = new System.Drawing.Point(181, 83);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(288, 29);
            this.txtSongTitle.TabIndex = 30;
            // 
            // lblAddEditSongHeader
            // 
            this.lblAddEditSongHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddEditSongHeader.ForeColor = System.Drawing.Color.White;
            this.lblAddEditSongHeader.Location = new System.Drawing.Point(0, 19);
            this.lblAddEditSongHeader.Name = "lblAddEditSongHeader";
            this.lblAddEditSongHeader.Size = new System.Drawing.Size(778, 45);
            this.lblAddEditSongHeader.TabIndex = 47;
            this.lblAddEditSongHeader.Text = "Song";
            this.lblAddEditSongHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderWidth = 2;
            this.btnSave.ButtonShape = MichaelLewinFinalProject.View.ModernButton.ButtonsShapes.RoundRect;
            this.btnSave.ButtonText = "";
            this.btnSave.EndColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.GradientAngle = 90;
            this.btnSave.Location = new System.Drawing.Point(96, 578);
            this.btnSave.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnSave.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnSave.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnSave.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnSave.Name = "btnSave";
            this.btnSave.ShowButtontext = true;
            this.btnSave.Size = new System.Drawing.Size(144, 50);
            this.btnSave.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.TextLocation_X = 47;
            this.btnSave.TextLocation_Y = 21;
            this.btnSave.Transparent1 = 175;
            this.btnSave.Transparent2 = 50;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbArtist
            // 
            this.cbArtist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(181, 152);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(288, 29);
            this.cbArtist.TabIndex = 49;
            // 
            // cbAlbum
            // 
            this.cbAlbum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(181, 221);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(288, 29);
            this.cbAlbum.TabIndex = 50;
            // 
            // frmAddEditSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(778, 653);
            this.ControlBox = false;
            this.Controls.Add(this.cbAlbum);
            this.Controls.Add(this.cbArtist);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddEditSongHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDateOfRank);
            this.Controls.Add(this.lblHighestRank);
            this.Controls.Add(this.txtDateOfRank);
            this.Controls.Add(this.txtHighestRank);
            this.Controls.Add(this.lblUserComment);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblSongWriter);
            this.Controls.Add(this.lblSongAlbum);
            this.Controls.Add(this.lblSongArtist);
            this.Controls.Add(this.lblSongTitle);
            this.Controls.Add(this.txtUserComment);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtSongWriter);
            this.Controls.Add(this.txtSongTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditSong";
            this.Text = "Add Song";
            this.Load += new System.EventHandler(this.frmAddSong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private View.ModernButton btnCancel;
        private System.Windows.Forms.Label lblDateOfRank;
        private System.Windows.Forms.Label lblHighestRank;
        private System.Windows.Forms.TextBox txtDateOfRank;
        private System.Windows.Forms.TextBox txtHighestRank;
        private System.Windows.Forms.Label lblUserComment;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblSongWriter;
        private System.Windows.Forms.Label lblSongAlbum;
        private System.Windows.Forms.Label lblSongArtist;
        private System.Windows.Forms.Label lblSongTitle;
        private System.Windows.Forms.TextBox txtUserComment;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtSongWriter;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.Label lblAddEditSongHeader;
        private View.ModernButton btnSave;
        private System.Windows.Forms.ComboBox cbArtist;
        private System.Windows.Forms.ComboBox cbAlbum;
    }
}