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
    public partial class deletePage : Form
    {
        public deletePage()
        {
            InitializeComponent();
        }
        private void deletePage_Load(object sender, EventArgs e)
        {
            string showPlaylistQuery = "SELECT playlist_name AS 'Playlist Name', playlist_id AS 'Playlist ID' " +
                             "FROM Playlist";

            string showConcertQuery = "SELECT C.concert_id AS 'Concert ID', venue AS 'Venue', city AS 'City', year AS 'Year', artist_name AS 'Artist' " +
                             "FROM Concert C " +
                             "JOIN Artist_concert ARC ON ARC.concert_id = C.concert_id " +
                             "JOIN Artist AR ON ARC.artist_id = AR.artist_id " +
                             "ORDER BY (C.concert_id)";
            string showSongPlaylistQuery = "SELECT P.playlist_id AS `Playlist ID`, playlist_name AS `Playlist Name`, S.song_id AS `Song ID`, song_name AS `Song Name` " +
                "FROM Playlist P " +
                "JOIN Song_playlist SP ON P.playlist_id = SP.playlist_id " +
                "JOIN Song S ON SP.song_id = S.song_id " +
                "ORDER BY P.playlist_id";

            string mainConn = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConn = new MySqlConnection(mainConn);
            sqlConn.Open();

            MySqlCommand sqlPlaylistCommand = new MySqlCommand(showPlaylistQuery, sqlConn);
            MySqlDataAdapter sqlPlaylistAdapter = new MySqlDataAdapter(sqlPlaylistCommand);
            DataTable playlistDataTable = new DataTable();
            sqlPlaylistAdapter.Fill(playlistDataTable);
            playlistDataGridView.DataSource = playlistDataTable;

            MySqlCommand sqlConcertCommand = new MySqlCommand(showConcertQuery, sqlConn);
            MySqlDataAdapter sqlConcertDataAdapter = new MySqlDataAdapter(sqlConcertCommand);
            DataTable concertDataTable = new DataTable();
            sqlConcertDataAdapter.Fill(concertDataTable);
            concertDataGridView.DataSource = concertDataTable;

            MySqlCommand sqlSongCommand = new MySqlCommand(showSongPlaylistQuery, sqlConn);
            MySqlDataAdapter sqlSongDataAdapter = new MySqlDataAdapter(sqlSongCommand);
            DataTable songDataTable = new DataTable();
            sqlSongDataAdapter.Fill(songDataTable);
            songPlaylistDataGridView.DataSource = songDataTable;

            sqlConn.Close();
        }
        private void deletePlaylistButton_Click(object sender, EventArgs e)
        {
            deletePlaylistGroupBox.Visible = true;
            deleteConcertGroupBox.Visible = false;
            deleteSongGroupBox.Visible = false;

        }
        private void playlistIDDeleteButton_Click(object sender, EventArgs e)
        {
            string userPlaylistId = playlistIDTextBox.Text;

            string sqlDeletePlaylistQuery = "DELETE FROM Playlist " +
                                              "WHERE playlist_id = @playlistID";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlDeletePlaylistCommand = new MySqlCommand(sqlDeletePlaylistQuery, sqlConnection);

            sqlDeletePlaylistCommand.Parameters.Add("@playlistID", MySqlDbType.VarChar).Value = userPlaylistId;

            int playlistResult = sqlDeletePlaylistCommand.ExecuteNonQuery();

            if (playlistResult < 0)
            {
                MessageBox.Show("Error deleting playlist from Database!");
            }
            if (playlistResult > 0)
            {
                MessageBox.Show("Success deleting playlist from Database!");
            }
        }
        private void deleteConcertButton_Click(object sender, EventArgs e)
        {
            deletePlaylistGroupBox.Visible = false;
            deleteConcertGroupBox.Visible = true;
            deleteSongGroupBox.Visible = false;
            concertDataGridView.Visible = true;
            enterConcertIDLabel.Visible = true;
            concertIDTextBox.Visible = true;
            concertIDDeleteButton.Visible = true;
        }

        private void concertIDDeleteButton_Click(object sender, EventArgs e)
        {
            string userConcertId = concertIDTextBox.Text;

            string sqlDeleteConcertQuery = "DELETE FROM Concert " +
                                        "WHERE concert_id = @concertID";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlDeleteConcertCommand = new MySqlCommand(sqlDeleteConcertQuery, sqlConnection);

            sqlDeleteConcertCommand.Parameters.Add("@concertID", MySqlDbType.VarChar).Value = userConcertId;

            int concertResult = sqlDeleteConcertCommand.ExecuteNonQuery();

            if (concertResult < 0)
            {
                MessageBox.Show("Error deleting playlist from Database!");
            }
            if (concertResult > 0)
            {
                MessageBox.Show("Success deleting playlist from Database!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteSongPlaylistButton_Click(object sender, EventArgs e)
        {
            deletePlaylistGroupBox.Visible = false;
            deleteConcertGroupBox.Visible = false;
            deleteSongGroupBox.Visible = true;
        }

        private void songDeleteButton_Click(object sender, EventArgs e)
        {
            string userSongID = songIDTextBox.Text;
            string userPlaylistID = playlistSongTextBox.Text;

            string sqlDeleteSongPlaylistQuery = "DELETE FROM Song_playlist " +
                "WHERE playlist_id = @playlistID AND song_id = @songID";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlDeleteSongCommand = new MySqlCommand(sqlDeleteSongPlaylistQuery, sqlConnection);

            sqlDeleteSongCommand.Parameters.Add("@playlistID", MySqlDbType.VarChar).Value = userPlaylistID;
            sqlDeleteSongCommand.Parameters.Add("@songID", MySqlDbType.VarChar).Value = userSongID;

            int songResult = sqlDeleteSongCommand.ExecuteNonQuery();

            if (songResult < 0)
            {
                MessageBox.Show("Error deleting song from playlist!");
            }
            if (songResult > 0)
            {
                MessageBox.Show("Success deleting song from playlist!");
            }
        }
    }
}
