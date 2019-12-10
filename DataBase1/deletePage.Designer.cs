namespace DataBase1
{
    partial class deletePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deletePage));
            this.selectLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.deletePlaylistButton = new System.Windows.Forms.Button();
            this.deleteSongPlaylistButton = new System.Windows.Forms.Button();
            this.deleteConcertButton = new System.Windows.Forms.Button();
            this.deletePlaylistGroupBox = new System.Windows.Forms.GroupBox();
            this.playlistIDDeleteButton = new System.Windows.Forms.Button();
            this.playlistIDTextBox = new System.Windows.Forms.TextBox();
            this.enterPlaylistIDLabel = new System.Windows.Forms.Label();
            this.playlistDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteConcertGroupBox = new System.Windows.Forms.GroupBox();
            this.concertIDDeleteButton = new System.Windows.Forms.Button();
            this.concertIDTextBox = new System.Windows.Forms.TextBox();
            this.enterConcertIDLabel = new System.Windows.Forms.Label();
            this.concertDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteSongGroupBox = new System.Windows.Forms.GroupBox();
            this.songIDTextBox = new System.Windows.Forms.TextBox();
            this.enterSongIDLabel = new System.Windows.Forms.Label();
            this.songDeleteButton = new System.Windows.Forms.Button();
            this.playlistSongTextBox = new System.Windows.Forms.TextBox();
            this.enterPlaylistIDforSongLabel = new System.Windows.Forms.Label();
            this.songPlaylistDataGridView = new System.Windows.Forms.DataGridView();
            this.deletePlaylistGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistDataGridView)).BeginInit();
            this.deleteConcertGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.concertDataGridView)).BeginInit();
            this.deleteSongGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songPlaylistDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.ForeColor = System.Drawing.Color.White;
            this.selectLabel.Location = new System.Drawing.Point(34, 23);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(666, 54);
            this.selectLabel.TabIndex = 9;
            this.selectLabel.Text = "Select a delete option below:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.exitButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(1143, 23);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 51);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deletePlaylistButton
            // 
            this.deletePlaylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.deletePlaylistButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePlaylistButton.ForeColor = System.Drawing.Color.White;
            this.deletePlaylistButton.Location = new System.Drawing.Point(43, 106);
            this.deletePlaylistButton.Name = "deletePlaylistButton";
            this.deletePlaylistButton.Size = new System.Drawing.Size(226, 76);
            this.deletePlaylistButton.TabIndex = 0;
            this.deletePlaylistButton.Text = "Delete Playlist";
            this.deletePlaylistButton.UseVisualStyleBackColor = false;
            this.deletePlaylistButton.Click += new System.EventHandler(this.deletePlaylistButton_Click);
            // 
            // deleteSongPlaylistButton
            // 
            this.deleteSongPlaylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.deleteSongPlaylistButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSongPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.deleteSongPlaylistButton.Location = new System.Drawing.Point(305, 106);
            this.deleteSongPlaylistButton.Name = "deleteSongPlaylistButton";
            this.deleteSongPlaylistButton.Size = new System.Drawing.Size(226, 76);
            this.deleteSongPlaylistButton.TabIndex = 1;
            this.deleteSongPlaylistButton.Text = "Delete a Song from Playlist";
            this.deleteSongPlaylistButton.UseVisualStyleBackColor = false;
            this.deleteSongPlaylistButton.Click += new System.EventHandler(this.deleteSongPlaylistButton_Click);
            // 
            // deleteConcertButton
            // 
            this.deleteConcertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.deleteConcertButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteConcertButton.ForeColor = System.Drawing.Color.White;
            this.deleteConcertButton.Location = new System.Drawing.Point(570, 106);
            this.deleteConcertButton.Name = "deleteConcertButton";
            this.deleteConcertButton.Size = new System.Drawing.Size(226, 76);
            this.deleteConcertButton.TabIndex = 2;
            this.deleteConcertButton.Text = "Delete Concert";
            this.deleteConcertButton.UseVisualStyleBackColor = false;
            this.deleteConcertButton.Click += new System.EventHandler(this.deleteConcertButton_Click);
            // 
            // deletePlaylistGroupBox
            // 
            this.deletePlaylistGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.deletePlaylistGroupBox.Controls.Add(this.playlistIDDeleteButton);
            this.deletePlaylistGroupBox.Controls.Add(this.playlistIDTextBox);
            this.deletePlaylistGroupBox.Controls.Add(this.enterPlaylistIDLabel);
            this.deletePlaylistGroupBox.Controls.Add(this.playlistDataGridView);
            this.deletePlaylistGroupBox.Location = new System.Drawing.Point(75, 223);
            this.deletePlaylistGroupBox.Name = "deletePlaylistGroupBox";
            this.deletePlaylistGroupBox.Size = new System.Drawing.Size(1129, 506);
            this.deletePlaylistGroupBox.TabIndex = 3;
            this.deletePlaylistGroupBox.TabStop = false;
            this.deletePlaylistGroupBox.Visible = false;
            // 
            // playlistIDDeleteButton
            // 
            this.playlistIDDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.playlistIDDeleteButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistIDDeleteButton.ForeColor = System.Drawing.Color.White;
            this.playlistIDDeleteButton.Location = new System.Drawing.Point(836, 254);
            this.playlistIDDeleteButton.Name = "playlistIDDeleteButton";
            this.playlistIDDeleteButton.Size = new System.Drawing.Size(104, 51);
            this.playlistIDDeleteButton.TabIndex = 2;
            this.playlistIDDeleteButton.Text = "Delete";
            this.playlistIDDeleteButton.UseVisualStyleBackColor = false;
            this.playlistIDDeleteButton.Click += new System.EventHandler(this.playlistIDDeleteButton_Click);
            // 
            // playlistIDTextBox
            // 
            this.playlistIDTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.playlistIDTextBox.Location = new System.Drawing.Point(817, 200);
            this.playlistIDTextBox.Name = "playlistIDTextBox";
            this.playlistIDTextBox.Size = new System.Drawing.Size(140, 32);
            this.playlistIDTextBox.TabIndex = 1;
            this.playlistIDTextBox.Text = "ID";
            this.playlistIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enterPlaylistIDLabel
            // 
            this.enterPlaylistIDLabel.AutoSize = true;
            this.enterPlaylistIDLabel.ForeColor = System.Drawing.Color.White;
            this.enterPlaylistIDLabel.Location = new System.Drawing.Point(707, 160);
            this.enterPlaylistIDLabel.Name = "enterPlaylistIDLabel";
            this.enterPlaylistIDLabel.Size = new System.Drawing.Size(368, 23);
            this.enterPlaylistIDLabel.TabIndex = 1;
            this.enterPlaylistIDLabel.Text = "Enter Playlist ID to delete the playlist:";
            // 
            // playlistDataGridView
            // 
            this.playlistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playlistDataGridView.Location = new System.Drawing.Point(67, 73);
            this.playlistDataGridView.Name = "playlistDataGridView";
            this.playlistDataGridView.RowHeadersWidth = 82;
            this.playlistDataGridView.RowTemplate.Height = 33;
            this.playlistDataGridView.Size = new System.Drawing.Size(605, 373);
            this.playlistDataGridView.TabIndex = 0;
            // 
            // deleteConcertGroupBox
            // 
            this.deleteConcertGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.deleteConcertGroupBox.Controls.Add(this.concertIDDeleteButton);
            this.deleteConcertGroupBox.Controls.Add(this.concertIDTextBox);
            this.deleteConcertGroupBox.Controls.Add(this.enterConcertIDLabel);
            this.deleteConcertGroupBox.Controls.Add(this.concertDataGridView);
            this.deleteConcertGroupBox.Location = new System.Drawing.Point(75, 223);
            this.deleteConcertGroupBox.Name = "deleteConcertGroupBox";
            this.deleteConcertGroupBox.Size = new System.Drawing.Size(1305, 521);
            this.deleteConcertGroupBox.TabIndex = 4;
            this.deleteConcertGroupBox.TabStop = false;
            this.deleteConcertGroupBox.Visible = false;
            // 
            // concertIDDeleteButton
            // 
            this.concertIDDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.concertIDDeleteButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concertIDDeleteButton.ForeColor = System.Drawing.Color.White;
            this.concertIDDeleteButton.Location = new System.Drawing.Point(836, 254);
            this.concertIDDeleteButton.Name = "concertIDDeleteButton";
            this.concertIDDeleteButton.Size = new System.Drawing.Size(104, 51);
            this.concertIDDeleteButton.TabIndex = 2;
            this.concertIDDeleteButton.Text = "Delete";
            this.concertIDDeleteButton.UseVisualStyleBackColor = false;
            this.concertIDDeleteButton.Visible = false;
            this.concertIDDeleteButton.Click += new System.EventHandler(this.concertIDDeleteButton_Click);
            // 
            // concertIDTextBox
            // 
            this.concertIDTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.concertIDTextBox.Location = new System.Drawing.Point(817, 200);
            this.concertIDTextBox.Name = "concertIDTextBox";
            this.concertIDTextBox.Size = new System.Drawing.Size(140, 32);
            this.concertIDTextBox.TabIndex = 1;
            this.concertIDTextBox.Text = "ID";
            this.concertIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.concertIDTextBox.Visible = false;
            // 
            // enterConcertIDLabel
            // 
            this.enterConcertIDLabel.AutoSize = true;
            this.enterConcertIDLabel.ForeColor = System.Drawing.Color.White;
            this.enterConcertIDLabel.Location = new System.Drawing.Point(707, 160);
            this.enterConcertIDLabel.Name = "enterConcertIDLabel";
            this.enterConcertIDLabel.Size = new System.Drawing.Size(380, 23);
            this.enterConcertIDLabel.TabIndex = 1;
            this.enterConcertIDLabel.Text = "Enter Concert ID to delete the concert:";
            this.enterConcertIDLabel.Visible = false;
            // 
            // concertDataGridView
            // 
            this.concertDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.concertDataGridView.Location = new System.Drawing.Point(67, 73);
            this.concertDataGridView.Name = "concertDataGridView";
            this.concertDataGridView.RowHeadersWidth = 82;
            this.concertDataGridView.RowTemplate.Height = 33;
            this.concertDataGridView.Size = new System.Drawing.Size(605, 373);
            this.concertDataGridView.TabIndex = 0;
            this.concertDataGridView.Visible = false;
            // 
            // deleteSongGroupBox
            // 
            this.deleteSongGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.deleteSongGroupBox.Controls.Add(this.songIDTextBox);
            this.deleteSongGroupBox.Controls.Add(this.enterSongIDLabel);
            this.deleteSongGroupBox.Controls.Add(this.songDeleteButton);
            this.deleteSongGroupBox.Controls.Add(this.playlistSongTextBox);
            this.deleteSongGroupBox.Controls.Add(this.enterPlaylistIDforSongLabel);
            this.deleteSongGroupBox.Controls.Add(this.songPlaylistDataGridView);
            this.deleteSongGroupBox.Location = new System.Drawing.Point(75, 223);
            this.deleteSongGroupBox.Name = "deleteSongGroupBox";
            this.deleteSongGroupBox.Size = new System.Drawing.Size(1346, 638);
            this.deleteSongGroupBox.TabIndex = 5;
            this.deleteSongGroupBox.TabStop = false;
            this.deleteSongGroupBox.Visible = false;
            // 
            // songIDTextBox
            // 
            this.songIDTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.songIDTextBox.Location = new System.Drawing.Point(817, 257);
            this.songIDTextBox.Name = "songIDTextBox";
            this.songIDTextBox.Size = new System.Drawing.Size(140, 32);
            this.songIDTextBox.TabIndex = 1;
            this.songIDTextBox.Text = "ID";
            this.songIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enterSongIDLabel
            // 
            this.enterSongIDLabel.AutoSize = true;
            this.enterSongIDLabel.ForeColor = System.Drawing.Color.White;
            this.enterSongIDLabel.Location = new System.Drawing.Point(723, 216);
            this.enterSongIDLabel.Name = "enterSongIDLabel";
            this.enterSongIDLabel.Size = new System.Drawing.Size(324, 23);
            this.enterSongIDLabel.TabIndex = 16;
            this.enterSongIDLabel.Text = "Enter Song ID to delete the song:\r\n";
            this.enterSongIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songDeleteButton
            // 
            this.songDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.songDeleteButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songDeleteButton.ForeColor = System.Drawing.Color.White;
            this.songDeleteButton.Location = new System.Drawing.Point(836, 308);
            this.songDeleteButton.Name = "songDeleteButton";
            this.songDeleteButton.Size = new System.Drawing.Size(104, 51);
            this.songDeleteButton.TabIndex = 2;
            this.songDeleteButton.Text = "Delete";
            this.songDeleteButton.UseVisualStyleBackColor = false;
            this.songDeleteButton.Click += new System.EventHandler(this.songDeleteButton_Click);
            // 
            // playlistSongTextBox
            // 
            this.playlistSongTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.playlistSongTextBox.Location = new System.Drawing.Point(817, 165);
            this.playlistSongTextBox.Name = "playlistSongTextBox";
            this.playlistSongTextBox.Size = new System.Drawing.Size(140, 32);
            this.playlistSongTextBox.TabIndex = 0;
            this.playlistSongTextBox.Text = "ID";
            this.playlistSongTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enterPlaylistIDforSongLabel
            // 
            this.enterPlaylistIDforSongLabel.AutoSize = true;
            this.enterPlaylistIDforSongLabel.ForeColor = System.Drawing.Color.White;
            this.enterPlaylistIDforSongLabel.Location = new System.Drawing.Point(765, 100);
            this.enterPlaylistIDforSongLabel.Name = "enterPlaylistIDforSongLabel";
            this.enterPlaylistIDforSongLabel.Size = new System.Drawing.Size(254, 46);
            this.enterPlaylistIDforSongLabel.TabIndex = 1;
            this.enterPlaylistIDforSongLabel.Text = "Enter Playlist ID that the \r\nsong will be erased from:";
            this.enterPlaylistIDforSongLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songPlaylistDataGridView
            // 
            this.songPlaylistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songPlaylistDataGridView.Location = new System.Drawing.Point(67, 73);
            this.songPlaylistDataGridView.Name = "songPlaylistDataGridView";
            this.songPlaylistDataGridView.RowHeadersWidth = 82;
            this.songPlaylistDataGridView.RowTemplate.Height = 33;
            this.songPlaylistDataGridView.Size = new System.Drawing.Size(605, 373);
            this.songPlaylistDataGridView.TabIndex = 0;
            // 
            // deletePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1472, 910);
            this.Controls.Add(this.deleteSongGroupBox);
            this.Controls.Add(this.deleteConcertGroupBox);
            this.Controls.Add(this.deletePlaylistGroupBox);
            this.Controls.Add(this.deleteConcertButton);
            this.Controls.Add(this.deleteSongPlaylistButton);
            this.Controls.Add(this.deletePlaylistButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectLabel);
            this.Font = new System.Drawing.Font("Rockwell", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "deletePage";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.deletePage_Load);
            this.deletePlaylistGroupBox.ResumeLayout(false);
            this.deletePlaylistGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistDataGridView)).EndInit();
            this.deleteConcertGroupBox.ResumeLayout(false);
            this.deleteConcertGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.concertDataGridView)).EndInit();
            this.deleteSongGroupBox.ResumeLayout(false);
            this.deleteSongGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songPlaylistDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button deletePlaylistButton;
        private System.Windows.Forms.Button deleteSongPlaylistButton;
        private System.Windows.Forms.Button deleteConcertButton;
        private System.Windows.Forms.GroupBox deletePlaylistGroupBox;
        private System.Windows.Forms.Button playlistIDDeleteButton;
        private System.Windows.Forms.TextBox playlistIDTextBox;
        private System.Windows.Forms.Label enterPlaylistIDLabel;
        private System.Windows.Forms.DataGridView playlistDataGridView;
        private System.Windows.Forms.GroupBox deleteConcertGroupBox;
        private System.Windows.Forms.Button concertIDDeleteButton;
        private System.Windows.Forms.TextBox concertIDTextBox;
        private System.Windows.Forms.Label enterConcertIDLabel;
        private System.Windows.Forms.DataGridView concertDataGridView;
        private System.Windows.Forms.GroupBox deleteSongGroupBox;
        private System.Windows.Forms.TextBox songIDTextBox;
        private System.Windows.Forms.Label enterSongIDLabel;
        private System.Windows.Forms.Button songDeleteButton;
        private System.Windows.Forms.TextBox playlistSongTextBox;
        private System.Windows.Forms.Label enterPlaylistIDforSongLabel;
        private System.Windows.Forms.DataGridView songPlaylistDataGridView;
    }
}