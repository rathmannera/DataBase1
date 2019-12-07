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
            this.browseBySongButton = new System.Windows.Forms.Button();
            this.bySongDataGridView = new System.Windows.Forms.DataGridView();
            this.browseByArtistButton = new System.Windows.Forms.Button();
            this.byArtistDataGridView = new System.Windows.Forms.DataGridView();
            this.browseByAlbumButton = new System.Windows.Forms.Button();
            this.byAlbumDataGridView = new System.Windows.Forms.DataGridView();
            this.browseByPlaylistButton = new System.Windows.Forms.Button();
            this.byPlaylistDataGridView = new System.Windows.Forms.DataGridView();
            this.selectLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bySongDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.byArtistDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.byAlbumDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.byPlaylistDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // browseBySongButton
            // 
            this.browseBySongButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.browseBySongButton.Font = new System.Drawing.Font("Quicksand Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBySongButton.ForeColor = System.Drawing.Color.White;
            this.browseBySongButton.Location = new System.Drawing.Point(92, 130);
            this.browseBySongButton.Name = "browseBySongButton";
            this.browseBySongButton.Size = new System.Drawing.Size(245, 79);
            this.browseBySongButton.TabIndex = 0;
            this.browseBySongButton.Text = "By Song";
            this.browseBySongButton.UseVisualStyleBackColor = false;
            this.browseBySongButton.Click += new System.EventHandler(this.browseBySongButton_Click);
            // 
            // bySongDataGridView
            // 
            this.bySongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bySongDataGridView.Location = new System.Drawing.Point(184, 235);
            this.bySongDataGridView.Name = "bySongDataGridView";
            this.bySongDataGridView.RowHeadersWidth = 82;
            this.bySongDataGridView.RowTemplate.Height = 33;
            this.bySongDataGridView.Size = new System.Drawing.Size(674, 427);
            this.bySongDataGridView.TabIndex = 1;
            this.bySongDataGridView.Visible = false;
            // 
            // browseByArtistButton
            // 
            this.browseByArtistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.browseByArtistButton.Font = new System.Drawing.Font("Quicksand Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseByArtistButton.ForeColor = System.Drawing.Color.White;
            this.browseByArtistButton.Location = new System.Drawing.Point(358, 130);
            this.browseByArtistButton.Name = "browseByArtistButton";
            this.browseByArtistButton.Size = new System.Drawing.Size(245, 79);
            this.browseByArtistButton.TabIndex = 2;
            this.browseByArtistButton.Text = "By Artist";
            this.browseByArtistButton.UseVisualStyleBackColor = false;
            this.browseByArtistButton.Click += new System.EventHandler(this.browseByArtistButton_Click);
            // 
            // byArtistDataGridView
            // 
            this.byArtistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.byArtistDataGridView.Location = new System.Drawing.Point(263, 235);
            this.byArtistDataGridView.Name = "byArtistDataGridView";
            this.byArtistDataGridView.RowHeadersWidth = 82;
            this.byArtistDataGridView.RowTemplate.Height = 33;
            this.byArtistDataGridView.Size = new System.Drawing.Size(674, 427);
            this.byArtistDataGridView.TabIndex = 3;
            this.byArtistDataGridView.Visible = false;
            // 
            // browseByAlbumButton
            // 
            this.browseByAlbumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.browseByAlbumButton.Font = new System.Drawing.Font("Quicksand Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseByAlbumButton.ForeColor = System.Drawing.Color.White;
            this.browseByAlbumButton.Location = new System.Drawing.Point(620, 130);
            this.browseByAlbumButton.Name = "browseByAlbumButton";
            this.browseByAlbumButton.Size = new System.Drawing.Size(245, 79);
            this.browseByAlbumButton.TabIndex = 4;
            this.browseByAlbumButton.Text = "By Album";
            this.browseByAlbumButton.UseVisualStyleBackColor = false;
            this.browseByAlbumButton.Click += new System.EventHandler(this.browseByAlbumButton_Click);
            // 
            // byAlbumDataGridView
            // 
            this.byAlbumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.byAlbumDataGridView.Location = new System.Drawing.Point(337, 235);
            this.byAlbumDataGridView.Name = "byAlbumDataGridView";
            this.byAlbumDataGridView.RowHeadersWidth = 82;
            this.byAlbumDataGridView.RowTemplate.Height = 33;
            this.byAlbumDataGridView.Size = new System.Drawing.Size(674, 427);
            this.byAlbumDataGridView.TabIndex = 5;
            this.byAlbumDataGridView.Visible = false;
            // 
            // browseByPlaylistButton
            // 
            this.browseByPlaylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.browseByPlaylistButton.Font = new System.Drawing.Font("Quicksand Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseByPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.browseByPlaylistButton.Location = new System.Drawing.Point(889, 130);
            this.browseByPlaylistButton.Name = "browseByPlaylistButton";
            this.browseByPlaylistButton.Size = new System.Drawing.Size(245, 79);
            this.browseByPlaylistButton.TabIndex = 6;
            this.browseByPlaylistButton.Text = "By Playlist";
            this.browseByPlaylistButton.UseVisualStyleBackColor = false;
            this.browseByPlaylistButton.Click += new System.EventHandler(this.browseByPlaylistButton_Click);
            // 
            // byPlaylistDataGridView
            // 
            this.byPlaylistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.byPlaylistDataGridView.Location = new System.Drawing.Point(409, 235);
            this.byPlaylistDataGridView.Name = "byPlaylistDataGridView";
            this.byPlaylistDataGridView.RowHeadersWidth = 82;
            this.byPlaylistDataGridView.RowTemplate.Height = 33;
            this.byPlaylistDataGridView.Size = new System.Drawing.Size(674, 427);
            this.byPlaylistDataGridView.TabIndex = 7;
            this.byPlaylistDataGridView.Visible = false;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Pacifico", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.ForeColor = System.Drawing.Color.White;
            this.selectLabel.Location = new System.Drawing.Point(287, 29);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(585, 85);
            this.selectLabel.TabIndex = 8;
            this.selectLabel.Text = "Select a browse option below";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.exitButton.Font = new System.Drawing.Font("Quicksand Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(1093, 29);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 53);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // browsePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1364, 720);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.byPlaylistDataGridView);
            this.Controls.Add(this.browseByPlaylistButton);
            this.Controls.Add(this.byAlbumDataGridView);
            this.Controls.Add(this.browseByAlbumButton);
            this.Controls.Add(this.byArtistDataGridView);
            this.Controls.Add(this.browseByArtistButton);
            this.Controls.Add(this.bySongDataGridView);
            this.Controls.Add(this.browseBySongButton);
            this.Font = new System.Drawing.Font("Quicksand Book", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "browsePage";
            this.Text = "Browse Page";
            this.Load += new System.EventHandler(this.browsePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bySongDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.byArtistDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.byAlbumDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.byPlaylistDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBySongButton;
        private System.Windows.Forms.DataGridView bySongDataGridView;
        private System.Windows.Forms.Button browseByArtistButton;
        private System.Windows.Forms.DataGridView byArtistDataGridView;
        private System.Windows.Forms.Button browseByAlbumButton;
        private System.Windows.Forms.DataGridView byAlbumDataGridView;
        private System.Windows.Forms.Button browseByPlaylistButton;
        private System.Windows.Forms.DataGridView byPlaylistDataGridView;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Button exitButton;
    }
}