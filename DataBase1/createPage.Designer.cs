namespace DataBase1
{
    partial class createPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createPage));
            this.addPlaylistButton = new System.Windows.Forms.Button();
            this.addPlaylistGroupBox = new System.Windows.Forms.GroupBox();
            this.clearPlaylistButton = new System.Windows.Forms.Button();
            this.songAndIDDataGridView = new System.Windows.Forms.DataGridView();
            this.createPlaylistButton = new System.Windows.Forms.Button();
            this.song9TextBox = new System.Windows.Forms.TextBox();
            this.song7TextBox = new System.Windows.Forms.TextBox();
            this.song10TextBox = new System.Windows.Forms.TextBox();
            this.song8TextBox = new System.Windows.Forms.TextBox();
            this.song5TextBox = new System.Windows.Forms.TextBox();
            this.song3TextBox = new System.Windows.Forms.TextBox();
            this.song4TextBox = new System.Windows.Forms.TextBox();
            this.song6TextBox = new System.Windows.Forms.TextBox();
            this.song2TextBox = new System.Windows.Forms.TextBox();
            this.song1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playlistNameTextBox = new System.Windows.Forms.TextBox();
            this.selectSongsLabel = new System.Windows.Forms.Label();
            this.songBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new DataBase1.dbDataSet();
            this.songTableAdapter = new DataBase1.dbDataSetTableAdapters.SongTableAdapter();
            this.tableAdapterManager = new DataBase1.dbDataSetTableAdapters.TableAdapterManager();
            this.exitButton = new System.Windows.Forms.Button();
            this.addConcertButton = new System.Windows.Forms.Button();
            this.createLabel = new System.Windows.Forms.Label();
            this.addConcertGroupBox = new System.Windows.Forms.GroupBox();
            this.createConcertInstructionsLabel = new System.Windows.Forms.Label();
            this.selectSongArtistIDLabel = new System.Windows.Forms.Label();
            this.songID9TextBox = new System.Windows.Forms.TextBox();
            this.songID7TextBox = new System.Windows.Forms.TextBox();
            this.songID10TextBox = new System.Windows.Forms.TextBox();
            this.songID8TextBox = new System.Windows.Forms.TextBox();
            this.songID5TextBox = new System.Windows.Forms.TextBox();
            this.songID3TextBox = new System.Windows.Forms.TextBox();
            this.songID4TextBox = new System.Windows.Forms.TextBox();
            this.songID6TextBox = new System.Windows.Forms.TextBox();
            this.songID2TextBox = new System.Windows.Forms.TextBox();
            this.songID1TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.venueTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.artistIDTextBox = new System.Windows.Forms.TextBox();
            this.songArtistDataGridView = new System.Windows.Forms.DataGridView();
            this.clearConcertButton = new System.Windows.Forms.Button();
            this.createConcertButton = new System.Windows.Forms.Button();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.addPlaylistGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songAndIDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.addConcertGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songArtistDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addPlaylistButton
            // 
            this.addPlaylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.addPlaylistButton.Font = new System.Drawing.Font("Rockwell", 9F);
            this.addPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.addPlaylistButton.Location = new System.Drawing.Point(85, 132);
            this.addPlaylistButton.Name = "addPlaylistButton";
            this.addPlaylistButton.Size = new System.Drawing.Size(176, 66);
            this.addPlaylistButton.TabIndex = 0;
            this.addPlaylistButton.Text = "Add Playlist";
            this.addPlaylistButton.UseVisualStyleBackColor = false;
            this.addPlaylistButton.Click += new System.EventHandler(this.addPlaylistButton_Click);
            // 
            // addPlaylistGroupBox
            // 
            this.addPlaylistGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.addPlaylistGroupBox.Controls.Add(this.clearPlaylistButton);
            this.addPlaylistGroupBox.Controls.Add(this.songAndIDDataGridView);
            this.addPlaylistGroupBox.Controls.Add(this.createPlaylistButton);
            this.addPlaylistGroupBox.Controls.Add(this.song9TextBox);
            this.addPlaylistGroupBox.Controls.Add(this.song7TextBox);
            this.addPlaylistGroupBox.Controls.Add(this.song10TextBox);
            this.addPlaylistGroupBox.Controls.Add(this.song8TextBox);
            this.addPlaylistGroupBox.Controls.Add(this.song5TextBox);
            this.addPlaylistGroupBox.Controls.Add(this.song3TextBox);
            this.addPlaylistGroupBox.Controls.Add(this.song4TextBox);
            this.addPlaylistGroupBox.Controls.Add(this.song6TextBox);
            this.addPlaylistGroupBox.Controls.Add(this.song2TextBox);
            this.addPlaylistGroupBox.Controls.Add(this.song1TextBox);
            this.addPlaylistGroupBox.Controls.Add(this.label1);
            this.addPlaylistGroupBox.Controls.Add(this.playlistNameTextBox);
            this.addPlaylistGroupBox.Controls.Add(this.selectSongsLabel);
            this.addPlaylistGroupBox.Location = new System.Drawing.Point(85, 222);
            this.addPlaylistGroupBox.Name = "addPlaylistGroupBox";
            this.addPlaylistGroupBox.Size = new System.Drawing.Size(1205, 693);
            this.addPlaylistGroupBox.TabIndex = 2;
            this.addPlaylistGroupBox.TabStop = false;
            this.addPlaylistGroupBox.Visible = false;
            // 
            // clearPlaylistButton
            // 
            this.clearPlaylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.clearPlaylistButton.Font = new System.Drawing.Font("Rockwell", 9F);
            this.clearPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.clearPlaylistButton.Location = new System.Drawing.Point(514, 613);
            this.clearPlaylistButton.Name = "clearPlaylistButton";
            this.clearPlaylistButton.Size = new System.Drawing.Size(218, 57);
            this.clearPlaylistButton.TabIndex = 12;
            this.clearPlaylistButton.Text = "Clear Entries";
            this.clearPlaylistButton.UseVisualStyleBackColor = false;
            this.clearPlaylistButton.Click += new System.EventHandler(this.clearPlaylistButton_Click);
            // 
            // songAndIDDataGridView
            // 
            this.songAndIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songAndIDDataGridView.Location = new System.Drawing.Point(35, 90);
            this.songAndIDDataGridView.Name = "songAndIDDataGridView";
            this.songAndIDDataGridView.RowHeadersWidth = 82;
            this.songAndIDDataGridView.RowTemplate.Height = 33;
            this.songAndIDDataGridView.Size = new System.Drawing.Size(608, 426);
            this.songAndIDDataGridView.TabIndex = 15;
            // 
            // createPlaylistButton
            // 
            this.createPlaylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.createPlaylistButton.Font = new System.Drawing.Font("Rockwell", 9F);
            this.createPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.createPlaylistButton.Location = new System.Drawing.Point(514, 550);
            this.createPlaylistButton.Name = "createPlaylistButton";
            this.createPlaylistButton.Size = new System.Drawing.Size(218, 57);
            this.createPlaylistButton.TabIndex = 11;
            this.createPlaylistButton.Text = "Create";
            this.createPlaylistButton.UseVisualStyleBackColor = false;
            this.createPlaylistButton.Click += new System.EventHandler(this.createPlaylistButton_Click);
            // 
            // song9TextBox
            // 
            this.song9TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.song9TextBox.Location = new System.Drawing.Point(730, 435);
            this.song9TextBox.Name = "song9TextBox";
            this.song9TextBox.Size = new System.Drawing.Size(334, 32);
            this.song9TextBox.TabIndex = 9;
            this.song9TextBox.Text = "Song ID 9";
            this.song9TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // song7TextBox
            // 
            this.song7TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.song7TextBox.Location = new System.Drawing.Point(730, 367);
            this.song7TextBox.Name = "song7TextBox";
            this.song7TextBox.Size = new System.Drawing.Size(334, 32);
            this.song7TextBox.TabIndex = 7;
            this.song7TextBox.Text = "Song ID 7";
            this.song7TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // song10TextBox
            // 
            this.song10TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.song10TextBox.Location = new System.Drawing.Point(730, 469);
            this.song10TextBox.Name = "song10TextBox";
            this.song10TextBox.Size = new System.Drawing.Size(334, 32);
            this.song10TextBox.TabIndex = 10;
            this.song10TextBox.Text = "Song ID 10";
            this.song10TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // song8TextBox
            // 
            this.song8TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.song8TextBox.Location = new System.Drawing.Point(730, 401);
            this.song8TextBox.Name = "song8TextBox";
            this.song8TextBox.Size = new System.Drawing.Size(334, 32);
            this.song8TextBox.TabIndex = 8;
            this.song8TextBox.Text = "Song ID 8";
            this.song8TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // song5TextBox
            // 
            this.song5TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.song5TextBox.Location = new System.Drawing.Point(730, 297);
            this.song5TextBox.Name = "song5TextBox";
            this.song5TextBox.Size = new System.Drawing.Size(334, 32);
            this.song5TextBox.TabIndex = 5;
            this.song5TextBox.Text = "Song ID 5";
            this.song5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // song3TextBox
            // 
            this.song3TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.song3TextBox.Location = new System.Drawing.Point(730, 229);
            this.song3TextBox.Name = "song3TextBox";
            this.song3TextBox.Size = new System.Drawing.Size(334, 32);
            this.song3TextBox.TabIndex = 3;
            this.song3TextBox.Text = "Song ID 3";
            this.song3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // song4TextBox
            // 
            this.song4TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.song4TextBox.Location = new System.Drawing.Point(730, 263);
            this.song4TextBox.Name = "song4TextBox";
            this.song4TextBox.Size = new System.Drawing.Size(334, 32);
            this.song4TextBox.TabIndex = 4;
            this.song4TextBox.Text = "Song ID 4";
            this.song4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // song6TextBox
            // 
            this.song6TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.song6TextBox.Location = new System.Drawing.Point(730, 331);
            this.song6TextBox.Name = "song6TextBox";
            this.song6TextBox.Size = new System.Drawing.Size(334, 32);
            this.song6TextBox.TabIndex = 6;
            this.song6TextBox.Text = "Song ID 6";
            this.song6TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // song2TextBox
            // 
            this.song2TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.song2TextBox.Location = new System.Drawing.Point(730, 195);
            this.song2TextBox.Name = "song2TextBox";
            this.song2TextBox.Size = new System.Drawing.Size(334, 32);
            this.song2TextBox.TabIndex = 2;
            this.song2TextBox.Text = "Song ID 2";
            this.song2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // song1TextBox
            // 
            this.song1TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.song1TextBox.Location = new System.Drawing.Point(730, 161);
            this.song1TextBox.Name = "song1TextBox";
            this.song1TextBox.Size = new System.Drawing.Size(334, 32);
            this.song1TextBox.TabIndex = 1;
            this.song1TextBox.Text = "Song ID 1";
            this.song1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(685, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter playlist name and 10 song id\'s below:";
            // 
            // playlistNameTextBox
            // 
            this.playlistNameTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.playlistNameTextBox.Location = new System.Drawing.Point(730, 116);
            this.playlistNameTextBox.Name = "playlistNameTextBox";
            this.playlistNameTextBox.Size = new System.Drawing.Size(334, 32);
            this.playlistNameTextBox.TabIndex = 0;
            this.playlistNameTextBox.Text = "Playlist Name";
            this.playlistNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectSongsLabel
            // 
            this.selectSongsLabel.AutoSize = true;
            this.selectSongsLabel.Font = new System.Drawing.Font("Rockwell", 10F);
            this.selectSongsLabel.ForeColor = System.Drawing.Color.White;
            this.selectSongsLabel.Location = new System.Drawing.Point(29, 40);
            this.selectSongsLabel.Name = "selectSongsLabel";
            this.selectSongsLabel.Size = new System.Drawing.Size(342, 31);
            this.selectSongsLabel.TabIndex = 0;
            this.selectSongsLabel.Text = "List of Songs and Song IDs:";
            // 
            // songBindingSource
            // 
            this.songBindingSource.DataMember = "Song";
            this.songBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songTableAdapter
            // 
            this.songTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumTableAdapter = null;
            this.tableAdapterManager.Artist_albumTableAdapter = null;
            this.tableAdapterManager.Artist_concertTableAdapter = null;
            this.tableAdapterManager.ArtistTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConcertTableAdapter = null;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.Group_memberTableAdapter = null;
            this.tableAdapterManager.LabelTableAdapter = null;
            this.tableAdapterManager.PlaylistTableAdapter = null;
            this.tableAdapterManager.Song_albumTableAdapter = null;
            this.tableAdapterManager.Song_concertTableAdapter = null;
            this.tableAdapterManager.Song_playlistTableAdapter = null;
            this.tableAdapterManager.SongTableAdapter = this.songTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataBase1.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.exitButton.Font = new System.Drawing.Font("Rockwell", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(1340, 132);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 66);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addConcertButton
            // 
            this.addConcertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.addConcertButton.Font = new System.Drawing.Font("Rockwell", 9F);
            this.addConcertButton.ForeColor = System.Drawing.Color.White;
            this.addConcertButton.Location = new System.Drawing.Point(303, 132);
            this.addConcertButton.Name = "addConcertButton";
            this.addConcertButton.Size = new System.Drawing.Size(176, 66);
            this.addConcertButton.TabIndex = 1;
            this.addConcertButton.Text = "Add Concert";
            this.addConcertButton.UseVisualStyleBackColor = false;
            this.addConcertButton.Click += new System.EventHandler(this.addConcertButton_Click);
            // 
            // createLabel
            // 
            this.createLabel.AutoSize = true;
            this.createLabel.Font = new System.Drawing.Font("Rockwell", 18F);
            this.createLabel.ForeColor = System.Drawing.Color.Transparent;
            this.createLabel.Location = new System.Drawing.Point(86, 46);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(526, 54);
            this.createLabel.TabIndex = 4;
            this.createLabel.Text = "Select an option below";
            // 
            // addConcertGroupBox
            // 
            this.addConcertGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(217)))), ((int)(((byte)(199)))));
            this.addConcertGroupBox.Controls.Add(this.stateTextBox);
            this.addConcertGroupBox.Controls.Add(this.createConcertInstructionsLabel);
            this.addConcertGroupBox.Controls.Add(this.selectSongArtistIDLabel);
            this.addConcertGroupBox.Controls.Add(this.songID9TextBox);
            this.addConcertGroupBox.Controls.Add(this.songID7TextBox);
            this.addConcertGroupBox.Controls.Add(this.songID10TextBox);
            this.addConcertGroupBox.Controls.Add(this.songID8TextBox);
            this.addConcertGroupBox.Controls.Add(this.songID5TextBox);
            this.addConcertGroupBox.Controls.Add(this.songID3TextBox);
            this.addConcertGroupBox.Controls.Add(this.songID4TextBox);
            this.addConcertGroupBox.Controls.Add(this.songID6TextBox);
            this.addConcertGroupBox.Controls.Add(this.songID2TextBox);
            this.addConcertGroupBox.Controls.Add(this.songID1TextBox);
            this.addConcertGroupBox.Controls.Add(this.cityTextBox);
            this.addConcertGroupBox.Controls.Add(this.venueTextBox);
            this.addConcertGroupBox.Controls.Add(this.countryTextBox);
            this.addConcertGroupBox.Controls.Add(this.yearTextBox);
            this.addConcertGroupBox.Controls.Add(this.artistIDTextBox);
            this.addConcertGroupBox.Controls.Add(this.songArtistDataGridView);
            this.addConcertGroupBox.Controls.Add(this.clearConcertButton);
            this.addConcertGroupBox.Controls.Add(this.createConcertButton);
            this.addConcertGroupBox.Location = new System.Drawing.Point(85, 222);
            this.addConcertGroupBox.Name = "addConcertGroupBox";
            this.addConcertGroupBox.Size = new System.Drawing.Size(1478, 814);
            this.addConcertGroupBox.TabIndex = 3;
            this.addConcertGroupBox.TabStop = false;
            this.addConcertGroupBox.Visible = false;
            // 
            // createConcertInstructionsLabel
            // 
            this.createConcertInstructionsLabel.AutoSize = true;
            this.createConcertInstructionsLabel.ForeColor = System.Drawing.Color.White;
            this.createConcertInstructionsLabel.Location = new System.Drawing.Point(889, 37);
            this.createConcertInstructionsLabel.Name = "createConcertInstructionsLabel";
            this.createConcertInstructionsLabel.Size = new System.Drawing.Size(534, 69);
            this.createConcertInstructionsLabel.TabIndex = 16;
            this.createConcertInstructionsLabel.Text = "Enter Artist ID, Concert City, Concert Venue,\r\n Concert State, Concert Country, C" +
    "oncert Year, as well\r\n as 10 song IDs of songs performed at the concert:\r\n";
            this.createConcertInstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectSongArtistIDLabel
            // 
            this.selectSongArtistIDLabel.AutoSize = true;
            this.selectSongArtistIDLabel.Font = new System.Drawing.Font("Rockwell", 10F);
            this.selectSongArtistIDLabel.ForeColor = System.Drawing.Color.White;
            this.selectSongArtistIDLabel.Location = new System.Drawing.Point(86, 53);
            this.selectSongArtistIDLabel.Name = "selectSongArtistIDLabel";
            this.selectSongArtistIDLabel.Size = new System.Drawing.Size(575, 31);
            this.selectSongArtistIDLabel.TabIndex = 16;
            this.selectSongArtistIDLabel.Text = "List of Songs, Song IDs, Artists and Artists IDs:";
            // 
            // songID9TextBox
            // 
            this.songID9TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.songID9TextBox.Location = new System.Drawing.Point(1158, 524);
            this.songID9TextBox.Name = "songID9TextBox";
            this.songID9TextBox.Size = new System.Drawing.Size(265, 32);
            this.songID9TextBox.TabIndex = 13;
            this.songID9TextBox.Text = "Song ID 9";
            this.songID9TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // songID7TextBox
            // 
            this.songID7TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.songID7TextBox.Location = new System.Drawing.Point(1158, 422);
            this.songID7TextBox.Name = "songID7TextBox";
            this.songID7TextBox.Size = new System.Drawing.Size(265, 32);
            this.songID7TextBox.TabIndex = 11;
            this.songID7TextBox.Text = "Song ID 7";
            this.songID7TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // songID10TextBox
            // 
            this.songID10TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.songID10TextBox.Location = new System.Drawing.Point(1158, 575);
            this.songID10TextBox.Name = "songID10TextBox";
            this.songID10TextBox.Size = new System.Drawing.Size(265, 32);
            this.songID10TextBox.TabIndex = 14;
            this.songID10TextBox.Text = "Song ID 10";
            this.songID10TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // songID8TextBox
            // 
            this.songID8TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.songID8TextBox.Location = new System.Drawing.Point(1158, 473);
            this.songID8TextBox.Name = "songID8TextBox";
            this.songID8TextBox.Size = new System.Drawing.Size(265, 32);
            this.songID8TextBox.TabIndex = 12;
            this.songID8TextBox.Text = "Song ID 8";
            this.songID8TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // songID5TextBox
            // 
            this.songID5TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.songID5TextBox.Location = new System.Drawing.Point(1158, 320);
            this.songID5TextBox.Name = "songID5TextBox";
            this.songID5TextBox.Size = new System.Drawing.Size(265, 32);
            this.songID5TextBox.TabIndex = 9;
            this.songID5TextBox.Text = "Song ID 5";
            this.songID5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // songID3TextBox
            // 
            this.songID3TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.songID3TextBox.Location = new System.Drawing.Point(1158, 218);
            this.songID3TextBox.Name = "songID3TextBox";
            this.songID3TextBox.Size = new System.Drawing.Size(265, 32);
            this.songID3TextBox.TabIndex = 7;
            this.songID3TextBox.Text = "Song ID 3";
            this.songID3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // songID4TextBox
            // 
            this.songID4TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.songID4TextBox.Location = new System.Drawing.Point(1158, 269);
            this.songID4TextBox.Name = "songID4TextBox";
            this.songID4TextBox.Size = new System.Drawing.Size(265, 32);
            this.songID4TextBox.TabIndex = 8;
            this.songID4TextBox.Text = "Song ID 4";
            this.songID4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // songID6TextBox
            // 
            this.songID6TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.songID6TextBox.Location = new System.Drawing.Point(1158, 371);
            this.songID6TextBox.Name = "songID6TextBox";
            this.songID6TextBox.Size = new System.Drawing.Size(265, 32);
            this.songID6TextBox.TabIndex = 10;
            this.songID6TextBox.Text = "Song ID 6";
            this.songID6TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // songID2TextBox
            // 
            this.songID2TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.songID2TextBox.Location = new System.Drawing.Point(1158, 167);
            this.songID2TextBox.Name = "songID2TextBox";
            this.songID2TextBox.Size = new System.Drawing.Size(265, 32);
            this.songID2TextBox.TabIndex = 6;
            this.songID2TextBox.Text = "Song ID 2";
            this.songID2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // songID1TextBox
            // 
            this.songID1TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.songID1TextBox.Location = new System.Drawing.Point(1158, 116);
            this.songID1TextBox.Name = "songID1TextBox";
            this.songID1TextBox.Size = new System.Drawing.Size(265, 32);
            this.songID1TextBox.TabIndex = 5;
            this.songID1TextBox.Text = "Song ID 1";
            this.songID1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cityTextBox
            // 
            this.cityTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cityTextBox.Location = new System.Drawing.Point(881, 302);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(265, 32);
            this.cityTextBox.TabIndex = 1;
            this.cityTextBox.Text = "City";
            this.cityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // venueTextBox
            // 
            this.venueTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.venueTextBox.Location = new System.Drawing.Point(881, 209);
            this.venueTextBox.Name = "venueTextBox";
            this.venueTextBox.Size = new System.Drawing.Size(265, 32);
            this.venueTextBox.TabIndex = 2;
            this.venueTextBox.Text = "Venue";
            this.venueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countryTextBox
            // 
            this.countryTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.countryTextBox.Location = new System.Drawing.Point(881, 488);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(265, 32);
            this.countryTextBox.TabIndex = 3;
            this.countryTextBox.Text = "Country";
            this.countryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearTextBox
            // 
            this.yearTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.yearTextBox.Location = new System.Drawing.Point(881, 581);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(265, 32);
            this.yearTextBox.TabIndex = 4;
            this.yearTextBox.Text = "Year";
            this.yearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // artistIDTextBox
            // 
            this.artistIDTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.artistIDTextBox.Location = new System.Drawing.Point(881, 116);
            this.artistIDTextBox.Name = "artistIDTextBox";
            this.artistIDTextBox.Size = new System.Drawing.Size(265, 32);
            this.artistIDTextBox.TabIndex = 0;
            this.artistIDTextBox.Text = "Artist ID";
            this.artistIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // songArtistDataGridView
            // 
            this.songArtistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songArtistDataGridView.Location = new System.Drawing.Point(81, 115);
            this.songArtistDataGridView.Name = "songArtistDataGridView";
            this.songArtistDataGridView.RowHeadersWidth = 82;
            this.songArtistDataGridView.RowTemplate.Height = 33;
            this.songArtistDataGridView.Size = new System.Drawing.Size(762, 500);
            this.songArtistDataGridView.TabIndex = 17;
            // 
            // clearConcertButton
            // 
            this.clearConcertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.clearConcertButton.Font = new System.Drawing.Font("Rockwell", 9F);
            this.clearConcertButton.ForeColor = System.Drawing.Color.White;
            this.clearConcertButton.Location = new System.Drawing.Point(661, 724);
            this.clearConcertButton.Name = "clearConcertButton";
            this.clearConcertButton.Size = new System.Drawing.Size(218, 57);
            this.clearConcertButton.TabIndex = 16;
            this.clearConcertButton.Text = "Clear Entries";
            this.clearConcertButton.UseVisualStyleBackColor = false;
            this.clearConcertButton.Click += new System.EventHandler(this.clearConcertButton_Click);
            // 
            // createConcertButton
            // 
            this.createConcertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.createConcertButton.Font = new System.Drawing.Font("Rockwell", 9F);
            this.createConcertButton.ForeColor = System.Drawing.Color.White;
            this.createConcertButton.Location = new System.Drawing.Point(661, 661);
            this.createConcertButton.Name = "createConcertButton";
            this.createConcertButton.Size = new System.Drawing.Size(218, 57);
            this.createConcertButton.TabIndex = 15;
            this.createConcertButton.Text = "Create";
            this.createConcertButton.UseVisualStyleBackColor = false;
            this.createConcertButton.Click += new System.EventHandler(this.createConcertButton_Click);
            // 
            // stateTextBox
            // 
            this.stateTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.stateTextBox.Location = new System.Drawing.Point(881, 395);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(265, 32);
            this.stateTextBox.TabIndex = 18;
            this.stateTextBox.Text = "State";
            this.stateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1750, 1084);
            this.Controls.Add(this.addConcertGroupBox);
            this.Controls.Add(this.createLabel);
            this.Controls.Add(this.addConcertButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addPlaylistGroupBox);
            this.Controls.Add(this.addPlaylistButton);
            this.Font = new System.Drawing.Font("Rockwell", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createPage";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.createPage_Load);
            this.addPlaylistGroupBox.ResumeLayout(false);
            this.addPlaylistGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songAndIDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.addConcertGroupBox.ResumeLayout(false);
            this.addConcertGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songArtistDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPlaylistButton;
        private System.Windows.Forms.GroupBox addPlaylistGroupBox;
        private System.Windows.Forms.Label selectSongsLabel;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource songBindingSource;
        private dbDataSetTableAdapters.SongTableAdapter songTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox playlistNameTextBox;
        private System.Windows.Forms.TextBox song1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox song9TextBox;
        private System.Windows.Forms.TextBox song7TextBox;
        private System.Windows.Forms.TextBox song10TextBox;
        private System.Windows.Forms.TextBox song8TextBox;
        private System.Windows.Forms.TextBox song5TextBox;
        private System.Windows.Forms.TextBox song3TextBox;
        private System.Windows.Forms.TextBox song4TextBox;
        private System.Windows.Forms.TextBox song6TextBox;
        private System.Windows.Forms.TextBox song2TextBox;
        private System.Windows.Forms.Button createPlaylistButton;
        private System.Windows.Forms.DataGridView songAndIDDataGridView;
        private System.Windows.Forms.Button clearPlaylistButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addConcertButton;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.GroupBox addConcertGroupBox;
        private System.Windows.Forms.Button clearConcertButton;
        private System.Windows.Forms.Button createConcertButton;
        private System.Windows.Forms.DataGridView songArtistDataGridView;
        private System.Windows.Forms.TextBox songID9TextBox;
        private System.Windows.Forms.TextBox songID7TextBox;
        private System.Windows.Forms.TextBox songID10TextBox;
        private System.Windows.Forms.TextBox songID8TextBox;
        private System.Windows.Forms.TextBox songID5TextBox;
        private System.Windows.Forms.TextBox songID3TextBox;
        private System.Windows.Forms.TextBox songID4TextBox;
        private System.Windows.Forms.TextBox songID6TextBox;
        private System.Windows.Forms.TextBox songID2TextBox;
        private System.Windows.Forms.TextBox songID1TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox venueTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox artistIDTextBox;
        private System.Windows.Forms.Label selectSongArtistIDLabel;
        private System.Windows.Forms.Label createConcertInstructionsLabel;
        private System.Windows.Forms.TextBox stateTextBox;
    }
}