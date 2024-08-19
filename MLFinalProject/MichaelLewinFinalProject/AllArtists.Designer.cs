
namespace MichaelLewinFinalProject
{
    partial class frmAllArtists
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
            this.dgvAllArtists = new System.Windows.Forms.DataGridView();
            this.lblAllArtists = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllArtists)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllArtists
            // 
            this.dgvAllArtists.AllowUserToAddRows = false;
            this.dgvAllArtists.AllowUserToDeleteRows = false;
            this.dgvAllArtists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAllArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllArtists.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAllArtists.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAllArtists.Location = new System.Drawing.Point(0, 107);
            this.dgvAllArtists.Name = "dgvAllArtists";
            this.dgvAllArtists.ReadOnly = true;
            this.dgvAllArtists.RowTemplate.Height = 25;
            this.dgvAllArtists.Size = new System.Drawing.Size(830, 600);
            this.dgvAllArtists.TabIndex = 0;
            this.dgvAllArtists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllArtists_CellContentClick);
            this.dgvAllArtists.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllArtists_RowHeaderMouseClick);
            // 
            // lblAllArtists
            // 
            this.lblAllArtists.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllArtists.ForeColor = System.Drawing.Color.White;
            this.lblAllArtists.Location = new System.Drawing.Point(0, 39);
            this.lblAllArtists.Name = "lblAllArtists";
            this.lblAllArtists.Size = new System.Drawing.Size(830, 65);
            this.lblAllArtists.TabIndex = 1;
            this.lblAllArtists.Text = "All Artists";
            this.lblAllArtists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAllArtists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(830, 707);
            this.ControlBox = false;
            this.Controls.Add(this.lblAllArtists);
            this.Controls.Add(this.dgvAllArtists);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAllArtists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AllArtists";
            this.Load += new System.EventHandler(this.frmAllArtists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllArtists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllArtists;
        private System.Windows.Forms.Label lblAllArtists;
    }
}