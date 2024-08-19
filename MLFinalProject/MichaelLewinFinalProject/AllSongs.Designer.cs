
namespace MichaelLewinFinalProject
{
    partial class frmAllSongs
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
            this.dgvAllSongs = new System.Windows.Forms.DataGridView();
            this.lblAllSongs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllSongs
            // 
            this.dgvAllSongs.AllowUserToAddRows = false;
            this.dgvAllSongs.AllowUserToDeleteRows = false;
            this.dgvAllSongs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAllSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllSongs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAllSongs.Location = new System.Drawing.Point(0, 107);
            this.dgvAllSongs.Name = "dgvAllSongs";
            this.dgvAllSongs.ReadOnly = true;
            this.dgvAllSongs.RowTemplate.Height = 25;
            this.dgvAllSongs.Size = new System.Drawing.Size(830, 600);
            this.dgvAllSongs.TabIndex = 0;
            this.dgvAllSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllSongs_CellContentClick);
            this.dgvAllSongs.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllSongs_RowHeaderMouseClick);
            // 
            // lblAllSongs
            // 
            this.lblAllSongs.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllSongs.ForeColor = System.Drawing.Color.White;
            this.lblAllSongs.Location = new System.Drawing.Point(0, 39);
            this.lblAllSongs.Name = "lblAllSongs";
            this.lblAllSongs.Size = new System.Drawing.Size(830, 65);
            this.lblAllSongs.TabIndex = 1;
            this.lblAllSongs.Text = "All Songs";
            this.lblAllSongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAllSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(830, 707);
            this.ControlBox = false;
            this.Controls.Add(this.lblAllSongs);
            this.Controls.Add(this.dgvAllSongs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAllSongs";
            this.Text = "All Songs";
            this.Load += new System.EventHandler(this.frmAllSongs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSongs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllSongs;
        private System.Windows.Forms.Label lblAllSongs;
    }
}