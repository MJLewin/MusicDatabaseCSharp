
namespace MichaelLewinFinalProject
{
    partial class frmSingleSong
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
            this.pSongContainer = new System.Windows.Forms.Panel();
            this.btnClose = new MichaelLewinFinalProject.View.ModernButton();
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
            this.txtSongAlbum = new System.Windows.Forms.TextBox();
            this.txtSongArtist = new System.Windows.Forms.TextBox();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.dgvAlbumSongs = new System.Windows.Forms.DataGridView();
            this.lblSongHeader = new System.Windows.Forms.Label();
            this.pSongContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // pSongContainer
            // 
            this.pSongContainer.Controls.Add(this.btnClose);
            this.pSongContainer.Controls.Add(this.lblDateOfRank);
            this.pSongContainer.Controls.Add(this.lblHighestRank);
            this.pSongContainer.Controls.Add(this.txtDateOfRank);
            this.pSongContainer.Controls.Add(this.txtHighestRank);
            this.pSongContainer.Controls.Add(this.lblUserComment);
            this.pSongContainer.Controls.Add(this.lblLength);
            this.pSongContainer.Controls.Add(this.lblSongWriter);
            this.pSongContainer.Controls.Add(this.lblSongAlbum);
            this.pSongContainer.Controls.Add(this.lblSongArtist);
            this.pSongContainer.Controls.Add(this.lblSongTitle);
            this.pSongContainer.Controls.Add(this.txtUserComment);
            this.pSongContainer.Controls.Add(this.txtLength);
            this.pSongContainer.Controls.Add(this.txtSongWriter);
            this.pSongContainer.Controls.Add(this.txtSongAlbum);
            this.pSongContainer.Controls.Add(this.txtSongArtist);
            this.pSongContainer.Controls.Add(this.txtSongTitle);
            this.pSongContainer.Controls.Add(this.dgvAlbumSongs);
            this.pSongContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pSongContainer.Location = new System.Drawing.Point(0, 107);
            this.pSongContainer.Name = "pSongContainer";
            this.pSongContainer.Size = new System.Drawing.Size(830, 600);
            this.pSongContainer.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderWidth = 2;
            this.btnClose.ButtonShape = MichaelLewinFinalProject.View.ModernButton.ButtonsShapes.RoundRect;
            this.btnClose.ButtonText = "";
            this.btnClose.EndColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.GradientAngle = 90;
            this.btnClose.Location = new System.Drawing.Point(587, 436);
            this.btnClose.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnClose.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnClose.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnClose.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnClose.Name = "btnClose";
            this.btnClose.ShowButtontext = true;
            this.btnClose.Size = new System.Drawing.Size(144, 50);
            this.btnClose.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.TextLocation_X = 47;
            this.btnClose.TextLocation_Y = 21;
            this.btnClose.Transparent1 = 175;
            this.btnClose.Transparent2 = 50;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDateOfRank
            // 
            this.lblDateOfRank.AutoSize = true;
            this.lblDateOfRank.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfRank.ForeColor = System.Drawing.Color.White;
            this.lblDateOfRank.Location = new System.Drawing.Point(22, 461);
            this.lblDateOfRank.Name = "lblDateOfRank";
            this.lblDateOfRank.Size = new System.Drawing.Size(133, 25);
            this.lblDateOfRank.TabIndex = 28;
            this.lblDateOfRank.Text = "Date of Rank:";
            // 
            // lblHighestRank
            // 
            this.lblHighestRank.AutoSize = true;
            this.lblHighestRank.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHighestRank.ForeColor = System.Drawing.Color.White;
            this.lblHighestRank.Location = new System.Drawing.Point(22, 383);
            this.lblHighestRank.Name = "lblHighestRank";
            this.lblHighestRank.Size = new System.Drawing.Size(222, 25);
            this.lblHighestRank.TabIndex = 27;
            this.lblHighestRank.Text = "Highest Billboard Rank:";
            // 
            // txtDateOfRank
            // 
            this.txtDateOfRank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateOfRank.Location = new System.Drawing.Point(273, 457);
            this.txtDateOfRank.Name = "txtDateOfRank";
            this.txtDateOfRank.ReadOnly = true;
            this.txtDateOfRank.Size = new System.Drawing.Size(200, 29);
            this.txtDateOfRank.TabIndex = 26;
            this.txtDateOfRank.TextChanged += new System.EventHandler(this.txtDateOfRank_TextChanged);
            // 
            // txtHighestRank
            // 
            this.txtHighestRank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHighestRank.Location = new System.Drawing.Point(273, 379);
            this.txtHighestRank.Name = "txtHighestRank";
            this.txtHighestRank.ReadOnly = true;
            this.txtHighestRank.Size = new System.Drawing.Size(200, 29);
            this.txtHighestRank.TabIndex = 25;
            this.txtHighestRank.TextChanged += new System.EventHandler(this.txtHighestRank_TextChanged);
            // 
            // lblUserComment
            // 
            this.lblUserComment.AutoSize = true;
            this.lblUserComment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserComment.ForeColor = System.Drawing.Color.White;
            this.lblUserComment.Location = new System.Drawing.Point(540, 25);
            this.lblUserComment.Name = "lblUserComment";
            this.lblUserComment.Size = new System.Drawing.Size(149, 25);
            this.lblUserComment.TabIndex = 24;
            this.lblUserComment.Text = "User Comment:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLength.ForeColor = System.Drawing.Color.White;
            this.lblLength.Location = new System.Drawing.Point(22, 301);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(180, 25);
            this.lblLength.TabIndex = 23;
            this.lblLength.Text = "Length in Seconds:";
            // 
            // lblSongWriter
            // 
            this.lblSongWriter.AutoSize = true;
            this.lblSongWriter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSongWriter.ForeColor = System.Drawing.Color.White;
            this.lblSongWriter.Location = new System.Drawing.Point(22, 232);
            this.lblSongWriter.Name = "lblSongWriter";
            this.lblSongWriter.Size = new System.Drawing.Size(127, 25);
            this.lblSongWriter.TabIndex = 22;
            this.lblSongWriter.Text = "Song Writer:";
            // 
            // lblSongAlbum
            // 
            this.lblSongAlbum.AutoSize = true;
            this.lblSongAlbum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSongAlbum.ForeColor = System.Drawing.Color.White;
            this.lblSongAlbum.Location = new System.Drawing.Point(22, 163);
            this.lblSongAlbum.Name = "lblSongAlbum";
            this.lblSongAlbum.Size = new System.Drawing.Size(76, 25);
            this.lblSongAlbum.TabIndex = 21;
            this.lblSongAlbum.Text = "Album:";
            // 
            // lblSongArtist
            // 
            this.lblSongArtist.AutoSize = true;
            this.lblSongArtist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSongArtist.ForeColor = System.Drawing.Color.White;
            this.lblSongArtist.Location = new System.Drawing.Point(22, 94);
            this.lblSongArtist.Name = "lblSongArtist";
            this.lblSongArtist.Size = new System.Drawing.Size(66, 25);
            this.lblSongArtist.TabIndex = 20;
            this.lblSongArtist.Text = "Artist:";
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.AutoSize = true;
            this.lblSongTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSongTitle.ForeColor = System.Drawing.Color.White;
            this.lblSongTitle.Location = new System.Drawing.Point(22, 25);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(107, 25);
            this.lblSongTitle.TabIndex = 19;
            this.lblSongTitle.Text = "Song Title:";
            // 
            // txtUserComment
            // 
            this.txtUserComment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserComment.Location = new System.Drawing.Point(540, 70);
            this.txtUserComment.Multiline = true;
            this.txtUserComment.Name = "txtUserComment";
            this.txtUserComment.ReadOnly = true;
            this.txtUserComment.Size = new System.Drawing.Size(236, 260);
            this.txtUserComment.TabIndex = 18;
            this.txtUserComment.TextChanged += new System.EventHandler(this.txtUserComment_TextChanged);
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLength.Location = new System.Drawing.Point(273, 301);
            this.txtLength.Name = "txtLength";
            this.txtLength.ReadOnly = true;
            this.txtLength.Size = new System.Drawing.Size(200, 29);
            this.txtLength.TabIndex = 17;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // txtSongWriter
            // 
            this.txtSongWriter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSongWriter.Location = new System.Drawing.Point(185, 232);
            this.txtSongWriter.Name = "txtSongWriter";
            this.txtSongWriter.ReadOnly = true;
            this.txtSongWriter.Size = new System.Drawing.Size(288, 29);
            this.txtSongWriter.TabIndex = 16;
            this.txtSongWriter.TextChanged += new System.EventHandler(this.txtSongWriter_TextChanged);
            // 
            // txtSongAlbum
            // 
            this.txtSongAlbum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSongAlbum.Location = new System.Drawing.Point(185, 163);
            this.txtSongAlbum.Name = "txtSongAlbum";
            this.txtSongAlbum.ReadOnly = true;
            this.txtSongAlbum.Size = new System.Drawing.Size(288, 29);
            this.txtSongAlbum.TabIndex = 15;
            this.txtSongAlbum.TextChanged += new System.EventHandler(this.txtSongAlbum_TextChanged);
            // 
            // txtSongArtist
            // 
            this.txtSongArtist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSongArtist.Location = new System.Drawing.Point(185, 94);
            this.txtSongArtist.Name = "txtSongArtist";
            this.txtSongArtist.ReadOnly = true;
            this.txtSongArtist.Size = new System.Drawing.Size(288, 29);
            this.txtSongArtist.TabIndex = 14;
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSongTitle.Location = new System.Drawing.Point(185, 25);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.ReadOnly = true;
            this.txtSongTitle.Size = new System.Drawing.Size(288, 29);
            this.txtSongTitle.TabIndex = 13;
            this.txtSongTitle.TextChanged += new System.EventHandler(this.txtSongTitle_TextChanged);
            // 
            // dgvAlbumSongs
            // 
            this.dgvAlbumSongs.AllowUserToAddRows = false;
            this.dgvAlbumSongs.AllowUserToDeleteRows = false;
            this.dgvAlbumSongs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvAlbumSongs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAlbumSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlbumSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumSongs.Location = new System.Drawing.Point(337, 804);
            this.dgvAlbumSongs.Name = "dgvAlbumSongs";
            this.dgvAlbumSongs.ReadOnly = true;
            this.dgvAlbumSongs.RowTemplate.Height = 25;
            this.dgvAlbumSongs.Size = new System.Drawing.Size(783, 268);
            this.dgvAlbumSongs.TabIndex = 1;
            // 
            // lblSongHeader
            // 
            this.lblSongHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSongHeader.ForeColor = System.Drawing.Color.White;
            this.lblSongHeader.Location = new System.Drawing.Point(0, 39);
            this.lblSongHeader.Name = "lblSongHeader";
            this.lblSongHeader.Size = new System.Drawing.Size(830, 45);
            this.lblSongHeader.TabIndex = 2;
            this.lblSongHeader.Text = "Song";
            this.lblSongHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSingleSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(830, 707);
            this.ControlBox = false;
            this.Controls.Add(this.lblSongHeader);
            this.Controls.Add(this.pSongContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSingleSong";
            this.Text = "SingleSong";
            this.Load += new System.EventHandler(this.frmSingleSong_Load);
            this.pSongContainer.ResumeLayout(false);
            this.pSongContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumSongs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSongContainer;
        private System.Windows.Forms.Label lblUserComment;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblSongWriter;
        private System.Windows.Forms.Label lblSongAlbum;
        private System.Windows.Forms.Label lblSongArtist;
        private System.Windows.Forms.Label lblSongTitle;
        private System.Windows.Forms.TextBox txtUserComment;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtSongWriter;
        private System.Windows.Forms.TextBox txtSongAlbum;
        private System.Windows.Forms.TextBox txtSongArtist;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.DataGridView dgvAlbumSongs;
        private System.Windows.Forms.Label lblDateOfRank;
        private System.Windows.Forms.Label lblHighestRank;
        private System.Windows.Forms.TextBox txtDateOfRank;
        private System.Windows.Forms.TextBox txtHighestRank;
        private System.Windows.Forms.Label lblSongHeader;
        private View.ModernButton btnClose;
    }
}