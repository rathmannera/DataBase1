using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace DataBase1
{
    public partial class createPage : Form
    {
        public createPage()
        {
            InitializeComponent();
        }

        private void createPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.Song' table. You can move, or remove it, as needed.
            this.songTableAdapter.Fill(this.dbDataSet.Song);

        }

        private void addPlaylistButton_Click(object sender, EventArgs e)
        {
            addPlaylistGroupBox.Visible = true;
            addConcertGroupBox.Visible = false;

            string sqlGetSongDataQuery = "SELECT song_id AS `Song ID`, song_name AS `Song Name` " +
                                            "FROM Song";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlGetSongDataCommand = new MySqlCommand(sqlGetSongDataQuery, sqlConnection);
            MySqlDataAdapter sqlSongDataAdpter = new MySqlDataAdapter(sqlGetSongDataCommand);
            DataTable songDataDataTable = new DataTable();
            sqlSongDataAdpter.Fill(songDataDataTable);
            songAndIDDataGridView.DataSource = songDataDataTable;
            sqlConnection.Close();

        }

        private void createPlaylistButton_Click(object sender, EventArgs e)
        {
            string userPlaylistName = playlistNameTextBox.Text;
            string song1ID = song1TextBox.Text;
            string song2ID = song2TextBox.Text;
            string song3ID = song3TextBox.Text;
            string song4ID = song4TextBox.Text;
            string song5ID = song5TextBox.Text;
            string song6ID = song6TextBox.Text;
            string song7ID = song7TextBox.Text;
            string song8ID = song8TextBox.Text;
            string song9ID = song9TextBox.Text;
            string song10ID = song10TextBox.Text;

            string sqlInsertPlaylistQuery = "INSERT INTO blairs2_db.Playlist (playlist_name) VALUES (@userPlaylistName)";
            string sqlInsertSongsIntoPlaylistQuery1 = "INSERT INTO blairs2_db.Song_playlist(song_id, playlist_id) " +
                                "VALUES(@songID1, (SELECT playlist_id FROM Playlist WHERE playlist_name = @playlistName))";
            string sqlInsertSongsIntoPlaylistQuery2 = "INSERT INTO blairs2_db.Song_playlist(song_id, playlist_id) " +
                                "VALUES(@songID2, (SELECT playlist_id FROM Playlist WHERE playlist_name = @playlistName))";
            string sqlInsertSongsIntoPlaylistQuery3 = "INSERT INTO blairs2_db.Song_playlist(song_id, playlist_id) " +
                                "VALUES(@songID3, (SELECT playlist_id FROM Playlist WHERE playlist_name = @playlistName))";
            string sqlInsertSongsIntoPlaylistQuery4 = "INSERT INTO blairs2_db.Song_playlist(song_id, playlist_id) " +
                                "VALUES(@songID4, (SELECT playlist_id FROM Playlist WHERE playlist_name = @playlistName))";
            string sqlInsertSongsIntoPlaylistQuery5 = "INSERT INTO blairs2_db.Song_playlist(song_id, playlist_id) " +
                                "VALUES(@songID5, (SELECT playlist_id FROM Playlist WHERE playlist_name = @playlistName))";
            string sqlInsertSongsIntoPlaylistQuery6 = "INSERT INTO blairs2_db.Song_playlist(song_id, playlist_id) " +
                                "VALUES(@songID6, (SELECT playlist_id FROM Playlist WHERE playlist_name = @playlistName))";
            string sqlInsertSongsIntoPlaylistQuery7 = "INSERT INTO blairs2_db.Song_playlist(song_id, playlist_id) " +
                                "VALUES(@songID7, (SELECT playlist_id FROM Playlist WHERE playlist_name = @playlistName))";
            string sqlInsertSongsIntoPlaylistQuery8 = "INSERT INTO blairs2_db.Song_playlist(song_id, playlist_id) " +
                                "VALUES(@songID8, (SELECT playlist_id FROM Playlist WHERE playlist_name = @playlistName))";
            string sqlInsertSongsIntoPlaylistQuery9 = "INSERT INTO blairs2_db.Song_playlist(song_id, playlist_id) " +
                                "VALUES(@songID9, (SELECT playlist_id FROM Playlist WHERE playlist_name = @playlistName))";
            string sqlInsertSongsIntoPlaylistQuery10 = "INSERT INTO blairs2_db.Song_playlist(song_id, playlist_id) " +
                                "VALUES(@songID10, (SELECT playlist_id FROM Playlist WHERE playlist_name = @playlistName))";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlInsertPlaylistCommand = new MySqlCommand(sqlInsertPlaylistQuery, sqlConnection);
            MySqlCommand sqlInsertSongIntoPlayComm1 = new MySqlCommand(sqlInsertSongsIntoPlaylistQuery1, sqlConnection);
            MySqlCommand sqlInsertSongIntoPlayComm2 = new MySqlCommand(sqlInsertSongsIntoPlaylistQuery2, sqlConnection);
            MySqlCommand sqlInsertSongIntoPlayComm3 = new MySqlCommand(sqlInsertSongsIntoPlaylistQuery3, sqlConnection);
            MySqlCommand sqlInsertSongIntoPlayComm4 = new MySqlCommand(sqlInsertSongsIntoPlaylistQuery4, sqlConnection);
            MySqlCommand sqlInsertSongIntoPlayComm5 = new MySqlCommand(sqlInsertSongsIntoPlaylistQuery5, sqlConnection);
            MySqlCommand sqlInsertSongIntoPlayComm6 = new MySqlCommand(sqlInsertSongsIntoPlaylistQuery6, sqlConnection);
            MySqlCommand sqlInsertSongIntoPlayComm7 = new MySqlCommand(sqlInsertSongsIntoPlaylistQuery7, sqlConnection);
            MySqlCommand sqlInsertSongIntoPlayComm8 = new MySqlCommand(sqlInsertSongsIntoPlaylistQuery8, sqlConnection);
            MySqlCommand sqlInsertSongIntoPlayComm9 = new MySqlCommand(sqlInsertSongsIntoPlaylistQuery9, sqlConnection);
            MySqlCommand sqlInsertSongIntoPlayComm10 = new MySqlCommand(sqlInsertSongsIntoPlaylistQuery10, sqlConnection);


            sqlInsertPlaylistCommand.Parameters.Add("@userPlaylistName", MySqlDbType.VarChar).Value = userPlaylistName;
            sqlInsertSongIntoPlayComm1.Parameters.Add("@songID1", MySqlDbType.VarChar).Value = song1ID;
            sqlInsertSongIntoPlayComm1.Parameters.Add("@playlistName", MySqlDbType.VarChar).Value = userPlaylistName;
            sqlInsertSongIntoPlayComm2.Parameters.Add("@songID2", MySqlDbType.VarChar).Value = song2ID;
            sqlInsertSongIntoPlayComm2.Parameters.Add("@playlistName", MySqlDbType.VarChar).Value = userPlaylistName;
            sqlInsertSongIntoPlayComm3.Parameters.Add("@songID3", MySqlDbType.VarChar).Value = song3ID;
            sqlInsertSongIntoPlayComm3.Parameters.Add("@playlistName", MySqlDbType.VarChar).Value = userPlaylistName;
            sqlInsertSongIntoPlayComm4.Parameters.Add("@songID4", MySqlDbType.VarChar).Value = song4ID;
            sqlInsertSongIntoPlayComm4.Parameters.Add("@playlistName", MySqlDbType.VarChar).Value = userPlaylistName;
            sqlInsertSongIntoPlayComm5.Parameters.Add("@songID5", MySqlDbType.VarChar).Value = song5ID;
            sqlInsertSongIntoPlayComm5.Parameters.Add("@playlistName", MySqlDbType.VarChar).Value = userPlaylistName;
            sqlInsertSongIntoPlayComm6.Parameters.Add("@songID6", MySqlDbType.VarChar).Value = song6ID;
            sqlInsertSongIntoPlayComm6.Parameters.Add("@playlistName", MySqlDbType.VarChar).Value = userPlaylistName;
            sqlInsertSongIntoPlayComm7.Parameters.Add("@songID7", MySqlDbType.VarChar).Value = song7ID;
            sqlInsertSongIntoPlayComm7.Parameters.Add("@playlistName", MySqlDbType.VarChar).Value = userPlaylistName;
            sqlInsertSongIntoPlayComm8.Parameters.Add("@songID8", MySqlDbType.VarChar).Value = song8ID;
            sqlInsertSongIntoPlayComm8.Parameters.Add("@playlistName", MySqlDbType.VarChar).Value = userPlaylistName;
            sqlInsertSongIntoPlayComm9.Parameters.Add("@songID9", MySqlDbType.VarChar).Value = song9ID;
            sqlInsertSongIntoPlayComm9.Parameters.Add("@playlistName", MySqlDbType.VarChar).Value = userPlaylistName;
            sqlInsertSongIntoPlayComm10.Parameters.Add("@songID10", MySqlDbType.VarChar).Value = song10ID;
            sqlInsertSongIntoPlayComm10.Parameters.Add("@playlistName", MySqlDbType.VarChar).Value = userPlaylistName;

            sqlInsertPlaylistCommand.ExecuteNonQuery();
            sqlInsertSongIntoPlayComm1.ExecuteNonQuery();
            sqlInsertSongIntoPlayComm2.ExecuteNonQuery();
            sqlInsertSongIntoPlayComm3.ExecuteNonQuery();
            sqlInsertSongIntoPlayComm4.ExecuteNonQuery();
            sqlInsertSongIntoPlayComm5.ExecuteNonQuery();
            sqlInsertSongIntoPlayComm6.ExecuteNonQuery();
            sqlInsertSongIntoPlayComm7.ExecuteNonQuery();
            sqlInsertSongIntoPlayComm8.ExecuteNonQuery();
            sqlInsertSongIntoPlayComm9.ExecuteNonQuery();
            sqlInsertSongIntoPlayComm10.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void clearPlaylistButton_Click(object sender, EventArgs e)
        {
            playlistNameTextBox.Text = "Playlist Name";
            song1TextBox.Text = "Song ID 1";
            song2TextBox.Text = "Song ID 2";
            song3TextBox.Text = "Song ID 3";
            song4TextBox.Text = "Song ID 4";
            song5TextBox.Text = "Song ID 5";
            song6TextBox.Text = "Song ID 6";
            song7TextBox.Text = "Song ID 7";
            song8TextBox.Text = "Song ID 8";
            song9TextBox.Text = "Song ID 9";
            song10TextBox.Text = "Song ID 10";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addConcertButton_Click(object sender, EventArgs e)
        {
            addConcertGroupBox.Visible = true;
            addPlaylistGroupBox.Visible = false;

            string sqlGetSongArtistDataQuery = "SELECT song_id AS `Song ID`, song_name AS `Song Name`, AR.artist_id AS `Artist ID`, artist_name AS `Artist Name` " +
                                            "FROM Song S " +
                                            "Join Artist AR ON AR.artist_id = S.artist_id " +
                                            "ORDER BY song_id";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlGetSongArtistCommand = new MySqlCommand(sqlGetSongArtistDataQuery, sqlConnection);
            MySqlDataAdapter sqlSongArtistDataAd = new MySqlDataAdapter(sqlGetSongArtistCommand);
            DataTable songArtistDataTable = new DataTable();
            sqlSongArtistDataAd.Fill(songArtistDataTable);
            songArtistDataGridView.DataSource = songArtistDataTable;
            sqlConnection.Close();
        }

        private void clearConcertButton_Click(object sender, EventArgs e)
        {
            artistIDTextBox.Text = "Artist ID";
            cityTextBox.Text = "City";
            venueTextBox.Text = "Venue";
            countryTextBox.Text = "Country";
            yearTextBox.Text = "Year";
            songID1TextBox.Text = "Song ID 1";
            songID2TextBox.Text = "Song ID 2";
            songID3TextBox.Text = "Song ID 3";
            songID4TextBox.Text = "Song ID 4";
            songID5TextBox.Text = "Song ID 5";
            songID6TextBox.Text = "Song ID 6";
            songID7TextBox.Text = "Song ID 7";
            songID8TextBox.Text = "Song ID 8";
            songID9TextBox.Text = "Song ID 9";
            songID10TextBox.Text = "Song ID 10";

        }

        private void createConcertButton_Click(object sender, EventArgs e)
        {
            string userArtistID = artistIDTextBox.Text;
            string userCity = cityTextBox.Text;
            string userVenue = venueTextBox.Text;
            string userCountry = countryTextBox.Text;
            string userYear = yearTextBox.Text;
            string userSong1 = songID1TextBox.Text;
            string userSong2 = songID2TextBox.Text;
            string userSong3 = songID3TextBox.Text;
            string userSong4 = songID4TextBox.Text;
            string userSong5 = songID5TextBox.Text;
            string userSong6 = songID6TextBox.Text;
            string userSong7 = songID7TextBox.Text;
            string userSong8 = songID8TextBox.Text;
            string userSong9 = songID9TextBox.Text;
            string userSong10 = songID10TextBox.Text;

            string sqlInsertConcertQuery = "INSERT INTO blairs2_db.Concert (city, venue, country, year) " +
                "VALUES (@city, @venue, @country, @year)";

            string sqlInsertArtistConQuery = "INSERT INTO blairs2_db.Artist_concert (artist_id, concert_id) " +
                "VALUES (@artistID, " +
                "(SELECT concert_id FROM Concert WHERE city = @city AND venue = @venue AND country = @country AND year = @year))";

            string sqlInsertSongConQuery1 = "INSERT INTO blairs2_db.Song_concert (song_id, concert_id) " +
                "VALUES (@songID1, " +
                "(SELECT concert_id FROM Concert WHERE city = @city AND venue = @venue AND country = @country AND year = @year))";
            string sqlInsertSongConQuery2 = "INSERT INTO blairs2_db.Song_concert (song_id, concert_id) " +
                 "VALUES (@songID2, " +
                 "(SELECT concert_id FROM Concert WHERE city = @city AND venue = @venue AND country = @country AND year = @year))";
            string sqlInsertSongConQuery3 = "INSERT INTO blairs2_db.Song_concert (song_id, concert_id) " +
                 "VALUES (@songID3, " +
                 "(SELECT concert_id FROM Concert WHERE city = @city AND venue = @venue AND country = @country AND year = @year))";
            string sqlInsertSongConQuery4 = "INSERT INTO blairs2_db.Song_concert (song_id, concert_id) " +
                 "VALUES (@songID4, " +
                 "(SELECT concert_id FROM Concert WHERE city = @city AND venue = @venue AND country = @country AND year = @year))";
            string sqlInsertSongConQuery5 = "INSERT INTO blairs2_db.Song_concert (song_id, concert_id) " +
                 "VALUES (@songID5, " +
                 "(SELECT concert_id FROM Concert WHERE city = @city AND venue = @venue AND country = @country AND year = @year))";
            string sqlInsertSongConQuery6 = "INSERT INTO blairs2_db.Song_concert (song_id, concert_id) " +
                 "VALUES (@songID6, " +
                  "(SELECT concert_id FROM Concert WHERE city = @city AND venue = @venue AND country = @country AND year = @year))";
            string sqlInsertSongConQuery7 = "INSERT INTO blairs2_db.Song_concert (song_id, concert_id) " +
                 "VALUES (@songID7, " +
                 "(SELECT concert_id FROM Concert WHERE city = @city AND venue = @venue AND country = @country AND year = @year))";
            string sqlInsertSongConQuery8 = "INSERT INTO blairs2_db.Song_concert (song_id, concert_id) " +
                 "VALUES (@songID8, " +
                 "(SELECT concert_id FROM Concert WHERE city = @city AND venue = @venue AND country = @country AND year = @year))";
            string sqlInsertSongConQuery9 = "INSERT INTO blairs2_db.Song_concert (song_id, concert_id) " +
                 "VALUES (@songID9, " +
                 "(SELECT concert_id FROM Concert WHERE city = @city AND venue = @venue AND country = @country AND year = @year))";
            string sqlInsertSongConQuery10 = "INSERT INTO blairs2_db.Song_concert (song_id, concert_id) " +
                 "VALUES (@songID10, " +
                 "(SELECT concert_id FROM Concert WHERE city = @city AND venue = @venue AND country = @country AND year = @year))";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlInsertConcertCommand = new MySqlCommand(sqlInsertConcertQuery, sqlConnection);
            MySqlCommand sqlInsertArtistConCommand = new MySqlCommand(sqlInsertArtistConQuery, sqlConnection);
            MySqlCommand sqlInsertSongConCommand1 = new MySqlCommand(sqlInsertSongConQuery1, sqlConnection);
            MySqlCommand sqlInsertSongConCommand2 = new MySqlCommand(sqlInsertSongConQuery2, sqlConnection);
            MySqlCommand sqlInsertSongConCommand3 = new MySqlCommand(sqlInsertSongConQuery3, sqlConnection);
            MySqlCommand sqlInsertSongConCommand4 = new MySqlCommand(sqlInsertSongConQuery4, sqlConnection);
            MySqlCommand sqlInsertSongConCommand5 = new MySqlCommand(sqlInsertSongConQuery5, sqlConnection);
            MySqlCommand sqlInsertSongConCommand6 = new MySqlCommand(sqlInsertSongConQuery6, sqlConnection);
            MySqlCommand sqlInsertSongConCommand7 = new MySqlCommand(sqlInsertSongConQuery7, sqlConnection);
            MySqlCommand sqlInsertSongConCommand8 = new MySqlCommand(sqlInsertSongConQuery8, sqlConnection);
            MySqlCommand sqlInsertSongConCommand9 = new MySqlCommand(sqlInsertSongConQuery9, sqlConnection);
            MySqlCommand sqlInsertSongConCommand10 = new MySqlCommand(sqlInsertSongConQuery10, sqlConnection);


            sqlInsertConcertCommand.Parameters.Add("@city", MySqlDbType.VarChar).Value = userCity;
            sqlInsertConcertCommand.Parameters.Add("@venue", MySqlDbType.VarChar).Value = userVenue;
            sqlInsertConcertCommand.Parameters.Add("@country", MySqlDbType.VarChar).Value = userCountry;
            sqlInsertConcertCommand.Parameters.Add("@year", MySqlDbType.VarChar).Value = userYear;

            sqlInsertArtistConCommand.Parameters.Add("@artistID", MySqlDbType.VarChar).Value = userArtistID;
            sqlInsertArtistConCommand.Parameters.Add("@city", MySqlDbType.VarChar).Value = userCity;
            sqlInsertArtistConCommand.Parameters.Add("@venue", MySqlDbType.VarChar).Value = userVenue;
            sqlInsertArtistConCommand.Parameters.Add("@country", MySqlDbType.VarChar).Value = userCountry;
            sqlInsertArtistConCommand.Parameters.Add("@year", MySqlDbType.VarChar).Value = userYear;

            sqlInsertSongConCommand1.Parameters.Add("@songID1", MySqlDbType.VarChar).Value = userSong1;
            sqlInsertSongConCommand1.Parameters.Add("@city", MySqlDbType.VarChar).Value = userCity;
            sqlInsertSongConCommand1.Parameters.Add("@venue", MySqlDbType.VarChar).Value = userVenue;
            sqlInsertSongConCommand1.Parameters.Add("@country", MySqlDbType.VarChar).Value = userCountry;
            sqlInsertSongConCommand1.Parameters.Add("@year", MySqlDbType.VarChar).Value = userYear;

            sqlInsertSongConCommand2.Parameters.Add("@songID2", MySqlDbType.VarChar).Value = userSong2;
            sqlInsertSongConCommand2.Parameters.Add("@city", MySqlDbType.VarChar).Value = userCity;
            sqlInsertSongConCommand2.Parameters.Add("@venue", MySqlDbType.VarChar).Value = userVenue;
            sqlInsertSongConCommand2.Parameters.Add("@country", MySqlDbType.VarChar).Value = userCountry;
            sqlInsertSongConCommand2.Parameters.Add("@year", MySqlDbType.Int16).Value = userYear;

            sqlInsertSongConCommand3.Parameters.Add("@songID3", MySqlDbType.VarChar).Value = userSong3;
            sqlInsertSongConCommand3.Parameters.Add("@city", MySqlDbType.VarChar).Value = userCity;
            sqlInsertSongConCommand3.Parameters.Add("@venue", MySqlDbType.VarChar).Value = userVenue;
            sqlInsertSongConCommand3.Parameters.Add("@country", MySqlDbType.VarChar).Value = userCountry;
            sqlInsertSongConCommand3.Parameters.Add("@year", MySqlDbType.VarChar).Value = userYear;

            sqlInsertSongConCommand4.Parameters.Add("@songID4", MySqlDbType.VarChar).Value = userSong4;
            sqlInsertSongConCommand4.Parameters.Add("@city", MySqlDbType.VarChar).Value = userCity;
            sqlInsertSongConCommand4.Parameters.Add("@venue", MySqlDbType.VarChar).Value = userVenue;
            sqlInsertSongConCommand4.Parameters.Add("@country", MySqlDbType.VarChar).Value = userCountry;
            sqlInsertSongConCommand4.Parameters.Add("@year", MySqlDbType.VarChar).Value = userYear;

            sqlInsertSongConCommand5.Parameters.Add("@songID5", MySqlDbType.VarChar).Value = userSong5;
            sqlInsertSongConCommand5.Parameters.Add("@city", MySqlDbType.VarChar).Value = userCity;
            sqlInsertSongConCommand5.Parameters.Add("@venue", MySqlDbType.VarChar).Value = userVenue;
            sqlInsertSongConCommand5.Parameters.Add("@country", MySqlDbType.VarChar).Value = userCountry;
            sqlInsertSongConCommand5.Parameters.Add("@year", MySqlDbType.VarChar).Value = userYear;

            sqlInsertSongConCommand6.Parameters.Add("@songID6", MySqlDbType.VarChar).Value = userSong6;
            sqlInsertSongConCommand6.Parameters.Add("@city", MySqlDbType.VarChar).Value = userCity;
            sqlInsertSongConCommand6.Parameters.Add("@venue", MySqlDbType.VarChar).Value = userVenue;
            sqlInsertSongConCommand6.Parameters.Add("@country", MySqlDbType.VarChar).Value = userCountry;
            sqlInsertSongConCommand6.Parameters.Add("@year", MySqlDbType.VarChar).Value = userYear;

            sqlInsertSongConCommand7.Parameters.Add("@songID7", MySqlDbType.VarChar).Value = userSong7;
            sqlInsertSongConCommand7.Parameters.Add("@city", MySqlDbType.VarChar).Value = userCity;
            sqlInsertSongConCommand7.Parameters.Add("@venue", MySqlDbType.VarChar).Value = userVenue;
            sqlInsertSongConCommand7.Parameters.Add("@country", MySqlDbType.VarChar).Value = userCountry;
            sqlInsertSongConCommand7.Parameters.Add("@year", MySqlDbType.VarChar).Value = userYear;

            sqlInsertSongConCommand8.Parameters.Add("@songID8", MySqlDbType.VarChar).Value = userSong8;
            sqlInsertSongConCommand8.Parameters.Add("@city", MySqlDbType.VarChar).Value = userCity;
            sqlInsertSongConCommand8.Parameters.Add("@venue", MySqlDbType.VarChar).Value = userVenue;
            sqlInsertSongConCommand8.Parameters.Add("@country", MySqlDbType.VarChar).Value = userCountry;
            sqlInsertSongConCommand8.Parameters.Add("@year", MySqlDbType.VarChar).Value = userYear;

            sqlInsertSongConCommand9.Parameters.Add("@songID9", MySqlDbType.VarChar).Value = userSong9;
            sqlInsertSongConCommand9.Parameters.Add("@city", MySqlDbType.VarChar).Value = userCity;
            sqlInsertSongConCommand9.Parameters.Add("@venue", MySqlDbType.VarChar).Value = userVenue;
            sqlInsertSongConCommand9.Parameters.Add("@country", MySqlDbType.VarChar).Value = userCountry;
            sqlInsertSongConCommand9.Parameters.Add("@year", MySqlDbType.VarChar).Value = userYear;

            sqlInsertSongConCommand10.Parameters.Add("@songID10", MySqlDbType.VarChar).Value = userSong10;
            sqlInsertSongConCommand10.Parameters.Add("@city", MySqlDbType.VarChar).Value = userCity;
            sqlInsertSongConCommand10.Parameters.Add("@venue", MySqlDbType.VarChar).Value = userVenue;
            sqlInsertSongConCommand10.Parameters.Add("@country", MySqlDbType.VarChar).Value = userCountry;
            sqlInsertSongConCommand10.Parameters.Add("@year", MySqlDbType.VarChar).Value = userYear;

            sqlInsertConcertCommand.ExecuteNonQuery();
            sqlInsertArtistConCommand.ExecuteNonQuery();
            sqlInsertSongConCommand1.ExecuteNonQuery();
            sqlInsertSongConCommand2.ExecuteNonQuery();
            sqlInsertSongConCommand3.ExecuteNonQuery();
            sqlInsertSongConCommand4.ExecuteNonQuery();
            sqlInsertSongConCommand5.ExecuteNonQuery();
            sqlInsertSongConCommand6.ExecuteNonQuery();
            sqlInsertSongConCommand7.ExecuteNonQuery();
            sqlInsertSongConCommand8.ExecuteNonQuery();
            sqlInsertSongConCommand9.ExecuteNonQuery();
            sqlInsertSongConCommand10.ExecuteNonQuery();

            sqlConnection.Close();
        }

    }
}
