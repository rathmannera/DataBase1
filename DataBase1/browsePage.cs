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
    public partial class browsePage : Form
    {
        public browsePage()
        {
            InitializeComponent();
        }
       private void browsePage_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dbDataSet.Song' table. You can move, or remove it, as needed.
            this.songTableAdapter.Fill(this.dbDataSet.Song);
            //string selectArtistQuery = "SELECT artist_name AS `Artist`, album_name AS `Album`, song_name AS `Song Title` " +
            //                        "FROM Song S " +
            //                        "JOIN Artist AR ON AR.artist_id = S.artist_id " +
            //                        "JOIN Song_album SAL ON SAL.song_id = S.song_id " +
            //                        "JOIN Album AL ON SAL.album_id = AL.album_id";
           
            //string selectSongQuery = "SELECT song_name AS `Song Title`, artist_name AS `Artist`, album_name AS `Album` " +
            //                        "FROM Song S " +
            //                        "JOIN Artist AR ON AR.artist_id = S.artist_id " +
            //                        "JOIN Song_album SAL ON SAL.song_id = S.song_id " +
            //                        "JOIN Album AL ON SAL.album_id = AL.album_id";
           
            //string selectAlbumQuery = "SELECT album_name AS `Album`, artist_name AS `Artist`, song_name AS `Song Title` " +
            //                            "FROM Song S " +
            //                            "JOIN Artist AR ON AR.artist_id = S.artist_id " +
            //                            "JOIN Song_album SAL ON SAL.song_id = S.song_id " +
            //                            "JOIN Album AL ON SAL.album_id = AL.album_id";

            //string selectPlaylistQuery = "SELECT playlist_name AS `Playlist Name`, song_name AS `Songs on Playlist`, SEC_TO_TIME(SUM(TIME_TO_SEC(S. length))) AS `Playlist Duration` " +
            //                            "FROM Song S " +
            //                            "JOIN Song_playlist SP ON SP.song_id = S.song_id " +
            //                            "JOIN Playlist P ON P.playlist_id = SP.playlist_id " +
            //                            "GROUP BY playlist_name, song_name;";

            //string mainConn = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            //MySqlConnection sqlConn = new MySqlConnection(mainConn);
            
            //sqlConn.Open();

            //MySqlCommand sqlSongCommand = new MySqlCommand(selectSongQuery, sqlConn);
            //MySqlDataAdapter sqlSongAdapter = new MySqlDataAdapter(sqlSongCommand);
            //DataTable songDataTable = new DataTable();
            //sqlSongAdapter.Fill(songDataTable);
            //bySongDataGridView.DataSource = songDataTable;

            //MySqlCommand sqlArtistCommand = new MySqlCommand(selectArtistQuery, sqlConn);
            //MySqlDataAdapter sqlArtistAdapter = new MySqlDataAdapter(sqlArtistCommand);
            //DataTable artistDataTable = new DataTable();
            //sqlArtistAdapter.Fill(artistDataTable);
            //byArtistDataGridView.DataSource = artistDataTable;

            //MySqlCommand sqlAlbumCommand = new MySqlCommand(selectAlbumQuery, sqlConn);
            //MySqlDataAdapter sqlAlbumAdapter = new MySqlDataAdapter(sqlAlbumCommand);
            //DataTable albumDataTable = new DataTable();
            //sqlAlbumAdapter.Fill(albumDataTable);
            //byAlbumDataGridView.DataSource = albumDataTable;

            //MySqlCommand sqlPlaylistCommand = new MySqlCommand(selectPlaylistQuery, sqlConn);
            //MySqlDataAdapter sqlPlaylistAdapter = new MySqlDataAdapter(sqlPlaylistCommand);
            //DataTable playlistDataTable = new DataTable();
            //sqlPlaylistAdapter.Fill(playlistDataTable);
            //byPlaylistDataGridView.DataSource = playlistDataTable;

            //sqlConn.Close();

        }

        private void browseBySongButton_Click(object sender, EventArgs e)
        {
            browseDataGridView.DataSource = null;

            string selectSongQuery = "SELECT song_name AS `Song Title`, artist_name AS `Artist`, album_name AS `Album` " +
                                    "FROM Song S " +
                                    "JOIN Artist AR ON AR.artist_id = S.artist_id " +
                                    "JOIN Song_album SAL ON SAL.song_id = S.song_id " +
                                    "JOIN Album AL ON SAL.album_id = AL.album_id " +
                                    "ORDER BY song_name";


            string mainConn = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConn = new MySqlConnection(mainConn);

            sqlConn.Open();

            MySqlCommand sqlSongCommand = new MySqlCommand(selectSongQuery, sqlConn);
            MySqlDataAdapter sqlSongAdapter = new MySqlDataAdapter(sqlSongCommand);
            DataTable songDataTable = new DataTable();
            sqlSongAdapter.Fill(songDataTable);
            browseDataGridView.DataSource = songDataTable;

            sqlConn.Close();
        }

        private void browseByArtistButton_Click(object sender, EventArgs e)
        {
            browseDataGridView.DataSource = null;

            string selectArtistQuery = "SELECT artist_name AS `Artist`, album_name AS `Album`, song_name AS `Song Title` " +
                                    "FROM Song S " +
                                    "JOIN Artist AR ON AR.artist_id = S.artist_id " +
                                    "JOIN Song_album SAL ON SAL.song_id = S.song_id " +
                                    "JOIN Album AL ON SAL.album_id = AL.album_id " +
                                    "ORDER BY artist_name";

            string mainConn = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConn = new MySqlConnection(mainConn);

            sqlConn.Open();

            MySqlCommand sqlArtistCommand = new MySqlCommand(selectArtistQuery, sqlConn);
            MySqlDataAdapter sqlArtistAdapter = new MySqlDataAdapter(sqlArtistCommand);
            DataTable artistDataTable = new DataTable();
            sqlArtistAdapter.Fill(artistDataTable);
            browseDataGridView.DataSource = artistDataTable;

            sqlConn.Close();
        }

        private void browseByAlbumButton_Click(object sender, EventArgs e)
        {
            browseDataGridView.DataSource = null;

            string selectAlbumQuery = "SELECT album_name AS `Album`, artist_name AS `Artist`, song_name AS `Song Title` " +
                                        "FROM Song S " +
                                        "JOIN Artist AR ON AR.artist_id = S.artist_id " +
                                        "JOIN Song_album SAL ON SAL.song_id = S.song_id " +
                                        "JOIN Album AL ON SAL.album_id = AL.album_id " +
                                        "ORDER BY album_name";

            string mainConn = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConn = new MySqlConnection(mainConn);

            sqlConn.Open();

            MySqlCommand sqlAlbumCommand = new MySqlCommand(selectAlbumQuery, sqlConn);
            MySqlDataAdapter sqlAlbumAdapter = new MySqlDataAdapter(sqlAlbumCommand);
            DataTable albumDataTable = new DataTable();
            sqlAlbumAdapter.Fill(albumDataTable);
            browseDataGridView.DataSource = albumDataTable;

            sqlConn.Close();
        }

        private void browseByPlaylistButton_Click(object sender, EventArgs e)
        {
            browseDataGridView.DataSource = null;

            string selectPlaylistQuery = "SELECT playlist_name AS 'Playlist Name', SEC_TO_TIME(SUM(TIME_TO_SEC(S.length))) AS 'Playlist Duration' " +
                                            "FROM Song S " +
                                            "JOIN Song_playlist SP ON SP.song_id = S.song_id " +
                                            "JOIN Playlist P ON P.playlist_id = SP.playlist_id " +
                                            "GROUP BY(playlist_name) " +
                                            "ORDER BY playlist_name";

            //SELECT playlist_name AS 'Playlist Name', SEC_TO_TIME(SUM(TIME_TO_SEC(S. length))) AS 'Playlist Duration'
            //FROM Song S JOIN Song_playlist SP ON SP.song_id = S.song_id JOIN Playlist P ON P.playlist_id = SP.playlist_id GROUP BY(playlist_name);

            string mainConn = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConn = new MySqlConnection(mainConn);

            sqlConn.Open();

            MySqlCommand sqlPlaylistCommand = new MySqlCommand(selectPlaylistQuery, sqlConn);
            MySqlDataAdapter sqlPlaylistAdapter = new MySqlDataAdapter(sqlPlaylistCommand);
            DataTable playlistDataTable = new DataTable();
            sqlPlaylistAdapter.Fill(playlistDataTable);
            browseDataGridView.DataSource = playlistDataTable;

            sqlConn.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
