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
    public partial class updatePage : Form
    {
        public updatePage()
        {
            InitializeComponent();
        }
        private void updatePage_Load(object sender, EventArgs e)
        {
            string showPlaylistQuery = "SELECT playlist_name AS 'Playlist Name', playlist_id AS 'Playlist ID' " +
                 "FROM Playlist";

            string sqlGetSongDataQuery = "SELECT song_id AS `Song ID`, song_name AS `Song Name` " +
                                "FROM Song";

            string sqlGetConcertDataQuery = "SELECT concert_id AS `Concert ID`, venue AS `Venue`, city AS `City`, state AS `State`, country AS `Country`, year AS `Year` " +
                                 "FROM Concert";

            string mainConn = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConn = new MySqlConnection(mainConn);
            sqlConn.Open();

            MySqlCommand sqlPlaylistCommand = new MySqlCommand(showPlaylistQuery, sqlConn);
            MySqlDataAdapter sqlPlaylistAdapter = new MySqlDataAdapter(sqlPlaylistCommand);
            DataTable playlistDataTable = new DataTable();
            sqlPlaylistAdapter.Fill(playlistDataTable);
            updatePlaylistDataGridView.DataSource = playlistDataTable;
            playlistIDGridView.DataSource = playlistDataTable;

            MySqlCommand sqlGetSongCommand = new MySqlCommand(sqlGetSongDataQuery, sqlConn);
            MySqlDataAdapter sqlGetSongAdapter = new MySqlDataAdapter(sqlGetSongCommand);
            DataTable songDataTable = new DataTable();
            sqlGetSongAdapter.Fill(songDataTable);
            songDataGridView.DataSource = songDataTable;

            MySqlCommand sqlGetDataCommand = new MySqlCommand(sqlGetConcertDataQuery, sqlConn);
            MySqlDataAdapter sqlGetConcertAdapter = new MySqlDataAdapter(sqlGetDataCommand);
            DataTable concertDataTable = new DataTable();
            sqlGetConcertAdapter.Fill(concertDataTable);
            concertDataGridView.DataSource = concertDataTable;

            sqlConn.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updatePlaylistButton_Click(object sender, EventArgs e)
        {
            updatePlaylistGroupBox.Visible = true;
            updateSongGroupBox.Visible = false;
            updateConcertGroupBox.Visible = false;
        }

        private void updateSongButton_Click(object sender, EventArgs e)
        {
            updatePlaylistGroupBox.Visible = false;
            updateSongGroupBox.Visible = true;
            updateConcertGroupBox.Visible = false;
        }

        private void updateConcertButton_Click(object sender, EventArgs e)
        {
            updatePlaylistGroupBox.Visible = false;
            updateSongGroupBox.Visible = false;
            updateConcertGroupBox.Visible = true;
        }

        private void playlistUpdateButton_Click(object sender, EventArgs e)
        {
            string userPlaylistID = playlistIDTextBox.Text;
            string userPlaylistName = newPlaylistNameTextBox.Text;

            string sqlUpdatePlaylistQuery = "UPDATE Playlist " +
                                         "SET playlist_name = @playlistName " +
                                         "WHERE playlist_id = @playlistID";


            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlUpdatePlaylistCommand = new MySqlCommand(sqlUpdatePlaylistQuery, sqlConnection);

            sqlUpdatePlaylistCommand.Parameters.Add("@playlistID", MySqlDbType.VarChar).Value = userPlaylistID;
            sqlUpdatePlaylistCommand.Parameters.Add("@playlistName", MySqlDbType.VarChar).Value = userPlaylistName;

            int playlistResult = sqlUpdatePlaylistCommand.ExecuteNonQuery();

            if (playlistResult < 0)
            {
                MessageBox.Show("Error updating playlist from Database!");
            }
            if (playlistResult > 0)
            {
                MessageBox.Show("Success updating playlist from Database!");
            }

        }

        private void songUpdateButton_Click(object sender, EventArgs e)
        {
            string userPlaylistID = playSongTextBox.Text;
            string songID1 = songTextBox1.Text;

            string sqlInsertSongsIntoPlaylistQuery1 = "INSERT INTO blairs2_db.Song_playlist(song_id, playlist_id) " +
                               "VALUES(@songID1, @playlistID)";


            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlInsertSongIntoPlayComm1 = new MySqlCommand(sqlInsertSongsIntoPlaylistQuery1, sqlConnection);


            sqlInsertSongIntoPlayComm1.Parameters.Add("@songID1", MySqlDbType.VarChar).Value = songID1;
            sqlInsertSongIntoPlayComm1.Parameters.Add("@playlistID", MySqlDbType.VarChar).Value = userPlaylistID;

            int song1Result = sqlInsertSongIntoPlayComm1.ExecuteNonQuery();

            //Check error
            if (song1Result < 0)
            {
                MessageBox.Show("Error inserting songs into Playlist!");
            }
            //Check success
            if (song1Result > 0 )
            {
                MessageBox.Show("Success inserting songs into Playlist!");
            }


            sqlConnection.Close();
        }

        private void venueUpdateButton_Click(object sender, EventArgs e)
        {
            string concertID = venueConcertIDTextBox.Text;
            string newVenue = newVenueNameTextBox.Text;

            string sqlUpdateVenueQuery = "UPDATE Concert " +
                                    "SET venue = @venue " +
                                    "WHERE concert_id = @concertID";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlUpdateVenueCommand = new MySqlCommand(sqlUpdateVenueQuery, sqlConnection);

            sqlUpdateVenueCommand.Parameters.Add("@venue", MySqlDbType.VarChar).Value = newVenue;
            sqlUpdateVenueCommand.Parameters.Add("@concertID", MySqlDbType.VarChar).Value = concertID;

            int venueResult = sqlUpdateVenueCommand.ExecuteNonQuery();

            if (venueResult < 0)
            {
                MessageBox.Show("Error updating venue from Concert!");
            }
            if (venueResult > 0)
            {
                MessageBox.Show("Success updating venue from Concert!");
            }

        }

        private void updateCityButton_Click(object sender, EventArgs e)
        {
            string concertID = cityConcertIDTextBox.Text;
            string newCity = newCityTextBox.Text;

            string sqlUpdateCityQuery = "UPDATE Concert " +
                                    "SET city = @city " +
                                    "WHERE concert_id = @concertID";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlUpdateCityCommand = new MySqlCommand(sqlUpdateCityQuery, sqlConnection);

            sqlUpdateCityCommand.Parameters.Add("@city", MySqlDbType.VarChar).Value = newCity;
            sqlUpdateCityCommand.Parameters.Add("@concertID", MySqlDbType.VarChar).Value = concertID;

            int cityResult = sqlUpdateCityCommand.ExecuteNonQuery();

            if (cityResult < 0)
            {
                MessageBox.Show("Error updating city from Concert!");
            }
            if (cityResult > 0)
            {
                MessageBox.Show("Success updating city from Concert!");
            }
        }

        private void updateCountryButton_Click(object sender, EventArgs e)
        {
            string concertID = countryConcertIDTextBox.Text;
            string newCountry = newCountryTextBox.Text;

            string sqlUpdateCountryQuery = "UPDATE Concert " +
                                    "SET country = @country " +
                                    "WHERE concert_id = @concertID";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlUpdateCountryCommand = new MySqlCommand(sqlUpdateCountryQuery, sqlConnection);

            sqlUpdateCountryCommand.Parameters.Add("@country", MySqlDbType.VarChar).Value = newCountry;
            sqlUpdateCountryCommand.Parameters.Add("@concertID", MySqlDbType.VarChar).Value = concertID;

            int countryResult = sqlUpdateCountryCommand.ExecuteNonQuery();

            if (countryResult < 0)
            {
                MessageBox.Show("Error updating country from Concert!");
            }
            if (countryResult > 0)
            {
                MessageBox.Show("Success updating country from Concert!");
            }
        }

        private void updateYearButton_Click(object sender, EventArgs e)
        {
            string concertID = yearConcertIDTextBox.Text;
            string newYear = newYearTextBox.Text;

            string sqlUpdateYearQuery = "UPDATE Concert " +
                                    "SET year = @year " +
                                    "WHERE concert_id = @concertID";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlUpdateYearCommand = new MySqlCommand(sqlUpdateYearQuery, sqlConnection);

            sqlUpdateYearCommand.Parameters.Add("@year", MySqlDbType.VarChar).Value = newYear;
            sqlUpdateYearCommand.Parameters.Add("@concertID", MySqlDbType.VarChar).Value = concertID;

            int yearResult = sqlUpdateYearCommand.ExecuteNonQuery();

            if (yearResult < 0)
            {
                MessageBox.Show("Error updating year from Concert!");
            }
            if (yearResult > 0)
            {
                MessageBox.Show("Success updating year from Concert!");
            }
        }

        private void updateStateButton_Click(object sender, EventArgs e)
        {
            string concertID = stateConcertIDTextBox.Text;
            string newState = newStateTextBox.Text;

            string sqlUpdateStateQuery = "UPDATE Concert " +
                                    "SET state = @state " +
                                    "WHERE concert_id = @concertID";

            string mainConnection = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(mainConnection);
            sqlConnection.Open();

            MySqlCommand sqlUpdateStateCommand = new MySqlCommand(sqlUpdateStateQuery, sqlConnection);

            sqlUpdateStateCommand.Parameters.Add("@state", MySqlDbType.VarChar).Value = newState;
            sqlUpdateStateCommand.Parameters.Add("@concertID", MySqlDbType.VarChar).Value = concertID;

            int stateResult = sqlUpdateStateCommand.ExecuteNonQuery();

            if (stateResult < 0)
            {
                MessageBox.Show("Error updating state from Concert!");
            }
            if (stateResult > 0)
            {
                MessageBox.Show("Success updating state from Concert!");
            }
        }
    }
}
