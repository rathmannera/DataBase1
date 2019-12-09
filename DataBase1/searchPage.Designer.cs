namespace DataBase1
{
    partial class searchPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchPage));
            this.searchLabel = new System.Windows.Forms.Label();
            this.songSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.songSearchButton = new System.Windows.Forms.Button();
            this.songSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.albumSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.albumSearchButton = new System.Windows.Forms.Button();
            this.albumSearchTextBox = new System.Windows.Forms.TextBox();
            this.playlistSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.playlistSearchButton = new System.Windows.Forms.Button();
            this.playlistSearchTextBox = new System.Windows.Forms.TextBox();
            this.artistSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.artistSearchButton = new System.Windows.Forms.Button();
            this.artistSearchTextBox = new System.Windows.Forms.TextBox();
            this.concertSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.concertSearchButton = new System.Windows.Forms.Button();
            this.concertSearchTextBox = new System.Windows.Forms.TextBox();
            this.genreSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.genreSearchButton = new System.Windows.Forms.Button();
            this.genreSearchTextBox = new System.Windows.Forms.TextBox();
            this.labelSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.labelSearchButton = new System.Windows.Forms.Button();
            this.labelSearchTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.lyricSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.lyricSearchButton = new System.Windows.Forms.Button();
            this.lyricSearchTextBox = new System.Windows.Forms.TextBox();
            this.songSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.albumSearchGroupBox.SuspendLayout();
            this.playlistSearchGroupBox.SuspendLayout();
            this.artistSearchGroupBox.SuspendLayout();
            this.concertSearchGroupBox.SuspendLayout();
            this.genreSearchGroupBox.SuspendLayout();
            this.labelSearchGroupBox.SuspendLayout();
            this.lyricSearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(373, 41);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(174, 54);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            // 
            // songSearchGroupBox
            // 
            this.songSearchGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.songSearchGroupBox.Controls.Add(this.songSearchButton);
            this.songSearchGroupBox.Controls.Add(this.songSearchTextBox);
            this.songSearchGroupBox.ForeColor = System.Drawing.Color.White;
            this.songSearchGroupBox.Location = new System.Drawing.Point(62, 150);
            this.songSearchGroupBox.Name = "songSearchGroupBox";
            this.songSearchGroupBox.Size = new System.Drawing.Size(386, 156);
            this.songSearchGroupBox.TabIndex = 0;
            this.songSearchGroupBox.TabStop = false;
            this.songSearchGroupBox.Text = "Search for a song:";
            // 
            // songSearchButton
            // 
            this.songSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.songSearchButton.Location = new System.Drawing.Point(136, 81);
            this.songSearchButton.Name = "songSearchButton";
            this.songSearchButton.Size = new System.Drawing.Size(114, 49);
            this.songSearchButton.TabIndex = 1;
            this.songSearchButton.Text = "Search";
            this.songSearchButton.UseVisualStyleBackColor = false;
            this.songSearchButton.Click += new System.EventHandler(this.songSearchButton_Click);
            // 
            // songSearchTextBox
            // 
            this.songSearchTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.songSearchTextBox.Location = new System.Drawing.Point(78, 31);
            this.songSearchTextBox.Name = "songSearchTextBox";
            this.songSearchTextBox.Size = new System.Drawing.Size(230, 32);
            this.songSearchTextBox.TabIndex = 0;
            this.songSearchTextBox.Text = "Enter song name here";
            this.songSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchGridView
            // 
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Location = new System.Drawing.Point(889, 12);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.RowHeadersWidth = 82;
            this.searchGridView.RowTemplate.Height = 33;
            this.searchGridView.Size = new System.Drawing.Size(715, 780);
            this.searchGridView.TabIndex = 3;
            // 
            // albumSearchGroupBox
            // 
            this.albumSearchGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.albumSearchGroupBox.Controls.Add(this.albumSearchButton);
            this.albumSearchGroupBox.Controls.Add(this.albumSearchTextBox);
            this.albumSearchGroupBox.ForeColor = System.Drawing.Color.White;
            this.albumSearchGroupBox.Location = new System.Drawing.Point(62, 312);
            this.albumSearchGroupBox.Name = "albumSearchGroupBox";
            this.albumSearchGroupBox.Size = new System.Drawing.Size(386, 156);
            this.albumSearchGroupBox.TabIndex = 2;
            this.albumSearchGroupBox.TabStop = false;
            this.albumSearchGroupBox.Text = "Search for an album:";
            // 
            // albumSearchButton
            // 
            this.albumSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.albumSearchButton.Location = new System.Drawing.Point(136, 85);
            this.albumSearchButton.Name = "albumSearchButton";
            this.albumSearchButton.Size = new System.Drawing.Size(114, 49);
            this.albumSearchButton.TabIndex = 1;
            this.albumSearchButton.Text = "Search";
            this.albumSearchButton.UseVisualStyleBackColor = false;
            this.albumSearchButton.Click += new System.EventHandler(this.albumSearchButton_Click_1);
            // 
            // albumSearchTextBox
            // 
            this.albumSearchTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.albumSearchTextBox.Location = new System.Drawing.Point(78, 36);
            this.albumSearchTextBox.Name = "albumSearchTextBox";
            this.albumSearchTextBox.Size = new System.Drawing.Size(230, 32);
            this.albumSearchTextBox.TabIndex = 0;
            this.albumSearchTextBox.Text = "Enter album name here";
            this.albumSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playlistSearchGroupBox
            // 
            this.playlistSearchGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.playlistSearchGroupBox.Controls.Add(this.playlistSearchButton);
            this.playlistSearchGroupBox.Controls.Add(this.playlistSearchTextBox);
            this.playlistSearchGroupBox.ForeColor = System.Drawing.Color.White;
            this.playlistSearchGroupBox.Location = new System.Drawing.Point(474, 312);
            this.playlistSearchGroupBox.Name = "playlistSearchGroupBox";
            this.playlistSearchGroupBox.Size = new System.Drawing.Size(386, 156);
            this.playlistSearchGroupBox.TabIndex = 3;
            this.playlistSearchGroupBox.TabStop = false;
            this.playlistSearchGroupBox.Text = "Search for a playlist:";
            // 
            // playlistSearchButton
            // 
            this.playlistSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.playlistSearchButton.Location = new System.Drawing.Point(140, 85);
            this.playlistSearchButton.Name = "playlistSearchButton";
            this.playlistSearchButton.Size = new System.Drawing.Size(114, 49);
            this.playlistSearchButton.TabIndex = 1;
            this.playlistSearchButton.Text = "Search";
            this.playlistSearchButton.UseVisualStyleBackColor = false;
            this.playlistSearchButton.Click += new System.EventHandler(this.playlistSearchButton_Click);
            // 
            // playlistSearchTextBox
            // 
            this.playlistSearchTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.playlistSearchTextBox.Location = new System.Drawing.Point(70, 36);
            this.playlistSearchTextBox.Name = "playlistSearchTextBox";
            this.playlistSearchTextBox.Size = new System.Drawing.Size(254, 32);
            this.playlistSearchTextBox.TabIndex = 0;
            this.playlistSearchTextBox.Text = "Enter playlist name here";
            this.playlistSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // artistSearchGroupBox
            // 
            this.artistSearchGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.artistSearchGroupBox.Controls.Add(this.artistSearchButton);
            this.artistSearchGroupBox.Controls.Add(this.artistSearchTextBox);
            this.artistSearchGroupBox.ForeColor = System.Drawing.Color.White;
            this.artistSearchGroupBox.Location = new System.Drawing.Point(62, 474);
            this.artistSearchGroupBox.Name = "artistSearchGroupBox";
            this.artistSearchGroupBox.Size = new System.Drawing.Size(386, 156);
            this.artistSearchGroupBox.TabIndex = 4;
            this.artistSearchGroupBox.TabStop = false;
            this.artistSearchGroupBox.Text = "Search for an artist:";
            // 
            // artistSearchButton
            // 
            this.artistSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.artistSearchButton.Location = new System.Drawing.Point(136, 90);
            this.artistSearchButton.Name = "artistSearchButton";
            this.artistSearchButton.Size = new System.Drawing.Size(114, 49);
            this.artistSearchButton.TabIndex = 1;
            this.artistSearchButton.Text = "Search";
            this.artistSearchButton.UseVisualStyleBackColor = false;
            this.artistSearchButton.Click += new System.EventHandler(this.artistSearchButton_Click);
            // 
            // artistSearchTextBox
            // 
            this.artistSearchTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.artistSearchTextBox.Location = new System.Drawing.Point(78, 36);
            this.artistSearchTextBox.Name = "artistSearchTextBox";
            this.artistSearchTextBox.Size = new System.Drawing.Size(230, 32);
            this.artistSearchTextBox.TabIndex = 0;
            this.artistSearchTextBox.Text = "Enter artist name here";
            this.artistSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // concertSearchGroupBox
            // 
            this.concertSearchGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.concertSearchGroupBox.Controls.Add(this.concertSearchButton);
            this.concertSearchGroupBox.Controls.Add(this.concertSearchTextBox);
            this.concertSearchGroupBox.Font = new System.Drawing.Font("Rockwell", 7F);
            this.concertSearchGroupBox.ForeColor = System.Drawing.Color.White;
            this.concertSearchGroupBox.Location = new System.Drawing.Point(65, 636);
            this.concertSearchGroupBox.Name = "concertSearchGroupBox";
            this.concertSearchGroupBox.Size = new System.Drawing.Size(380, 156);
            this.concertSearchGroupBox.TabIndex = 6;
            this.concertSearchGroupBox.TabStop = false;
            this.concertSearchGroupBox.Text = "Search for concert details, by artist:";
            // 
            // concertSearchButton
            // 
            this.concertSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.concertSearchButton.Font = new System.Drawing.Font("Rockwell", 7.875F);
            this.concertSearchButton.Location = new System.Drawing.Point(136, 92);
            this.concertSearchButton.Name = "concertSearchButton";
            this.concertSearchButton.Size = new System.Drawing.Size(114, 49);
            this.concertSearchButton.TabIndex = 1;
            this.concertSearchButton.Text = "Search";
            this.concertSearchButton.UseVisualStyleBackColor = false;
            this.concertSearchButton.Click += new System.EventHandler(this.concertSearchButton_Click);
            // 
            // concertSearchTextBox
            // 
            this.concertSearchTextBox.Font = new System.Drawing.Font("Rockwell", 7.875F);
            this.concertSearchTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.concertSearchTextBox.Location = new System.Drawing.Point(61, 36);
            this.concertSearchTextBox.Name = "concertSearchTextBox";
            this.concertSearchTextBox.Size = new System.Drawing.Size(264, 32);
            this.concertSearchTextBox.TabIndex = 0;
            this.concertSearchTextBox.Text = "Enter artist name here";
            this.concertSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genreSearchGroupBox
            // 
            this.genreSearchGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.genreSearchGroupBox.Controls.Add(this.genreSearchButton);
            this.genreSearchGroupBox.Controls.Add(this.genreSearchTextBox);
            this.genreSearchGroupBox.ForeColor = System.Drawing.Color.White;
            this.genreSearchGroupBox.Location = new System.Drawing.Point(474, 636);
            this.genreSearchGroupBox.Name = "genreSearchGroupBox";
            this.genreSearchGroupBox.Size = new System.Drawing.Size(386, 156);
            this.genreSearchGroupBox.TabIndex = 7;
            this.genreSearchGroupBox.TabStop = false;
            this.genreSearchGroupBox.Text = "Search for a genre:";
            // 
            // genreSearchButton
            // 
            this.genreSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.genreSearchButton.Location = new System.Drawing.Point(140, 92);
            this.genreSearchButton.Name = "genreSearchButton";
            this.genreSearchButton.Size = new System.Drawing.Size(114, 49);
            this.genreSearchButton.TabIndex = 1;
            this.genreSearchButton.Text = "Search";
            this.genreSearchButton.UseVisualStyleBackColor = false;
            this.genreSearchButton.Click += new System.EventHandler(this.genreSearchButton_Click);
            // 
            // genreSearchTextBox
            // 
            this.genreSearchTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.genreSearchTextBox.Location = new System.Drawing.Point(99, 36);
            this.genreSearchTextBox.Name = "genreSearchTextBox";
            this.genreSearchTextBox.Size = new System.Drawing.Size(197, 32);
            this.genreSearchTextBox.TabIndex = 0;
            this.genreSearchTextBox.Text = "Enter genre here";
            this.genreSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSearchGroupBox
            // 
            this.labelSearchGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.labelSearchGroupBox.Controls.Add(this.labelSearchButton);
            this.labelSearchGroupBox.Controls.Add(this.labelSearchTextBox);
            this.labelSearchGroupBox.ForeColor = System.Drawing.Color.White;
            this.labelSearchGroupBox.Location = new System.Drawing.Point(474, 474);
            this.labelSearchGroupBox.Name = "labelSearchGroupBox";
            this.labelSearchGroupBox.Size = new System.Drawing.Size(386, 156);
            this.labelSearchGroupBox.TabIndex = 5;
            this.labelSearchGroupBox.TabStop = false;
            this.labelSearchGroupBox.Text = "Search for a label:";
            // 
            // labelSearchButton
            // 
            this.labelSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.labelSearchButton.Location = new System.Drawing.Point(140, 90);
            this.labelSearchButton.Name = "labelSearchButton";
            this.labelSearchButton.Size = new System.Drawing.Size(114, 49);
            this.labelSearchButton.TabIndex = 1;
            this.labelSearchButton.Text = "Search";
            this.labelSearchButton.UseVisualStyleBackColor = false;
            this.labelSearchButton.Click += new System.EventHandler(this.labelSearchButton_Click);
            // 
            // labelSearchTextBox
            // 
            this.labelSearchTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.labelSearchTextBox.Location = new System.Drawing.Point(100, 36);
            this.labelSearchTextBox.Name = "labelSearchTextBox";
            this.labelSearchTextBox.Size = new System.Drawing.Size(195, 32);
            this.labelSearchTextBox.TabIndex = 0;
            this.labelSearchTextBox.Text = "Enter label here";
            this.labelSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.exitButton.Font = new System.Drawing.Font("Rockwell", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(12, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 64);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lyricSearchGroupBox
            // 
            this.lyricSearchGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.lyricSearchGroupBox.Controls.Add(this.lyricSearchButton);
            this.lyricSearchGroupBox.Controls.Add(this.lyricSearchTextBox);
            this.lyricSearchGroupBox.ForeColor = System.Drawing.Color.White;
            this.lyricSearchGroupBox.Location = new System.Drawing.Point(474, 150);
            this.lyricSearchGroupBox.Name = "lyricSearchGroupBox";
            this.lyricSearchGroupBox.Size = new System.Drawing.Size(386, 156);
            this.lyricSearchGroupBox.TabIndex = 1;
            this.lyricSearchGroupBox.TabStop = false;
            this.lyricSearchGroupBox.Text = "Search for a lyric:";
            // 
            // lyricSearchButton
            // 
            this.lyricSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.lyricSearchButton.Location = new System.Drawing.Point(140, 81);
            this.lyricSearchButton.Name = "lyricSearchButton";
            this.lyricSearchButton.Size = new System.Drawing.Size(114, 49);
            this.lyricSearchButton.TabIndex = 1;
            this.lyricSearchButton.Text = "Search";
            this.lyricSearchButton.UseVisualStyleBackColor = false;
            this.lyricSearchButton.Click += new System.EventHandler(this.lyricSearchButton_Click);
            // 
            // lyricSearchTextBox
            // 
            this.lyricSearchTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lyricSearchTextBox.Location = new System.Drawing.Point(95, 31);
            this.lyricSearchTextBox.Name = "lyricSearchTextBox";
            this.lyricSearchTextBox.Size = new System.Drawing.Size(204, 32);
            this.lyricSearchTextBox.TabIndex = 0;
            this.lyricSearchTextBox.Text = "Enter a lyric here";
            this.lyricSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1744, 837);
            this.Controls.Add(this.lyricSearchGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playlistSearchGroupBox);
            this.Controls.Add(this.albumSearchGroupBox);
            this.Controls.Add(this.artistSearchGroupBox);
            this.Controls.Add(this.concertSearchGroupBox);
            this.Controls.Add(this.genreSearchGroupBox);
            this.Controls.Add(this.labelSearchGroupBox);
            this.Controls.Add(this.searchGridView);
            this.Controls.Add(this.songSearchGroupBox);
            this.Controls.Add(this.searchLabel);
            this.Font = new System.Drawing.Font("Rockwell", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "searchPage";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.searchPage_Load);
            this.songSearchGroupBox.ResumeLayout(false);
            this.songSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.albumSearchGroupBox.ResumeLayout(false);
            this.albumSearchGroupBox.PerformLayout();
            this.playlistSearchGroupBox.ResumeLayout(false);
            this.playlistSearchGroupBox.PerformLayout();
            this.artistSearchGroupBox.ResumeLayout(false);
            this.artistSearchGroupBox.PerformLayout();
            this.concertSearchGroupBox.ResumeLayout(false);
            this.concertSearchGroupBox.PerformLayout();
            this.genreSearchGroupBox.ResumeLayout(false);
            this.genreSearchGroupBox.PerformLayout();
            this.labelSearchGroupBox.ResumeLayout(false);
            this.labelSearchGroupBox.PerformLayout();
            this.lyricSearchGroupBox.ResumeLayout(false);
            this.lyricSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.GroupBox songSearchGroupBox;
        private System.Windows.Forms.Button songSearchButton;
        private System.Windows.Forms.TextBox songSearchTextBox;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.GroupBox albumSearchGroupBox;
        private System.Windows.Forms.TextBox albumSearchTextBox;
        private System.Windows.Forms.GroupBox playlistSearchGroupBox;
        private System.Windows.Forms.TextBox playlistSearchTextBox;
        private System.Windows.Forms.GroupBox artistSearchGroupBox;
        private System.Windows.Forms.TextBox artistSearchTextBox;
        private System.Windows.Forms.GroupBox concertSearchGroupBox;
        private System.Windows.Forms.TextBox concertSearchTextBox;
        private System.Windows.Forms.GroupBox genreSearchGroupBox;
        private System.Windows.Forms.TextBox genreSearchTextBox;
        private System.Windows.Forms.GroupBox labelSearchGroupBox;
        private System.Windows.Forms.TextBox labelSearchTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox lyricSearchGroupBox;
        private System.Windows.Forms.TextBox lyricSearchTextBox;
        private System.Windows.Forms.Button albumSearchButton;
        private System.Windows.Forms.Button playlistSearchButton;
        private System.Windows.Forms.Button artistSearchButton;
        private System.Windows.Forms.Button concertSearchButton;
        private System.Windows.Forms.Button genreSearchButton;
        private System.Windows.Forms.Button labelSearchButton;
        private System.Windows.Forms.Button lyricSearchButton;
    }
}