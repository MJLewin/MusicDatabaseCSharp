
namespace MichaelLewinFinalProject
{
    partial class frmAddEditAlbum
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
            this.txtAlbumTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new MichaelLewinFinalProject.View.ModernButton();
            this.lblAddEditAlbumHeader = new System.Windows.Forms.Label();
            this.cbArtist = new System.Windows.Forms.ComboBox();
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
            this.btnCancel.Location = new System.Drawing.Point(568, 381);
            this.btnCancel.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnCancel.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnCancel.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnCancel.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShowButtontext = true;
            this.btnCancel.Size = new System.Drawing.Size(144, 50);
            this.btnCancel.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextLocation_X = 47;
            this.btnCancel.TextLocation_Y = 21;
            this.btnCancel.Transparent1 = 175;
            this.btnCancel.Transparent2 = 50;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAlbumFact
            // 
            this.lblAlbumFact.AutoSize = true;
            this.lblAlbumFact.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumFact.ForeColor = System.Drawing.Color.White;
            this.lblAlbumFact.Location = new System.Drawing.Point(425, 166);
            this.lblAlbumFact.Name = "lblAlbumFact";
            this.lblAlbumFact.Size = new System.Drawing.Size(116, 25);
            this.lblAlbumFact.TabIndex = 42;
            this.lblAlbumFact.Text = "Album Fact:";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDate.ForeColor = System.Drawing.Color.White;
            this.lblReleaseDate.Location = new System.Drawing.Point(425, 97);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(128, 25);
            this.lblReleaseDate.TabIndex = 41;
            this.lblReleaseDate.Text = "Release Date:";
            // 
            // lblAlbumGenre
            // 
            this.lblAlbumGenre.AutoSize = true;
            this.lblAlbumGenre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumGenre.ForeColor = System.Drawing.Color.White;
            this.lblAlbumGenre.Location = new System.Drawing.Point(19, 304);
            this.lblAlbumGenre.Name = "lblAlbumGenre";
            this.lblAlbumGenre.Size = new System.Drawing.Size(71, 25);
            this.lblAlbumGenre.TabIndex = 40;
            this.lblAlbumGenre.Text = "Genre:";
            // 
            // lblAlbumRecordLabel
            // 
            this.lblAlbumRecordLabel.AutoSize = true;
            this.lblAlbumRecordLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumRecordLabel.ForeColor = System.Drawing.Color.White;
            this.lblAlbumRecordLabel.Location = new System.Drawing.Point(19, 235);
            this.lblAlbumRecordLabel.Name = "lblAlbumRecordLabel";
            this.lblAlbumRecordLabel.Size = new System.Drawing.Size(132, 25);
            this.lblAlbumRecordLabel.TabIndex = 39;
            this.lblAlbumRecordLabel.Text = "Record Label:";
            // 
            // lblAlbumArtist
            // 
            this.lblAlbumArtist.AutoSize = true;
            this.lblAlbumArtist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumArtist.ForeColor = System.Drawing.Color.White;
            this.lblAlbumArtist.Location = new System.Drawing.Point(19, 166);
            this.lblAlbumArtist.Name = "lblAlbumArtist";
            this.lblAlbumArtist.Size = new System.Drawing.Size(66, 25);
            this.lblAlbumArtist.TabIndex = 38;
            this.lblAlbumArtist.Text = "Artist:";
            // 
            // lblAlbumTitle
            // 
            this.lblAlbumTitle.AutoSize = true;
            this.lblAlbumTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumTitle.ForeColor = System.Drawing.Color.White;
            this.lblAlbumTitle.Location = new System.Drawing.Point(19, 97);
            this.lblAlbumTitle.Name = "lblAlbumTitle";
            this.lblAlbumTitle.Size = new System.Drawing.Size(119, 25);
            this.lblAlbumTitle.TabIndex = 37;
            this.lblAlbumTitle.Text = "Album Title:";
            // 
            // txtAlbumFact
            // 
            this.txtAlbumFact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlbumFact.Location = new System.Drawing.Point(568, 166);
            this.txtAlbumFact.Multiline = true;
            this.txtAlbumFact.Name = "txtAlbumFact";
            this.txtAlbumFact.Size = new System.Drawing.Size(200, 167);
            this.txtAlbumFact.TabIndex = 36;
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReleaseDate.Location = new System.Drawing.Point(568, 97);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(200, 29);
            this.txtReleaseDate.TabIndex = 35;
            // 
            // txtAlbumGenre
            // 
            this.txtAlbumGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlbumGenre.Location = new System.Drawing.Point(182, 304);
            this.txtAlbumGenre.Name = "txtAlbumGenre";
            this.txtAlbumGenre.Size = new System.Drawing.Size(200, 29);
            this.txtAlbumGenre.TabIndex = 34;
            // 
            // txtAlbumRecordLabel
            // 
            this.txtAlbumRecordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlbumRecordLabel.Location = new System.Drawing.Point(182, 235);
            this.txtAlbumRecordLabel.Name = "txtAlbumRecordLabel";
            this.txtAlbumRecordLabel.Size = new System.Drawing.Size(200, 29);
            this.txtAlbumRecordLabel.TabIndex = 33;
            // 
            // txtAlbumTitle
            // 
            this.txtAlbumTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlbumTitle.Location = new System.Drawing.Point(182, 97);
            this.txtAlbumTitle.Name = "txtAlbumTitle";
            this.txtAlbumTitle.Size = new System.Drawing.Size(200, 29);
            this.txtAlbumTitle.TabIndex = 31;
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
            this.btnSave.Location = new System.Drawing.Point(182, 381);
            this.btnSave.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnSave.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnSave.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnSave.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnSave.Name = "btnSave";
            this.btnSave.ShowButtontext = true;
            this.btnSave.Size = new System.Drawing.Size(144, 50);
            this.btnSave.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.TextLocation_X = 47;
            this.btnSave.TextLocation_Y = 21;
            this.btnSave.Transparent1 = 175;
            this.btnSave.Transparent2 = 50;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAddEditAlbumHeader
            // 
            this.lblAddEditAlbumHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddEditAlbumHeader.ForeColor = System.Drawing.Color.White;
            this.lblAddEditAlbumHeader.Location = new System.Drawing.Point(1, 19);
            this.lblAddEditAlbumHeader.Name = "lblAddEditAlbumHeader";
            this.lblAddEditAlbumHeader.Size = new System.Drawing.Size(797, 45);
            this.lblAddEditAlbumHeader.TabIndex = 45;
            this.lblAddEditAlbumHeader.Text = "Album";
            this.lblAddEditAlbumHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbArtist
            // 
            this.cbArtist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(182, 166);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(200, 29);
            this.cbArtist.TabIndex = 46;
            this.cbArtist.SelectedIndexChanged += new System.EventHandler(this.cbArtist_SelectedIndexChanged);
            // 
            // frmAddEditAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cbArtist);
            this.Controls.Add(this.lblAddEditAlbumHeader);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAlbumFact);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblAlbumGenre);
            this.Controls.Add(this.lblAlbumRecordLabel);
            this.Controls.Add(this.lblAlbumArtist);
            this.Controls.Add(this.lblAlbumTitle);
            this.Controls.Add(this.txtAlbumFact);
            this.Controls.Add(this.txtReleaseDate);
            this.Controls.Add(this.txtAlbumGenre);
            this.Controls.Add(this.txtAlbumRecordLabel);
            this.Controls.Add(this.txtAlbumTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditAlbum";
            this.Text = "Add Album";
            this.Load += new System.EventHandler(this.frmAddAlbum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private View.ModernButton btnCancel;
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
        private System.Windows.Forms.TextBox txtAlbumTitle;
        private View.ModernButton btnSave;
        private System.Windows.Forms.Label lblAddEditAlbumHeader;
        private System.Windows.Forms.ComboBox cbArtist;
    }
}