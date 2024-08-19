
namespace MichaelLewinFinalProject
{
    partial class frmAllAlbums
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
            this.dgvAllAlbums = new System.Windows.Forms.DataGridView();
            this.lblAllAlbums = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllAlbums
            // 
            this.dgvAllAlbums.AllowUserToAddRows = false;
            this.dgvAllAlbums.AllowUserToDeleteRows = false;
            this.dgvAllAlbums.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAllAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAlbums.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAllAlbums.Location = new System.Drawing.Point(0, 107);
            this.dgvAllAlbums.Name = "dgvAllAlbums";
            this.dgvAllAlbums.ReadOnly = true;
            this.dgvAllAlbums.RowTemplate.Height = 25;
            this.dgvAllAlbums.Size = new System.Drawing.Size(830, 600);
            this.dgvAllAlbums.TabIndex = 0;
            this.dgvAllAlbums.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllAlbums_CellContentClick);
            this.dgvAllAlbums.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllAlbums_RowHeaderMouseClick);
            // 
            // lblAllAlbums
            // 
            this.lblAllAlbums.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllAlbums.ForeColor = System.Drawing.Color.White;
            this.lblAllAlbums.Location = new System.Drawing.Point(0, 39);
            this.lblAllAlbums.Name = "lblAllAlbums";
            this.lblAllAlbums.Size = new System.Drawing.Size(830, 65);
            this.lblAllAlbums.TabIndex = 1;
            this.lblAllAlbums.Text = "All Albums";
            this.lblAllAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAllAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(830, 707);
            this.ControlBox = false;
            this.Controls.Add(this.lblAllAlbums);
            this.Controls.Add(this.dgvAllAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAllAlbums";
            this.Text = "All Albums";
            this.Load += new System.EventHandler(this.frmAllAlbums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAlbums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllAlbums;
        private System.Windows.Forms.Label lblAllAlbums;
    }
}