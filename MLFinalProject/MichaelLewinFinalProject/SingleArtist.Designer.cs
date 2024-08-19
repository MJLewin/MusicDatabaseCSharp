
namespace MichaelLewinFinalProject
{
    partial class frmSingleArtist
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
            this.lblArtistHeader = new System.Windows.Forms.Label();
            this.pArtistContainer = new System.Windows.Forms.Panel();
            this.btnClose = new MichaelLewinFinalProject.View.ModernButton();
            this.lblArtistFact = new System.Windows.Forms.Label();
            this.lblDateOfDeath = new System.Windows.Forms.Label();
            this.lblHometown = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblStageName = new System.Windows.Forms.Label();
            this.lblBirthName = new System.Windows.Forms.Label();
            this.txtArtistFact = new System.Windows.Forms.TextBox();
            this.txtDateOfDeath = new System.Windows.Forms.TextBox();
            this.txtHometown = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtStageName = new System.Windows.Forms.TextBox();
            this.txtBirthName = new System.Windows.Forms.TextBox();
            this.dgvArtistSongs = new System.Windows.Forms.DataGridView();
            this.pArtistContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtistSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtistHeader
            // 
            this.lblArtistHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArtistHeader.ForeColor = System.Drawing.Color.White;
            this.lblArtistHeader.Location = new System.Drawing.Point(0, 39);
            this.lblArtistHeader.Name = "lblArtistHeader";
            this.lblArtistHeader.Size = new System.Drawing.Size(830, 45);
            this.lblArtistHeader.TabIndex = 0;
            this.lblArtistHeader.Text = "Artist";
            this.lblArtistHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pArtistContainer
            // 
            this.pArtistContainer.Controls.Add(this.btnClose);
            this.pArtistContainer.Controls.Add(this.lblArtistFact);
            this.pArtistContainer.Controls.Add(this.lblDateOfDeath);
            this.pArtistContainer.Controls.Add(this.lblHometown);
            this.pArtistContainer.Controls.Add(this.lblDateOfBirth);
            this.pArtistContainer.Controls.Add(this.lblStageName);
            this.pArtistContainer.Controls.Add(this.lblBirthName);
            this.pArtistContainer.Controls.Add(this.txtArtistFact);
            this.pArtistContainer.Controls.Add(this.txtDateOfDeath);
            this.pArtistContainer.Controls.Add(this.txtHometown);
            this.pArtistContainer.Controls.Add(this.txtDateOfBirth);
            this.pArtistContainer.Controls.Add(this.txtStageName);
            this.pArtistContainer.Controls.Add(this.txtBirthName);
            this.pArtistContainer.Controls.Add(this.dgvArtistSongs);
            this.pArtistContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pArtistContainer.Location = new System.Drawing.Point(0, 107);
            this.pArtistContainer.Name = "pArtistContainer";
            this.pArtistContainer.Size = new System.Drawing.Size(830, 600);
            this.pArtistContainer.TabIndex = 1;
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
            this.btnClose.Location = new System.Drawing.Point(649, 522);
            this.btnClose.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnClose.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnClose.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnClose.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnClose.Name = "btnClose";
            this.btnClose.ShowButtontext = true;
            this.btnClose.Size = new System.Drawing.Size(144, 50);
            this.btnClose.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.TextLocation_X = 47;
            this.btnClose.TextLocation_Y = 21;
            this.btnClose.Transparent1 = 175;
            this.btnClose.Transparent2 = 50;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblArtistFact
            // 
            this.lblArtistFact.AutoSize = true;
            this.lblArtistFact.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArtistFact.ForeColor = System.Drawing.Color.White;
            this.lblArtistFact.Location = new System.Drawing.Point(22, 370);
            this.lblArtistFact.Name = "lblArtistFact";
            this.lblArtistFact.Size = new System.Drawing.Size(106, 25);
            this.lblArtistFact.TabIndex = 12;
            this.lblArtistFact.Text = "Artist Fact:";
            // 
            // lblDateOfDeath
            // 
            this.lblDateOfDeath.AutoSize = true;
            this.lblDateOfDeath.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfDeath.ForeColor = System.Drawing.Color.White;
            this.lblDateOfDeath.Location = new System.Drawing.Point(22, 301);
            this.lblDateOfDeath.Name = "lblDateOfDeath";
            this.lblDateOfDeath.Size = new System.Drawing.Size(139, 25);
            this.lblDateOfDeath.TabIndex = 11;
            this.lblDateOfDeath.Text = "Date of Death:";
            // 
            // lblHometown
            // 
            this.lblHometown.AutoSize = true;
            this.lblHometown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHometown.ForeColor = System.Drawing.Color.White;
            this.lblHometown.Location = new System.Drawing.Point(22, 232);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(117, 25);
            this.lblHometown.TabIndex = 10;
            this.lblHometown.Text = "Hometown:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Location = new System.Drawing.Point(22, 163);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(107, 25);
            this.lblDateOfBirth.TabIndex = 9;
            this.lblDateOfBirth.Text = "Birth Date:";
            // 
            // lblStageName
            // 
            this.lblStageName.AutoSize = true;
            this.lblStageName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStageName.ForeColor = System.Drawing.Color.White;
            this.lblStageName.Location = new System.Drawing.Point(22, 94);
            this.lblStageName.Name = "lblStageName";
            this.lblStageName.Size = new System.Drawing.Size(124, 25);
            this.lblStageName.TabIndex = 8;
            this.lblStageName.Text = "Stage Name:";
            // 
            // lblBirthName
            // 
            this.lblBirthName.AutoSize = true;
            this.lblBirthName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBirthName.ForeColor = System.Drawing.Color.White;
            this.lblBirthName.Location = new System.Drawing.Point(22, 25);
            this.lblBirthName.Name = "lblBirthName";
            this.lblBirthName.Size = new System.Drawing.Size(118, 25);
            this.lblBirthName.TabIndex = 7;
            this.lblBirthName.Text = "Birth Name:";
            // 
            // txtArtistFact
            // 
            this.txtArtistFact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtArtistFact.Location = new System.Drawing.Point(185, 370);
            this.txtArtistFact.Multiline = true;
            this.txtArtistFact.Name = "txtArtistFact";
            this.txtArtistFact.ReadOnly = true;
            this.txtArtistFact.Size = new System.Drawing.Size(200, 202);
            this.txtArtistFact.TabIndex = 6;
            // 
            // txtDateOfDeath
            // 
            this.txtDateOfDeath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateOfDeath.Location = new System.Drawing.Point(185, 301);
            this.txtDateOfDeath.Name = "txtDateOfDeath";
            this.txtDateOfDeath.ReadOnly = true;
            this.txtDateOfDeath.Size = new System.Drawing.Size(200, 29);
            this.txtDateOfDeath.TabIndex = 5;
            // 
            // txtHometown
            // 
            this.txtHometown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHometown.Location = new System.Drawing.Point(185, 232);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.ReadOnly = true;
            this.txtHometown.Size = new System.Drawing.Size(200, 29);
            this.txtHometown.TabIndex = 4;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateOfBirth.Location = new System.Drawing.Point(185, 163);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.ReadOnly = true;
            this.txtDateOfBirth.Size = new System.Drawing.Size(200, 29);
            this.txtDateOfBirth.TabIndex = 3;
            // 
            // txtStageName
            // 
            this.txtStageName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStageName.Location = new System.Drawing.Point(185, 94);
            this.txtStageName.Name = "txtStageName";
            this.txtStageName.ReadOnly = true;
            this.txtStageName.Size = new System.Drawing.Size(200, 29);
            this.txtStageName.TabIndex = 2;
            // 
            // txtBirthName
            // 
            this.txtBirthName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirthName.Location = new System.Drawing.Point(185, 25);
            this.txtBirthName.Name = "txtBirthName";
            this.txtBirthName.ReadOnly = true;
            this.txtBirthName.Size = new System.Drawing.Size(200, 29);
            this.txtBirthName.TabIndex = 1;
            // 
            // dgvArtistSongs
            // 
            this.dgvArtistSongs.AllowUserToAddRows = false;
            this.dgvArtistSongs.AllowUserToDeleteRows = false;
            this.dgvArtistSongs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvArtistSongs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvArtistSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArtistSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtistSongs.Location = new System.Drawing.Point(414, 25);
            this.dgvArtistSongs.Name = "dgvArtistSongs";
            this.dgvArtistSongs.ReadOnly = true;
            this.dgvArtistSongs.RowTemplate.Height = 25;
            this.dgvArtistSongs.Size = new System.Drawing.Size(391, 469);
            this.dgvArtistSongs.TabIndex = 0;
            this.dgvArtistSongs.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArtistSongs_RowHeaderMouseClick);
            // 
            // frmSingleArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(830, 707);
            this.ControlBox = false;
            this.Controls.Add(this.pArtistContainer);
            this.Controls.Add(this.lblArtistHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSingleArtist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SingleArtist";
            this.Load += new System.EventHandler(this.frmSingleArtist_Load);
            this.pArtistContainer.ResumeLayout(false);
            this.pArtistContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtistSongs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblArtistHeader;
        private System.Windows.Forms.Panel pArtistContainer;
        private System.Windows.Forms.TextBox txtArtistFact;
        private System.Windows.Forms.TextBox txtDateOfDeath;
        private System.Windows.Forms.TextBox txtHometown;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtStageName;
        private System.Windows.Forms.TextBox txtBirthName;
        private System.Windows.Forms.DataGridView dgvArtistSongs;
        private System.Windows.Forms.Label lblArtistFact;
        private System.Windows.Forms.Label lblDateOfDeath;
        private System.Windows.Forms.Label lblHometown;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblStageName;
        private System.Windows.Forms.Label lblBirthName;
        private View.ModernButton btnClose;
    }
}