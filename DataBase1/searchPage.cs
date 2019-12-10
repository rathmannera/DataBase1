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
    public partial class searchPage : Form
    {     
        string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;

        public searchPage()
        {
            InitializeComponent();
        }

        private void searchPage_Load(object sender, EventArgs e)
        {

        }

        private void songSearchButton_Click(object sender, EventArgs e)
        {
            string userSongSearch = songSearchTextBox.Text;
            string sqlSongSearchQuery = "SELECT song_name AS `Song Name`, artist_name AS `Artist`, album_name AS `Album` " +
                                        "FROM Song S " +
                                        "JOIN Artist AR ON AR.artist_id = S.artist_id " +
                                        "JOIN Song_album SAL ON S.song_id = SAL.song_id " +
                                        "JOIN Album AL ON SAL.album_id = AL.album_id " +
                                        "WHERE song_name LIKE '%" + @userSongSearch + "%'";

            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlSongSearchCommand = new MySqlCommand(sqlSongSearchQuery, sqlConnection);
            MySqlDataAdapter sqlSongSearchDataAd = new MySqlDataAdapter(sqlSongSearchCommand);
            DataTable songSearchDataTable = new DataTable();
            sqlSongSearchDataAd.Fill(songSearchDataTable);
            searchGridView.DataSource = songSearchDataTable;
            sqlConnection.Close();
        }

        private void albumSearchButton_Click_1(object sender, EventArgs e)
        {
            string userAlbumSearch = albumSearchTextBox.Text;
            string sqlAlbumSearchQuery = "SELECT album_name AS `Album`, artist_name AS `Artist`, song_name AS `Song` " +
                                            "FROM Album AL " +
                                            "JOIN Artist_album ARAL ON AL.album_id = ARAL.album_id " +
                                            "JOIN Artist AR ON AR.artist_id = ARAL.artist_id " +
                                            "JOIN Song_album SAL ON AL.album_id = SAL.album_id " +
                                            "JOIN Song S ON SAL.song_id = S.song_id " +
                                            "WHERE album_name LIKE '%" + @userAlbumSearch + "%'";


            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlAlbumSearchCommand = new MySqlCommand(sqlAlbumSearchQuery, sqlConnection);
            MySqlDataAdapter sqlAlbumSearchDataAd = new MySqlDataAdapter(sqlAlbumSearchCommand);
            DataTable albumSearchDataTable = new DataTable();
            sqlAlbumSearchDataAd.Fill(albumSearchDataTable);
            searchGridView.DataSource = albumSearchDataTable;
            sqlConnection.Close();
        }

        private void artistSearchButton_Click(object sender, EventArgs e)
        {
            string userArtistSearch = artistSearchTextBox.Text;
            string sqlArtistSearchQuery = "SELECT artist_name AS `Artist`, album_name AS `Album`, label_name AS `Label` " +
                                            "FROM Artist AR " +
                                            "JOIN Artist_album ARAL ON AR.artist_id = ARAL.artist_id " +
                                            "JOIN Album AL ON AL.album_id = ARAL.album_id " +
                                            "JOIN Label L ON AR.label_id = L.label_id " +
                                            "WHERE artist_name LIKE '%" + @userArtistSearch + "%'";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlArtistSearchCommand = new MySqlCommand(sqlArtistSearchQuery, sqlConnection);
            MySqlDataAdapter sqlArtistSearchDataAd = new MySqlDataAdapter(sqlArtistSearchCommand);
            DataTable artistSearchDataTable = new DataTable();
            sqlArtistSearchDataAd.Fill(artistSearchDataTable);
            searchGridView.DataSource = artistSearchDataTable;
            sqlConnection.Close();
        }

        private void concertSearchButton_Click(object sender, EventArgs e)
        {
            string userConcertSearch = concertSearchTextBox.Text;
            string sqlConcertSearchQuery = "SELECT artist_name AS `Artist`, venue AS `Venue`, city AS `City`, song_name AS `Songs`, year AS `Year` " +
                                                        "FROM Concert C " +
                                                        "JOIN Artist_concert ARC ON C.concert_id = ARC.concert_id " +
                                                        "JOIN Artist AR ON ARC.artist_id = AR.artist_id " +
                                                        "JOIN Song_concert SC ON C.concert_id = SC.concert_id " +
                                                        "JOIN Song S ON SC.song_id=S.song_id " +
                                                        "WHERE artist_name LIKE '%" + @userConcertSearch + "%'";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlConcertSearchCommand = new MySqlCommand(sqlConcertSearchQuery, sqlConnection);
            MySqlDataAdapter sqlConcertSearchDataAd = new MySqlDataAdapter(sqlConcertSearchCommand);
            DataTable concertSearchDataTable = new DataTable();
            sqlConcertSearchDataAd.Fill(concertSearchDataTable);
            searchGridView.DataSource = concertSearchDataTable;
            sqlConnection.Close();
        }

        private void lyricSearchButton_Click(object sender, EventArgs e)
        {
            string userLyricSearch = lyricSearchTextBox.Text;
            string sqlLyricSearchQuery = "SELECT song_name AS `Song`, album_name AS `Album`, artist_name AS `Artist`, lyrics AS `Lyrics`" +
                                                        "FROM Song S " +
                                                        "JOIN Artist A ON S.artist_id = A.artist_id " +
                                                        "JOIN Song_album SA ON S.song_id = SA.song_id " +
                                                        "JOIN Album AL ON SA.album_id = AL.album_id " +
                                                        "WHERE lyrics LIKE '%" + @userLyricSearch + "%'";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlLyricSearchCommand = new MySqlCommand(sqlLyricSearchQuery, sqlConnection);
            MySqlDataAdapter sqlLyricSearchDataAd = new MySqlDataAdapter(sqlLyricSearchCommand);
            DataTable lyricSearchDataTable = new DataTable();
            sqlLyricSearchDataAd.Fill(lyricSearchDataTable);
            searchGridView.DataSource = lyricSearchDataTable;
            sqlConnection.Close();
        }

        private void playlistSearchButton_Click(object sender, EventArgs e)
        {
            string userPlaylistSearch = playlistSearchTextBox.Text;
            string sqlPlaylistSearchQuery = "SELECT playlist_name AS 'Playlist Name', SEC_TO_TIME(SUM(TIME_TO_SEC(S.length))) AS 'Playlist Duration' " +
                                "FROM Song S " +
                                "JOIN Song_playlist SP ON SP.song_id = S.song_id " +
                                "JOIN Playlist P ON P.playlist_id = SP.playlist_id " +
                                "WHERE playlist_name LIKE '%" + @userPlaylistSearch + "%' " +
                                "GROUP BY(playlist_name)";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlPlaylistSearchCommand = new MySqlCommand(sqlPlaylistSearchQuery, sqlConnection);
            MySqlDataAdapter sqlLyricSearchDataAd = new MySqlDataAdapter(sqlPlaylistSearchCommand);
            DataTable playlistSearchDataTable = new DataTable();
            sqlLyricSearchDataAd.Fill(playlistSearchDataTable);
            searchGridView.DataSource = playlistSearchDataTable;
            sqlConnection.Close();
        }

        private void labelSearchButton_Click(object sender, EventArgs e)
        {
            string userLabelSearch = labelSearchTextBox.Text;
            string sqlLabelSearchQuery = "SELECT label_name AS `Label`, album_name AS `Album`, artist_name AS `Artist` " +
                                             "FROM Label L " +
                                             "JOIN Artist A ON L.label_id = A.label_id " +
                                             "JOIN Album AL ON L.label_id = AL.label_id " +
                                             "WHERE label_name LIKE '%" + @userLabelSearch + "%'";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlLabelSearchCommand = new MySqlCommand(sqlLabelSearchQuery, sqlConnection);
            MySqlDataAdapter sqlLabelSearchDataAd = new MySqlDataAdapter(sqlLabelSearchCommand);
            DataTable labelSearchDataTable = new DataTable();
            sqlLabelSearchDataAd.Fill(labelSearchDataTable);
            searchGridView.DataSource = labelSearchDataTable;
            sqlConnection.Close();
        }

        private void genreSearchButton_Click(object sender, EventArgs e)
        {
            string userGenreSearch = genreSearchTextBox.Text;
            string sqlGenreSearchQuery = "SELECT genre AS `Genre`, artist_name AS `Artist`, album_name AS `Album` " +
                                                        "FROM Genre G " +
                                                        "JOIN Song S ON G.genre_id = S.genre_id " +
                                                        "JOIN Artist A ON S.artist_id = A.artist_id " +
                                                        "JOIN Artist_album ARA ON A.artist_id = ARA.artist_id " +
                                                        "JOIN Album AL ON ARA.album_id = AL.album_id " +
                                                        "WHERE genre LIKE '%" + @userGenreSearch + "%'";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlGenreSearchCommand = new MySqlCommand(sqlGenreSearchQuery, sqlConnection);
            MySqlDataAdapter sqlGenreSearchDataAd = new MySqlDataAdapter(sqlGenreSearchCommand);
            DataTable genreSearchDataTable = new DataTable();
            sqlGenreSearchDataAd.Fill(genreSearchDataTable);
            searchGridView.DataSource = genreSearchDataTable;
            sqlConnection.Close();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
