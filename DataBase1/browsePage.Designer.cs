namespace DataBase1
{
    partial class browsePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(browsePage));
            this.browseBySongButton = new System.Windows.Forms.Button();
            this.browseByArtistButton = new System.Windows.Forms.Button();
            this.browseByAlbumButton = new System.Windows.Forms.Button();
            this.browseByPlaylistButton = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.dbDataSet = new DataBase1.dbDataSet();
            this.songBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songTableAdapter = new DataBase1.dbDataSetTableAdapters.SongTableAdapter();
            this.browseDataGridView = new System.Windows.Forms.DataGridView();
            this.browseByConcertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // browseBySongButton
            // 
            this.browseBySongButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.browseBySongButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBySongButton.ForeColor = System.Drawing.Color.White;
            this.browseBySongButton.Location = new System.Drawing.Point(85, 125);
            this.browseBySongButton.Name = "browseBySongButton";
            this.browseBySongButton.Size = new System.Drawing.Size(226, 76);
            this.browseBySongButton.TabIndex = 0;
            this.browseBySongButton.Text = "By Song";
            this.browseBySongButton.UseVisualStyleBackColor = false;
            this.browseBySongButton.Click += new System.EventHandler(this.browseBySongButton_Click);
            // 
            // browseByArtistButton
            // 
            this.browseByArtistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.browseByArtistButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseByArtistButton.ForeColor = System.Drawing.Color.White;
            this.browseByArtistButton.Location = new System.Drawing.Point(347, 125);
            this.browseByArtistButton.Name = "browseByArtistButton";
            this.browseByArtistButton.Size = new System.Drawing.Size(226, 76);
            this.browseByArtistButton.TabIndex = 1;
            this.browseByArtistButton.Text = "By Artist";
            this.browseByArtistButton.UseVisualStyleBackColor = false;
            this.browseByArtistButton.Click += new System.EventHandler(this.browseByArtistButton_Click);
            // 
            // browseByAlbumButton
            // 
            this.browseByAlbumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.browseByAlbumButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseByAlbumButton.ForeColor = System.Drawing.Color.White;
            this.browseByAlbumButton.Location = new System.Drawing.Point(608, 125);
            this.browseByAlbumButton.Name = "browseByAlbumButton";
            this.browseByAlbumButton.Size = new System.Drawing.Size(226, 76);
            this.browseByAlbumButton.TabIndex = 2;
            this.browseByAlbumButton.Text = "By Album";
            this.browseByAlbumButton.UseVisualStyleBackColor = false;
            this.browseByAlbumButton.Click += new System.EventHandler(this.browseByAlbumButton_Click);
            // 
            // browseByPlaylistButton
            // 
            this.browseByPlaylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.browseByPlaylistButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseByPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.browseByPlaylistButton.Location = new System.Drawing.Point(887, 125);
            this.browseByPlaylistButton.Name = "browseByPlaylistButton";
            this.browseByPlaylistButton.Size = new System.Drawing.Size(226, 76);
            this.browseByPlaylistButton.TabIndex = 3;
            this.browseByPlaylistButton.Text = "By Playlist";
            this.browseByPlaylistButton.UseVisualStyleBackColor = false;
            this.browseByPlaylistButton.Click += new System.EventHandler(this.browseByPlaylistButton_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.ForeColor = System.Drawing.Color.White;
            this.selectLabel.Location = new System.Drawing.Point(265, 28);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(690, 54);
            this.selectLabel.TabIndex = 8;
            this.selectLabel.Text = "Select a browse option below:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.exitButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(1287, 28);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 51);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songBindingSource
            // 
            this.songBindingSource.DataMember = "Song";
            this.songBindingSource.DataSource = this.dbDataSet;
            // 
            // songTableAdapter
            // 
            this.songTableAdapter.ClearBeforeFill = true;
            // 
            // browseDataGridView
            // 
            this.browseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.browseDataGridView.Location = new System.Drawing.Point(85, 228);
            this.browseDataGridView.Name = "browseDataGridView";
            this.browseDataGridView.RowHeadersWidth = 82;
            this.browseDataGridView.RowTemplate.Height = 33;
            this.browseDataGridView.Size = new System.Drawing.Size(1306, 519);
            this.browseDataGridView.TabIndex = 10;
            // 
            // browseByConcertButton
            // 
            this.browseByConcertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.browseByConcertButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseByConcertButton.ForeColor = System.Drawing.Color.White;
            this.browseByConcertButton.Location = new System.Drawing.Point(1165, 125);
            this.browseByConcertButton.Name = "browseByConcertButton";
            this.browseByConcertButton.Size = new System.Drawing.Size(226, 76);
            this.browseByConcertButton.TabIndex = 11;
            this.browseByConcertButton.Text = "By Concert";
            this.browseByConcertButton.UseVisualStyleBackColor = false;
            this.browseByConcertButton.Click += new System.EventHandler(this.browseByConcertButton_Click);
            // 
            // browsePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1546, 774);
            this.Controls.Add(this.browseByConcertButton);
            this.Controls.Add(this.browseDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.browseByPlaylistButton);
            this.Controls.Add(this.browseByAlbumButton);
            this.Controls.Add(this.browseByArtistButton);
            this.Controls.Add(this.browseBySongButton);
            this.Font = new System.Drawing.Font("Rockwell", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "browsePage";
            this.Text = "Browse";
            this.Load += new System.EventHandler(this.browsePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBySongButton;
        private System.Windows.Forms.Button browseByArtistButton;
        private System.Windows.Forms.Button browseByAlbumButton;
        private System.Windows.Forms.Button browseByPlaylistButton;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Button exitButton;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource songBindingSource;
        private dbDataSetTableAdapters.SongTableAdapter songTableAdapter;
        private System.Windows.Forms.DataGridView browseDataGridView;
        private System.Windows.Forms.Button browseByConcertButton;
    }
}