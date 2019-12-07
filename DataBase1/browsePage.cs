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
            string selectArtistQuery = "SELECT artist_name AS `Artist`, album_name AS `Album`, song_name AS `Song Title` " +
                                    "FROM Song S " +
                                    "JOIN Artist AR ON AR.artist_id = S.artist_id " +
                                    "JOIN Song_album SAL ON SAL.song_id = S.song_id " +
                                    "JOIN Album AL ON SAL.album_id = AL.album_id";
           
            string selectSongQuery = "SELECT song_name AS `Song Title`, artist_name AS `Artist`, album_name AS `Album` " +
                                    "FROM Song S " +
                                    "JOIN Artist AR ON AR.artist_id = S.artist_id " +
                                    "JOIN Song_album SAL ON SAL.song_id = S.song_id " +
                                    "JOIN Album AL ON SAL.album_id = AL.album_id";
           
            string selectAlbumQuery = "SELECT album_name AS `Album`, artist_name AS `Artist`, song_name AS `Song Title` " +
                                        "FROM Song S " +
                                        "JOIN Artist AR ON AR.artist_id = S.artist_id " +
                                        "JOIN Song_album SAL ON SAL.song_id = S.song_id " +
                                        "JOIN Album AL ON SAL.album_id = AL.album_id";

            string selectPlaylistQuery = "SELECT playlist_name AS `Playlist Name`, song_name AS `Songs on Playlist`, SUM(S.length) AS `Playlist Duration` " +
                                           "FROM Song S " +
                                           "JOIN Song_playlist SP ON SP.song_id = S.song_id " +
                                           "JOIN Playlist P ON P.playlist_id = SP.playlist_id " +
                                           "GROUP BY playlist_name, song_name;";

            string mainConn = ConfigurationManager.ConnectionStrings["DataBase1.Properties.Settings.dbConnectionString"].ConnectionString;
            MySqlConnection sqlConn = new MySqlConnection(mainConn);
            
            sqlConn.Open();

            MySqlCommand sqlSongCommand = new MySqlCommand(selectSongQuery, sqlConn);
            MySqlDataAdapter sqlSongAdapter = new MySqlDataAdapter(sqlSongCommand);
            DataTable songDataTable = new DataTable();
            sqlSongAdapter.Fill(songDataTable);
            bySongDataGridView.DataSource = songDataTable;

            MySqlCommand sqlArtistCommand = new MySqlCommand(selectArtistQuery, sqlConn);
            MySqlDataAdapter sqlArtistAdapter = new MySqlDataAdapter(sqlArtistCommand);
            DataTable artistDataTable = new DataTable();
            sqlArtistAdapter.Fill(artistDataTable);
            byArtistDataGridView.DataSource = artistDataTable;

            MySqlCommand sqlAlbumCommand = new MySqlCommand(selectAlbumQuery, sqlConn);
            MySqlDataAdapter sqlAlbumAdapter = new MySqlDataAdapter(sqlAlbumCommand);
            DataTable albumDataTable = new DataTable();
            sqlAlbumAdapter.Fill(albumDataTable);
            byAlbumDataGridView.DataSource = albumDataTable;

            MySqlCommand sqlPlaylistCommand = new MySqlCommand(selectPlaylistQuery, sqlConn);
            MySqlDataAdapter sqlPlaylistAdapter = new MySqlDataAdapter(sqlPlaylistCommand);
            DataTable playlistDataTable = new DataTable();
            sqlPlaylistAdapter.Fill(playlistDataTable);
            byPlaylistDataGridView.DataSource = playlistDataTable;

            sqlConn.Close();

        }

        private void browseBySongButton_Click(object sender, EventArgs e)
        {
            bySongDataGridView.Visible = true;
            byArtistDataGridView.Visible = false;
            byAlbumDataGridView.Visible = false;
            byPlaylistDataGridView.Visible = false;
        }

        private void browseByArtistButton_Click(object sender, EventArgs e)
        {
            byArtistDataGridView.Visible = true;
            bySongDataGridView.Visible = false;
            byAlbumDataGridView.Visible = false;
            byPlaylistDataGridView.Visible = false;
        }

        private void browseByAlbumButton_Click(object sender, EventArgs e)
        {
            byAlbumDataGridView.Visible = true;
            byArtistDataGridView.Visible = false;
            bySongDataGridView.Visible = false;
            byPlaylistDataGridView.Visible = false;
        }

        private void browseByPlaylistButton_Click(object sender, EventArgs e)
        {
            byPlaylistDataGridView.Visible = true;
            byAlbumDataGridView.Visible = false;
            byArtistDataGridView.Visible = false;
            bySongDataGridView.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
