
namespace MichaelLewinFinalProject
{
    partial class frmSingleAlbum
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
            this.pAlbumContainer = new System.Windows.Forms.Panel();
            this.btnClose = new MichaelLewinFinalProject.View.ModernButton();
            this.lblAlbumFact = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblAlbumGenre = new System.Windows.Forms.Label();
            this.lblAlbumRecordLabel = new System.Windows.Forms.Label();
            this.lblAlbumArtist = new System.Windows.Forms.Label();
            this.lblAlbumTitle = new System.Windows.Forms.Label();
            this.txtAlbumFact = new System.Windows.Forms.TextBox();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.txtAlbumGenre = new System.Windows.Forms.TextBox();
            this.txtAlbumRecordLabel = new System.Windows.Forms.TextBox();
            this.txtAlbumArtist = new System.Windows.Forms.TextBox();
            this.txtAlbumTitle = new System.Windows.Forms.TextBox();
            this.dgvAlbumSongs = new System.Windows.Forms.DataGridView();
            this.lblAlbumHeader = new System.Windows.Forms.Label();
            this.pAlbumContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // pAlbumContainer
            // 
            this.pAlbumContainer.Controls.Add(this.btnClose);
            this.pAlbumContainer.Controls.Add(this.lblAlbumFact);
            this.pAlbumContainer.Controls.Add(this.lblReleaseDate);
            this.pAlbumContainer.Controls.Add(this.lblAlbumGenre);
            this.pAlbumContainer.Controls.Add(this.lblAlbumRecordLabel);
            this.pAlbumContainer.Controls.Add(this.lblAlbumArtist);
            this.pAlbumContainer.Controls.Add(this.lblAlbumTitle);
            this.pAlbumContainer.Controls.Add(this.txtAlbumFact);
            this.pAlbumContainer.Controls.Add(this.txtReleaseDate);
            this.pAlbumContainer.Controls.Add(this.txtAlbumGenre);
            this.pAlbumContainer.Controls.Add(this.txtAlbumRecordLabel);
            this.pAlbumContainer.Controls.Add(this.txtAlbumArtist);
            this.pAlbumContainer.Controls.Add(this.txtAlbumTitle);
            this.pAlbumContainer.Controls.Add(this.dgvAlbumSongs);
            this.pAlbumContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pAlbumContainer.Location = new System.Drawing.Point(0, 107);
            this.pAlbumContainer.Name = "pAlbumContainer";
            this.pAlbumContainer.Size = new System.Drawing.Size(830, 600);
            this.pAlbumContainer.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(637, 523);
            this.btnClose.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnClose.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnClose.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnClose.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnClose.Name = "btnClose";
            this.btnClose.ShowButtontext = true;
            this.btnClose.Size = new System.Drawing.Size(144, 50);
            this.btnClose.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.TextLocation_X = 47;
            this.btnClose.TextLocation_Y = 21;
            this.btnClose.Transparent1 = 175;
            this.btnClose.Transparent2 = 50;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAlbumFact
            // 
            this.lblAlbumFact.AutoSize = true;
            this.lblAlbumFact.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumFact.ForeColor = System.Drawing.Color.White;
            this.lblAlbumFact.Location = new System.Drawing.Point(442, 94);
            this.lblAlbumFact.Name = "lblAlbumFact";
            this.lblAlbumFact.Size = new System.Drawing.Size(116, 25);
            this.lblAlbumFact.TabIndex = 24;
            this.lblAlbumFact.Text = "Album Fact:";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDate.ForeColor = System.Drawing.Color.White;
            this.lblReleaseDate.Location = new System.Drawing.Point(442, 25);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(128, 25);
            this.lblReleaseDate.TabIndex = 23;
            this.lblReleaseDate.Text = "Release Date:";
            // 
            // lblAlbumGenre
            // 
            this.lblAlbumGenre.AutoSize = true;
            this.lblAlbumGenre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumGenre.ForeColor = System.Drawing.Color.White;
            this.lblAlbumGenre.Location = new System.Drawing.Point(22, 232);
            this.lblAlbumGenre.Name = "lblAlbumGenre";
            this.lblAlbumGenre.Size = new System.Drawing.Size(71, 25);
            this.lblAlbumGenre.TabIndex = 22;
            this.lblAlbumGenre.Text = "Genre:";
            // 
            // lblAlbumRecordLabel
            // 
            this.lblAlbumRecordLabel.AutoSize = true;
            this.lblAlbumRecordLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumRecordLabel.ForeColor = System.Drawing.Color.White;
            this.lblAlbumRecordLabel.Location = new System.Drawing.Point(22, 163);
            this.lblAlbumRecordLabel.Name = "lblAlbumRecordLabel";
            this.lblAlbumRecordLabel.Size = new System.Drawing.Size(132, 25);
            this.lblAlbumRecordLabel.TabIndex = 21;
            this.lblAlbumRecordLabel.Text = "Record Label:";
            // 
            // lblAlbumArtist
            // 
            this.lblAlbumArtist.AutoSize = true;
            this.lblAlbumArtist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumArtist.ForeColor = System.Drawing.Color.White;
            this.lblAlbumArtist.Location = new System.Drawing.Point(22, 94);
            this.lblAlbumArtist.Name = "lblAlbumArtist";
            this.lblAlbumArtist.Size = new System.Drawing.Size(66, 25);
            this.lblAlbumArtist.TabIndex = 20;
            this.lblAlbumArtist.Text = "Artist:";
            // 
            // lblAlbumTitle
            // 
            this.lblAlbumTitle.AutoSize = true;
            this.lblAlbumTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumTitle.ForeColor = System.Drawing.Color.White;
            this.lblAlbumTitle.Location = new System.Drawing.Point(22, 25);
            this.lblAlbumTitle.Name = "lblAlbumTitle";
            this.lblAlbumTitle.Size = new System.Drawing.Size(119, 25);
            this.lblAlbumTitle.TabIndex = 19;
            this.lblAlbumTitle.Text = "Album Title:";
            // 
            // txtAlbumFact
            // 
            this.txtAlbumFact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlbumFact.Location = new System.Drawing.Point(605, 94);
            this.txtAlbumFact.Multiline = true;
            this.txtAlbumFact.Name = "txtAlbumFact";
            this.txtAlbumFact.ReadOnly = true;
            this.txtAlbumFact.Size = new System.Drawing.Size(200, 167);
            this.txtAlbumFact.TabIndex = 18;
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReleaseDate.Location = new System.Drawing.Point(605, 25);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.ReadOnly = true;
            this.txtReleaseDate.Size = new System.Drawing.Size(200, 29);
            this.txtReleaseDate.TabIndex = 17;
            // 
            // txtAlbumGenre
            // 
            this.txtAlbumGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlbumGenre.Location = new System.Drawing.Point(185, 232);
            this.txtAlbumGenre.Name = "txtAlbumGenre";
            this.txtAlbumGenre.ReadOnly = true;
            this.txtAlbumGenre.Size = new System.Drawing.Size(200, 29);
            this.txtAlbumGenre.TabIndex = 16;
            // 
            // txtAlbumRecordLabel
            // 
            this.txtAlbumRecordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlbumRecordLabel.Location = new System.Drawing.Point(185, 163);
            this.txtAlbumRecordLabel.Name = "txtAlbumRecordLabel";
            this.txtAlbumRecordLabel.ReadOnly = true;
            this.txtAlbumRecordLabel.Size = new System.Drawing.Size(200, 29);
            this.txtAlbumRecordLabel.TabIndex = 15;
            // 
            // txtAlbumArtist
            // 
            this.txtAlbumArtist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlbumArtist.Location = new System.Drawing.Point(185, 94);
            this.txtAlbumArtist.Name = "txtAlbumArtist";
            this.txtAlbumArtist.ReadOnly = true;
            this.txtAlbumArtist.Size = new System.Drawing.Size(200, 29);
            this.txtAlbumArtist.TabIndex = 14;
            // 
            // txtAlbumTitle
            // 
            this.txtAlbumTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlbumTitle.Location = new System.Drawing.Point(185, 25);
            this.txtAlbumTitle.Name = "txtAlbumTitle";
            this.txtAlbumTitle.ReadOnly = true;
            this.txtAlbumTitle.Size = new System.Drawing.Size(200, 29);
            this.txtAlbumTitle.TabIndex = 13;
            // 
            // dgvAlbumSongs
            // 
            this.dgvAlbumSongs.AllowUserToAddRows = false;
            this.dgvAlbumSongs.AllowUserToDeleteRows = false;
            this.dgvAlbumSongs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvAlbumSongs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAlbumSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlbumSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumSongs.Location = new System.Drawing.Point(22, 294);
            this.dgvAlbumSongs.Name = "dgvAlbumSongs";
            this.dgvAlbumSongs.ReadOnly = true;
            this.dgvAlbumSongs.RowTemplate.Height = 25;
            this.dgvAlbumSongs.Size = new System.Drawing.Size(783, 200);
            this.dgvAlbumSongs.TabIndex = 1;
            this.dgvAlbumSongs.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlbumSongs_RowHeaderMouseClick);
            // 
            // lblAlbumHeader
            // 
            this.lblAlbumHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumHeader.ForeColor = System.Drawing.Color.White;
            this.lblAlbumHeader.Location = new System.Drawing.Point(0, 39);
            this.lblAlbumHeader.Name = "lblAlbumHeader";
            this.lblAlbumHeader.Size = new System.Drawing.Size(830, 45);
            this.lblAlbumHeader.TabIndex = 1;
            this.lblAlbumHeader.Text = "Album";
            this.lblAlbumHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSingleAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(830, 707);
            this.ControlBox = false;
            this.Controls.Add(this.lblAlbumHeader);
            this.Controls.Add(this.pAlbumContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSingleAlbum";
            this.Text = "SingleAlbum";
            this.Load += new System.EventHandler(this.frmSingleAlbum_Load);
            this.pAlbumContainer.ResumeLayout(false);
            this.pAlbumContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumSongs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pAlbumContainer;
        private System.Windows.Forms.Label lblAlbumHeader;
        private System.Windows.Forms.DataGridView dgvAlbumSongs;
        private System.Windows.Forms.Label lblAlbumFact;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblAlbumGenre;
        private System.Windows.Forms.Label lblAlbumRecordLabel;
        private System.Windows.Forms.Label lblAlbumArtist;
        private System.Windows.Forms.Label lblAlbumTitle;
        private System.Windows.Forms.TextBox txtAlbumFact;
        private System.Windows.Forms.TextBox txtReleaseDate;
        private System.Windows.Forms.TextBox txtAlbumGenre;
        private System.Windows.Forms.TextBox txtAlbumRecordLabel;
        private System.Windows.Forms.TextBox txtAlbumArtist;
        private System.Windows.Forms.TextBox txtAlbumTitle;
        private View.ModernButton btnClose;
    }
}